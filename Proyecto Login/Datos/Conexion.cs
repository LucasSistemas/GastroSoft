using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public abstract class  Conexion
    {
        //private string cadena = "data source=(local);database=ProyectoLogin;integrated security=true";
        private string cadena = "data source=localhost;database=ProyectoLogin;integrated security=true";

        public SqlConnection conexion;

        public string AccesoCadena()
        {
            return cadena;
            
        }
    }
}