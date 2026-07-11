using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class CargarFormularios
    {
        Geografia formularios;
        public List<Localidades> CargarLocalidades()
        {
            formularios = new Geografia();
            List<Localidades> listaloc = formularios.ObtenerLocalidades();

            return listaloc;
        }
        public List<Partidos> CargarPartidos()
        {
            formularios = new Geografia();
            List<Partidos> listapart = formularios.ObtenerPartidos();
            return listapart;
        }

        public List<Provincias> CargarProvincias()
        {
            formularios = new Geografia();
            List<Provincias> listaprov = formularios.ObtenerProvincias();

            return listaprov;
        }

        public List<Nacionalidades> CargarNacionalidades()
        {
            formularios = new Geografia();
            List<Nacionalidades> listanac = formularios.ObtenerNacionalidades();

            return listanac;
        }

    }
}
