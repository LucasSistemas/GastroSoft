using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Logica
{
    //clase para ser llamada por el formulario "PreguntasDeSeguridad" y esta sirve para rellenar el formularios con las preguntas aleatorias
    public class GestionPreguntas
    {
        private DatosPreguntas _datosPreguntas = new DatosPreguntas();

        public List<PreguntaSeguridad> CargarPreguntasPantalla()
        {
            return _datosPreguntas.ObtenerPreguntasAleatorias();
        }

    }
}