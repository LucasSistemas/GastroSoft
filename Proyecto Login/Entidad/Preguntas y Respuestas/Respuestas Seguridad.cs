using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Preguntas_y_Respuestas
{
    public class Respuestas_Seguridad
    {
        public int IdRespuestaSeguridad {  get; set; }
        public int IdPregunta {  get; set; }
        public int IdUsuario {  get; set; }
        public string RespuestaHash {  get; set; }
    }
}
