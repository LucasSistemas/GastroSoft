using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class PoliticasSeguridadContraseña
    {
        public int LongitudMinima { get; set; }
        public bool RequiereMayusculas { get; set; }
        public bool RequiereNumeros { get; set; }
        public bool RequiereEspeciales { get; set; }
        public bool NoRepetirContraseñas { get; set; }
        public int CantidadPreguntasRequeridas { get; set; }
    }
}