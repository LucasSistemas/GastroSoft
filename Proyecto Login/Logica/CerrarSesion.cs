using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sesion;

namespace Logica
{
    public class CerrarSesion
    {
        public void Cerrar()
        {
            // Lógica para cerrar sesión
            UsuarioSesion.CerrarSesion();
        }
    }
}
