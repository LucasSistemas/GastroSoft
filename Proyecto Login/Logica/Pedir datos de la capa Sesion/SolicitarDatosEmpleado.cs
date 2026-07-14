using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sesion;

namespace Logica.Pedir_datos_de_la_capa_Sesion
{
    public class SolicitarDatosEmpleado
    {
        public string SolicitarNombre()
        {
            return EmpleadoSesion.ObtenerNombre();
        }
        public string SolicitarApellido()
        {
            return EmpleadoSesion.ObtenerApellido();
        }
    }
}
