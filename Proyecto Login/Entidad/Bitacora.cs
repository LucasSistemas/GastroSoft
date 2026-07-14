using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Bitacora
    {
        public int IdBitacora { get; set; }//para guardar el identificador unico del registro

        public DateTime FechaHora { get; set; } //para la fecha y hora en que paso

        public string NombreUsuario { get; set; } // nombre del usuario 

        public string Accion { get; set; } //tipo de accion

        public string Descripcion { get; set; } // descripcion detallada

        public string Tipo { get; set; } // ej: login, seguridad, stock

        public string Nivel { get; set; } // info, advertencia, critico
    }
}
