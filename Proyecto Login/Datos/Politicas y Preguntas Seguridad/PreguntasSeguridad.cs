using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.Preguntas_y_Respuestas;

namespace Datos.Consultas_Tablas
{
    public class PreguntasSeguridad : Conexion
    {
        // Obtiene las preguntas y respuestas actuales del usuario
        public List<Preguntas_Seguridad> ObtenerPreguntasUsuario(int idusuario)
        {
            List<Preguntas_Seguridad> lista = new List<Preguntas_Seguridad>();

            using (conexion = new SqlConnection(AccesoCadena()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerPreguntasUsuario", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", idusuario);


                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Preguntas_Seguridad
                            {
                                IdPregunta = Convert.ToInt32(dr["IdPregunta"]),
                                Pregunta = dr["Pregunta"].ToString(),
                            });
                        }
                    }
                }
            }
            return lista;
        }
        public List<Preguntas_Seguridad> ObtenerPreguntasAleatorias()
        {
            List<Preguntas_Seguridad> lista = new List<Preguntas_Seguridad>();

            using ( SqlConnection conn = new SqlConnection(AccesoCadena()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerPreguntasAleatorias", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Preguntas_Seguridad
                                {
                                    IdPregunta = Convert.ToInt32(reader["IdPregunta"]),
                                    Pregunta = reader["Pregunta"].ToString()
                                });
                            }
                        }
                    }
                    catch (SqlException)
                    {
                        /* Error al conectar con la base de datos */
                    }
                }
            }
            return lista;
        }
    }
}
