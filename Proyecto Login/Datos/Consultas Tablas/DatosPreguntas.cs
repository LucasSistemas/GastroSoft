using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class DatosPreguntas : Conexion
    {
        public List<PreguntaSeguridad> ObtenerPreguntasAleatorias()
        {
            List<PreguntaSeguridad> lista = new List<PreguntaSeguridad>();

            using (SqlConnection conn = new SqlConnection(AccesoCadena()))
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
                                lista.Add(new PreguntaSeguridad
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