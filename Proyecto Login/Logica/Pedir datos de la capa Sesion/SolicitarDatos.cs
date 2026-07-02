using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sesion;

namespace Logica
{
    public class SolicitarDatos
    {
        public string SolicitarNombre()
        {
            return UsuarioSesion.ObtenerNombreUsuario();
        }
        public string SolicitarRol()
        {
            return UsuarioSesion.ObtenerRol();
        }
        public string SolicitarUsuario()
        {
            return UsuarioSesion.ObtenerNombreUsuario();
        }
    }
}
