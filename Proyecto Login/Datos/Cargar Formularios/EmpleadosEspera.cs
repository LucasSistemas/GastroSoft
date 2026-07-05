using Entidad;
using Entidad.Empleados_y_Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos.Cargar_Formularios
{
    public class EmpleadosEspera :Conexion
    {
        public List<Empleados> ObtenerEmpleadosenEspera()
        {
            string query = "select IdEmpleado,Nombre,Apellido,Documento,Sexo,Fecha_Nac,Telefono,Mail,Fecha_Registro from Empleados where Activo = 0";
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(AccesoCadena()))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.Fill(dt);

                List<Empleados> listaempleadosespera = new List<Empleados>();

                foreach (DataRow fila in dt.Rows)
                {
                    listaempleadosespera.Add(new Empleados
                    {
                        IdEmpleado = Convert.ToInt32(fila["IdEmpleado"]),
                        Nombre = fila["Nombre"].ToString(),
                        Apellido = fila["Apellido"].ToString(),
                        Documento = fila["Documento"].ToString(),
                        Sexo = fila["Sexo"].ToString(),
                        Fecha_Nac = Convert.ToDateTime(fila["Fecha_Nac"]),
                        Telefono = fila["Telefono"].ToString(),
                        Mail = fila["Mail"].ToString(),
                        Fecha_Registro = Convert.ToDateTime(fila["Fecha_Registro"])
                    });
                }
                return listaempleadosespera;
            }
        }
    }
}
