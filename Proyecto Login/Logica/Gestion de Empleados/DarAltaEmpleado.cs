using Datos;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Gestion_de_Empleados
{
    public class DarAltaEmpleado
    {
        public void CrearCodigoParaEmpleado(string documento)
        {
            string codigo = CodigoAleatorio.GenerarCodigo(6);
            Empleado emp = new Empleado();
            emp.CargarCodigoEmpleado(codigo,documento);
        }
    }
}
