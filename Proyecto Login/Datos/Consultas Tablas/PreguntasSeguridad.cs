using Datos.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Consultas_Tablas
{
    public class PreguntasSeguridad : Conexion
    {
        // Obtiene las preguntas y respuestas actuales del usuario
        public List<RespuestaSeguridadDTO> ObtenerRespuestas(int idUsuario)
        {
            List<RespuestaSeguridadDTO> lista = new List<RespuestaSeguridadDTO>();

            using (conexion = new SqlConnection(AccesoCadena()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerRespuestasSeguridad", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new RespuestaSeguridadDTO
                            {
                                IdPregunta = Convert.ToInt32(dr["IdPregunta"]),
                                Pregunta = dr["Pregunta"].ToString(),
                                Respuesta = dr["Respuesta"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public bool ActualizarRespuesta(int idUsuario, int idPregunta, string nuevaRespuesta)
        {
            using (conexion = new SqlConnection(AccesoCadena()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ActualizarRespuestaSeguridad", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@IdPregunta", idPregunta);
                    cmd.Parameters.AddWithValue("@NuevaRespuesta", nuevaRespuesta);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}
