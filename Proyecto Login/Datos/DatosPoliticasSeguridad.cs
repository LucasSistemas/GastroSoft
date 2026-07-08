using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosPoliticasSeguridad
    {
        private string cadenaConexion = "aca se pone la cade conexion correcta, la mia no";

        // Método para leer la configuración mediante el SP (stored prosedure)
        public PoliticasSeguridadEntidad ObtenerPoliticas()
        {
            PoliticasSeguridadEntidad politicas = new PoliticasSeguridadEntidad();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
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
                            politicas.LongitudMinima = Convert.ToInt32(reader["LongitudMinima"]);
                            politicas.RequiereMayusculas = Convert.ToBoolean(reader["RequiereMayusculas"]);
                            politicas.RequiereNumeros = Convert.ToBoolean(reader["RequiereNumeros"]);
                            politicas.RequiereEspeciales = Convert.ToBoolean(reader["RequiereEspeciales"]);
                            politicas.NoRepetirContraseñas = Convert.ToBoolean(reader["NoRepetirContraseñas"]);
                            politicas.CantidadPreguntasRequeridas = Convert.ToInt32(reader["CantidadPreguntasRequeridas"]);
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
        public bool GuardarPoliticas(PoliticasSeguridadEntidad politicas)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("sp_ModificarConfiguracionSeguridad", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Longitud", politicas.LongitudMinima);
                cmd.Parameters.AddWithValue("@Mayus", politicas.RequiereMayusculas);
                cmd.Parameters.AddWithValue("@Num", politicas.RequiereNumeros);
                cmd.Parameters.AddWithValue("@Esp", politicas.RequiereEspeciales);
                cmd.Parameters.AddWithValue("@NoRep", politicas.NoRepetirContraseñas);
                cmd.Parameters.AddWithValue("@CantPreg", politicas.CantidadPreguntasRequeridas);

                try
                {
                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}