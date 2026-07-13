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
        public bool CrearUsuario(string usuario, string hashcontraseña)
        {
            Usuario usuariodatos = new Usuario();
            string documento = EmpleadoSesion.ObtenerDocumento();
            if (!usuariodatos.CrearNuevoUsuario(usuario, hashcontraseña, documento))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
