using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class BitacoraDatos : Conexion
    {
        SqlConnection conn; //para conectar con la bd
        SqlCommand cmd;

        public void Registrar(Bitacora bitacora)
        {
            using (conn = new SqlConnection(AccesoCadena()))
            {
                using (cmd = new SqlCommand("sp_RegistrarBitacora", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure; //indica que es un procedimiento almacenado

                        cmd.Parameters.AddWithValue("@NombreUsuario", bitacora.NombreUsuario);
                        cmd.Parameters.AddWithValue("@Accion", bitacora.Accion);
                        cmd.Parameters.AddWithValue("@Descripcion", bitacora.Descripcion);
                        cmd.Parameters.AddWithValue("@Tipo", bitacora.Tipo);
                        cmd.Parameters.AddWithValue("@Nivel", bitacora.Nivel);

                        conn.Open(); //se abre conexion

                        cmd.ExecuteNonQuery();//ejecuta el procedimiento
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al registrar la bitacora: " + ex.Message);
                    }
                }
            }
        }

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();

            using (conn = new SqlConnection(AccesoCadena()))
            {
                using (cmd = new SqlCommand("sp_MostrarBitacora", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    adapter.Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable Filtrar(DateTime fechaDesde,DateTime fechaHasta,string nombreusuario,string tipo, string accion, string nivel)
        {
            DataTable tabla = new DataTable();

            using (conn = new SqlConnection(AccesoCadena()))
            {
                using (cmd = new SqlCommand("sp_FiltrarBitacora", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);
                    cmd.Parameters.AddWithValue("@NombreUsuario", (object)nombreusuario ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Tipo", string.IsNullOrEmpty(tipo) ? (object)DBNull.Value : tipo);
                    cmd.Parameters.AddWithValue("@Accion", string.IsNullOrEmpty(accion) ? (object)DBNull.Value : accion);
                    cmd.Parameters.AddWithValue("@Nivel", string.IsNullOrEmpty(nivel) ? (object)DBNull.Value : nivel);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    adapter.Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable MostrarAcciones()
        {
            DataTable tabla = new DataTable();

            using (conn = new SqlConnection(AccesoCadena()))
            {
                using (cmd = new SqlCommand("sp_MostrarAccionesBitacora", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    adapter.Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();

            using (conn = new SqlConnection(AccesoCadena()))
            {
                using (cmd = new SqlCommand("sp_MostrarUsuariosBitacora", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    adapter.Fill(tabla);
                }
            }
            return tabla;
        }
    }
 }
