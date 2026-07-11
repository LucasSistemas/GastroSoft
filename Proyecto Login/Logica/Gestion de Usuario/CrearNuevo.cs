using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Sesion;

namespace Logica.Gestion_de_Usuario
{
    public class CrearNuevoUsuario
    {
        public (bool Exito,string Mensaje) CrearUsuario(string usuario, string hashcontraseña)
        {
            Usuario usuariodatos = new Usuario();
            if(usuariodatos.ComprobarExistenciaUsuario(usuario)== true)
            {
                return (false,"El usuario ya existe");
            }
            string documento = EmpleadoSesion.ObtenerDocumento();
            if (!usuariodatos.CrearNuevoUsuario(usuario, hashcontraseña, documento))
            {
                return (false,"No se pudo crear el usuario");
            }
            else
            {
                return (true, "Usuario creado exitosamente! Inicie sesión y continúe con el proceso");
            }
        }
    }
}
