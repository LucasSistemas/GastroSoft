using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Empleados : Conexion
    {
        public bool CargarNuevoEmpleado(string nombre, string apellido, string documento, string sexo, 
            string genero, string fecha_nac, string telefono, string mail, string calle, string numero, 
            string piso, string departamento,int codigopostal, int idlocalidad)
        {
            //int idEmpleado = 0;
            using (SqlConnection conn = new SqlConnection(AccesoCadena()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Registro_Empleado", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Documento", documento);
                    cmd.Parameters.AddWithValue("Sexo", sexo);
                    cmd.Parameters.AddWithValue("@Genero", genero);
                    cmd.Parameters.AddWithValue("@Fecha_Nac", fecha_nac);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Mail", mail);
                    cmd.Parameters.AddWithValue("@Calle", calle);
                    cmd.Parameters.AddWithValue("@Numero", numero);
                    cmd.Parameters.AddWithValue("@Piso", piso);
                    cmd.Parameters.AddWithValue("@Departamento", departamento);
                    cmd.Parameters.AddWithValue("@CodigoPostal", codigopostal);
                    cmd.Parameters.AddWithValue("@IdLocalidad", idlocalidad);

                    SqlParameter paramId = cmd.Parameters.Add("@IdEmpleado", SqlDbType.Int);
                    paramId.Direction = ParameterDirection.Output;

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void DarAltaEmpleado()
        {

        }
    }
}
