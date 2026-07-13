using Entidad;
using Sesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosPoliticasSeguridad : Conexion
    {
        // Método para leer la configuración mediante el SP (stored prosedure)
        public PoliticasSeguridadContraseña ObtenerPoliticas()
        {
            PoliticasSeguridadContraseña politicas = new PoliticasSeguridadContraseña();

            using (SqlConnection conexion = new SqlConnection(AccesoCadena()))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerConfiguracionSeguridad", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            politicas.LongitudMinima = Convert.ToInt32(reader["Longitud"]);
                            politicas.RequiereMayusculas = Convert.ToBoolean(reader["Mayusculas"]);
                            politicas.RequiereNumeros = Convert.ToBoolean(reader["Numeros"]);
                            politicas.RequiereEspeciales = Convert.ToBoolean(reader["CaracteresEspeciales"]);
                            politicas.NoRepetirContraseñas = Convert.ToBoolean(reader["NoRepiteContraseña"]);
                            politicas.CantidadPreguntasRequeridas = Convert.ToInt32(reader["CantidadPreguntas"]);
                            politicas.ValidarDatosPersonales = Convert.ToBoolean(reader["ValidarDatosPersonales"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la capa Datos al obtener las políticas: " + ex.Message);
                }
            }

            return politicas;
        }

        // Método para guardar la configuración mediante el SP (stored prosedure)
        public bool GuardarPoliticas(PoliticasSeguridadContraseña politicas)
        {
            using (SqlConnection conexion = new SqlConnection(AccesoCadena()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ModificarConfiguracionSeguridad", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Longitud", politicas.LongitudMinima);
                    cmd.Parameters.AddWithValue("@Mayusculas", politicas.RequiereMayusculas);
                    cmd.Parameters.AddWithValue("@Numeros", politicas.RequiereNumeros);
                    cmd.Parameters.AddWithValue("@CaracteresEspeciales", politicas.RequiereEspeciales);
                    cmd.Parameters.AddWithValue("@NoRepiteContraseña", politicas.NoRepetirContraseñas);
                    cmd.Parameters.AddWithValue("@CantidadPreguntas", politicas.CantidadPreguntasRequeridas);
                    cmd.Parameters.AddWithValue("@ValidarDatosPersonales", politicas.ValidarDatosPersonales);

                    try
                    {
                        conexion.Open();

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        return filasAfectadas > 0;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }
        // Método para guardar las respuestas de las preguntas de seguridad mediante el SP (stored prosedure)
        public bool GuardarRespuesta(int idUsuario, int idPregunta, string respuesta)
        {
            using (SqlConnection conn = new SqlConnection(AccesoCadena()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GuardarRespuestaUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@IdPregunta", idPregunta);
                    cmd.Parameters.AddWithValue("@Respuesta", respuesta.Trim());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        UsuarioSesion.SetPrimeraVez(false);
                        return true;
                    }
                    catch (SqlException)
                    {
                        return false;
                    }
                }
            }
        }
    }
}