using Entidad.Empleados_y_Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Consultas_Tablas;

namespace Logica.Cargar_datos_a_Formularios.Empleados_a_Dar_Alta
{
    public class CargarEmpleadosPendientes
    {
        public List<Empleados> CargarEmpleados()
        {
            List<Empleados> listaemleadosespera = new List<Empleados>();
            TablaEmpleados tabla = new TablaEmpleados();
            listaemleadosespera = tabla.ObtenerEmpleadosenEspera();
            return listaemleadosespera;
        }
    }
}
