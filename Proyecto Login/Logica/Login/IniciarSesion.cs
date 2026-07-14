using Datos;
using Entidad;
using Servicios;
using Sesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class IniciarSesion
    {
        private BitacoraServicio bitacora = new BitacoraServicio();
        Usuario usuariodatos = new Usuario(); // objeto de la capa Datos
        Empleado empleadodatos = new Empleado(); // objeto de la capa Datos
        public (bool Exito,string Mensaje,string Nombre) Iniciar(string contrasena)
        {
            //FLUJO DE INICIO DE SESION CON EMPLEADO PARA CREAR USUARIO
            if(contrasena.Length == 6)
            {
                string codigoAcceso = contrasena;
                var resultado = empleadodatos.ValidaryDarAltaEmpleado(codigoAcceso);

                if (!resultado.Exito)
                {
                    return (false, resultado.Mensaje, null);
                }
                else
                {
                    return (true, resultado.Mensaje, $"{EmpleadoSesion.ObtenerNombre()} {EmpleadoSesion.ObtenerApellido()}");
                }
            }
            else
            {
                // FLUJO DE INICIO DE SESION CON USUARIO
                // 1. Separar usuario y contraseña por el guión
                string[] partes = contrasena.Split('-');

                string usuario = partes[0];
                string contraseña = partes[1];

                // 2. Hashear la cadena completa (usuario-contraseña)
                string hash = ConvertirHash.GenerateSHA256Hash(contrasena);

                // 3. Buscar en la base de datos
                if (!usuariodatos.VerificarUsuario(usuario))
                {
                    return (false, "Error al conectar con la base de datos", null);
                }

                // 4. Validar los datos obtenidos
                int intentos = UsuarioSesion.ObtenerIntentosSesion();
                while (UsuarioSesion.EstaLogueado() == false)
                {
                    DateTime hora = DateTime.Now;
                    if (UsuarioSesion.ObtenerBloqueado())
                    {
                        while (UsuarioSesion.ObtenerBloqueado() == true)
                        {
                            if (hora < UsuarioSesion.ObtenerBloqueadoHasta())
                            {
                                string mensajeBloqueo = $"El usuario se encuentra bloqueado hasta {UsuarioSesion.ObtenerBloqueadoHasta():g}";
                                return (false, mensajeBloqueo, null);
                            }
                            else
                            {
                                UsuarioSesion.SetBloqueado(false);
                                UsuarioSesion.SetBloqueadoHasta(null);
                                usuariodatos.ReiniciarIntentos(usuario);
                            }
                        }
                    }
                    if (UsuarioSesion.ObtenerContraseña() != hash)
                    {
                        //registra los intentos fallidos
                        bitacora.Registrar( "Intento de iniciar fallido","El usuario ingreso una contraseña incorrecta.","SEGURIDAD","ADVERTENCIA");

                        usuariodatos.RestarIntentos(UsuarioSesion.ObtenerNombreUsuario());

                        if (UsuarioSesion.ObtenerBloqueado()) // cuando llega a 0 intentos 
                        {
                            bitacora.Registrar("Usuario bloqueado","El usuario supero la cantidad maxima de intentos permitidos.","SEGURIDAD","CRITICO");
                        }

                        return (false, "Contraseña incorrecta", null);
                    }
                    if (UsuarioSesion.ObtenerIntentosSesion() == 0 || UsuarioSesion.ObtenerTiempoResetIntentos() < hora)
                    {
                        string mensajeintentos = $"El usuario no tiene intentos suficientes hasta{UsuarioSesion.ObtenerTiempoResetIntentos()}";
                        return (false, mensajeintentos, null);
                    }
                    if (UsuarioSesion.ObtenerPrimeraVez())
                    {
                        return (true, "Complete el formulario de seguridad para continuar", null);
                    }

                    //5. Iniciar sesión
                    UsuarioSesion.ActivarSesion();
                    UsuarioSesion.SetFechaUltimoLogin(DateTime.Now);
                    usuariodatos.ReiniciarIntentos(usuario);
                    usuariodatos.ActualizarFechaUltimoLogin(UsuarioSesion.ObtenerNombreUsuario());
                }
                return (true, "Inicio de sesión exitoso", UsuarioSesion.ObtenerNombreUsuario());
            }
        }
    }
}
