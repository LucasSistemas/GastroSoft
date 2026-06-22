using Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Formularios : Conexion
    {
        public List<Localidades> ObtenerLocalidades()
        {
            string query = "select * from Localidades";
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(AccesoCadena()))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.Fill(dt);

                List<Localidades> listalocalidad = new List<Localidades>();

                foreach (DataRow fila in dt.Rows)
                {
                    listalocalidad.Add(new Localidades
                    {
                        IdLocalidad = Convert.ToInt32(fila["IdLocalidad"]),
                        Localidad = fila["Localidad"].ToString(),
                        IdPartido = Convert.ToInt32(fila["IdPartido"])
                    });
                }
                return listalocalidad;
            }
        }
        public List<Partidos> ObtenerPartidos()
        {
            string query = "select * from Partidos";
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(AccesoCadena()))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);

                List<Partidos> listapartido = new List<Partidos>();

                foreach (DataRow fila in dt.Rows)
                {
                    listapartido.Add(new Partidos
                    {
                        IdPartido = Convert.ToInt32(fila["IdPartido"]),
                        Partido = fila["Partido"].ToString(),
                        IdProvincia = Convert.ToInt32(fila["IdProvincia"])
                    });
                }
                return listapartido;
            }
        }

        public List<Provincias> ObtenerProvincias()
        {
            string query = "select * from Provincias";
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(AccesoCadena()))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);

                List<Provincias> listaprovincia = new List<Provincias>();

                foreach (DataRow fila in dt.Rows)
                {
                    listaprovincia.Add(new Provincias
                    {
                        IdProvincia = Convert.ToInt32(fila["IdProvincia"]),
                        Provincia = fila["Provincia"].ToString(),
                        IdNacionalidad = Convert.ToInt32(fila["IdNacionalidad"])
                    });
                }
                return listaprovincia;
            }
        }
        public List<Nacionalidades> ObtenerNacionalidades()
        {
            string query = "select * from Nacionalidades";
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(AccesoCadena()))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);

                List<Nacionalidades> listanacionalidades = new List<Nacionalidades>();

                foreach (DataRow fila in dt.Rows)
                {
                    listanacionalidades.Add(new Nacionalidades
                    {
                        IdNacionalidad = Convert.ToInt32(fila["IdNacionalidad"]),
                        Nacionalidad = fila["Nacionalidad"].ToString()
                    });
                }
                return listanacionalidades;
            }
        }
    }
}
