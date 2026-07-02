using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Servicios;
using Sesion;

namespace Logica
{
    public class IniciarSesion
    {
        public (bool Exito,string Mensaje,string NombreUsuario) Iniciar(string contrasena)
        {
            if(contrasena == "null")
            {
                //ACA SE VERIFICA EL CODIGO DE ACCESO POR SER LA PRIMERA VEZ, SE COMPARA EL CODIGO ESTA EN UNA LISTA
                //DE LA BASE DE DATOS Y SI ESTA, EL USUARIO PUEDE ACCEDER Y SEGUI CON LA CREACION DEL USUARIO, CUANDO
                //TERMINA SE VUELVE AL  LOGIN Y DEBE CARGAR USUARIO-CONTRASEÑA Y REGISTRAR LAS RESPUESTAS DE SEGURIDAD
                //SI ES PRIMERA VEZ
                return (false, "hola", null);
            }
            else
            {
                // 1. Separar usuario y contraseña por el guión
                string[] partes = contrasena.Split('-');

                string usuario = partes[0];
                string contraseña = partes[1];

                // 2. Hashear la cadena completa (usuario-contraseña)
                string hash = ConvertirHash.GenerateSHA256Hash(usuario, contraseña);

                // 3. Buscar en la base de datos
                Usuarios usuarios = new Usuarios();
                if (!usuarios.VerificarUsuario(usuario))
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
                                usuarios.ReiniciarIntentos(usuario);
                            }
                        }
                    }
                    if (UsuarioSesion.ObtenerContraseña() != hash)
                    {
                        usuarios.RestarIntentos(UsuarioSesion.ObtenerNombreUsuario());
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
                    usuarios.ReiniciarIntentos(usuario);
                    usuarios.ActualizarFechaUltimoLogin(UsuarioSesion.ObtenerNombreUsuario());
                }
                return (true, "Inicio de sesión exitoso", UsuarioSesion.ObtenerNombreUsuario());
            }
        }
    }
}
