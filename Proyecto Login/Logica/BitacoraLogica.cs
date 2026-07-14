using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class BitacoraLogica
    {
        BitacoraDatos datos = new BitacoraDatos();

        public void Registrar(Bitacora bitacora)
        {
            datos.Registrar(bitacora);
        }

        public DataTable Mostrar()
        {
            return datos.Mostrar();
        }

        public DataTable Filtrar(DateTime fechaDesde,DateTime fechaHasta,string nombreusuario,string tipo,string accion,string nivel)
        {
            return datos.Filtrar(fechaDesde,fechaHasta,nombreusuario,tipo,accion,nivel);
        }

        public DataTable MostrarAcciones()
        {
            return datos.MostrarAcciones();
        }

        public DataTable MostrarUsuarios()
        {
            return datos.MostrarUsuarios();
        }
    }
}
