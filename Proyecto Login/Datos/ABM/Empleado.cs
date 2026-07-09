using Sesion;
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
    public class Empleado : Conexion
    {
        public bool CargarNuevoEmpleado(string nombre, string apellido, string documento, string sexo,
            string genero, string fecha_nac, string telefono, string mail, string calle, string numero,
            string piso, string departamento, int codigopostal, int idlocalidad)
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

        public bool CargarCodigoAcceso(string codigo, string documento)
        {
            using (SqlConnection conn = new SqlConnection(AccesoCadena()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_CargarCodigoAcceso", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Documento", documento);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        return false;
                    }
                }
            }
        }
        public (bool Exito, string Mensaje) ValidaryDarAltaEmpleado(string codigo)
        {
            using (SqlConnection conn = new SqlConnection(AccesoCadena()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ValidaryDarAltaEmpleado", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    SqlParameter mensajeparametro = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 200);
                    mensajeparametro.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(mensajeparametro);

                    SqlParameter documentoparametro = new SqlParameter("@Documento", SqlDbType.NVarChar, 50);
                    documentoparametro.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(documentoparametro);


                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        string mensaje = cmd.Parameters["@Mensaje"].Value?.ToString();
                        string documento = cmd.Parameters["@Documento"].Value?.ToString();
                        CargarEmpleadoSesion(documento);

                        return (!string.IsNullOrEmpty(documento), mensaje);
                    }
                    catch (SqlException ex) 
                    { 
                        return (false, null);
                    }
                }
            }
        }
        public void CargarEmpleadoSesion(string documento)
        {
            using (SqlConnection conn = new SqlConnection(AccesoCadena()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_CargarEmpleadoSesion", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Documento", documento);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                EmpleadoSesion.SetNombre(reader["Nombre"].ToString());
                                EmpleadoSesion.SetApellido(reader["Apellido"].ToString());
                                EmpleadoSesion.SetDocumento(reader["Documento"].ToString());
                                EmpleadoSesion.SetSexo(reader["Sexo"].ToString());
                                EmpleadoSesion.SetGenero(reader["Genero"].ToString());
                                EmpleadoSesion.SetFecha_Nac(Convert.ToDateTime(reader["Fecha_Nac"]));
                                EmpleadoSesion.SetTelefono(reader["Telefono"].ToString());
                                EmpleadoSesion.SetMail(reader["Mail"].ToString());
                                EmpleadoSesion.SetCalle(reader["Calle"].ToString());
                                EmpleadoSesion.SetNumero(reader["Numero"].ToString());
                                EmpleadoSesion.SetPiso(reader["Piso"].ToString());
                                EmpleadoSesion.SetDepartamento(reader["Departamento"].ToString());
                                EmpleadoSesion.SetCodigoPostal(Convert.ToInt32(reader["CodigoPostal"]));
                                EmpleadoSesion.SetLocalidad(reader["Localidad"].ToString());
                                // Aquí puedes almacenar estos datos en variables de sesión o en un objeto de usuario según tu implementación.
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Manejar la excepción según sea necesario
                    }
                }
            }
        }
    }
}
