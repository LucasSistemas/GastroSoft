using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Sesion;
using Entidad;
using System.Net;

namespace Datos
{
    public class Usuarios : Conexion
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public bool VerificarUsuario(string usuario)
        {
            using (conn = new SqlConnection(AccesoCadena()))
            {
                conn.Open();
                using (cmd = new SqlCommand("sp_Iniciar_Sesion", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Usuario", usuario);

                        //conn.Open();

                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // ✅ Carga manual de datos

                                UsuarioSesion.SetIdUsuario(Convert.ToInt32(reader["IdUsuario"]));
                                UsuarioSesion.SetNombreUsuario(reader["NombreUsuario"].ToString());
                                UsuarioSesion.SetRol(reader["Rol"].ToString());
                                UsuarioSesion.SetContraseña(reader["HashContraseña"].ToString());
                                UsuarioSesion.SetPrimeraVez(Convert.ToBoolean(reader["PrimeraVez"]));
                                UsuarioSesion.SetIntentosSesion(Convert.ToInt32(reader["Intentos_Sesion"]));
                                
                                // Fecha puede ser NULL
                                if (!reader.IsDBNull(reader.GetOrdinal("TiempoResetIntentos")))
                                {
                                    UsuarioSesion.SetTiempoResetIntentos(Convert.ToDateTime(reader["TiempoResetIntentos"]));
                                }
                                else
                                {
                                    UsuarioSesion.SetTiempoResetIntentos(null);
                                }

                                // Fecha puede ser NULL
                                if (!reader.IsDBNull(reader.GetOrdinal("Fecha_Ultimo_Login")))
                                {
                                    UsuarioSesion.SetFechaUltimoLogin(Convert.ToDateTime(reader["Fecha_Ultimo_Login"]));
                                }
                                else
                                {
                                    UsuarioSesion.SetFechaUltimoLogin(null);
                                }

                                UsuarioSesion.SetBloqueado(Convert.ToBoolean(reader["Bloqueado"]));

                                //Fecha puede ser NULL
                                if (!reader.IsDBNull(reader.GetOrdinal("BloqueadoHasta")))
                                {
                                    UsuarioSesion.SetBloqueadoHasta(Convert.ToDateTime(reader["BloqueadoHasta"]));
                                }
                                else
                                {
                                    UsuarioSesion.SetBloqueadoHasta(null);
                                }

                                //Fecha puede ser NULL
                                if (!reader.IsDBNull(reader.GetOrdinal("TiempoResetIntentos")))
                                {
                                    UsuarioSesion.SetTiempoResetIntentos(Convert.ToDateTime(reader["TiempoResetIntentos"]));
                                }
                                else
                                {
                                    UsuarioSesion.SetTiempoResetIntentos(null);
                                }
                            }
                            return true;
                        }
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }
        public void ActualizarFechaUltimoLogin(string usuario)
        {
            using (conn = new SqlConnection(AccesoCadena()))
            {
                using (cmd = new SqlCommand("sp_Actualizar_FechaUltimoLogin", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Usuario", usuario);

                        conn.Open();

                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }
        public void RestarIntentos(string usuario)
        {
            using (conn = new SqlConnection(AccesoCadena()))
            {
                using (cmd = new SqlCommand("sp_RestarIntentos", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        conn.Open();
                        var intentos = cmd.ExecuteScalar();
                        UsuarioSesion.SetIntentosSesion(Convert.ToInt32(intentos));

                        if (UsuarioSesion.ObtenerIntentosSesion() <= 0)
                        {
                            BloquearUsuario(usuario);
                        }
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }
        public void ReiniciarIntentos(string usuario)
        {
            using (conn = new SqlConnection(AccesoCadena()))
            {
                using (cmd = new SqlCommand("sp_ReiniciarIntentos", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Usuario", usuario);

                        conn.Open();

                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }
        public void BloquearUsuario(string usuario)
        {
            using (conn = new SqlConnection(AccesoCadena()))
            {
                using (cmd = new SqlCommand("sp_BloquearUsuario", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        conn.Open();

                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UsuarioSesion.SetBloqueado(Convert.ToBoolean(reader["Bloqueado"]));
                            }
                        }
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }

    }
}
