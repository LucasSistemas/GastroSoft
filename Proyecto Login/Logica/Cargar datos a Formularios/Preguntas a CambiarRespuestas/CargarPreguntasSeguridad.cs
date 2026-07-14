using Datos.Consultas_Tablas;
using Entidad.Preguntas_y_Respuestas;
using Sesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Cargar_datos_a_Formularios.Preguntas_a_CambiarRespuestas
{
    public class CargarPreguntasSeguridad
    {
        private PreguntasSeguridad preguntasSeguridad;
        public List<Preguntas_Seguridad> SolicitarPreguntasUsuario()
        {
            preguntasSeguridad = new PreguntasSeguridad();
            return preguntasSeguridad.ObtenerPreguntasUsuario(UsuarioSesion.ObtenerIdUsuario());
        }

        public List<Preguntas_Seguridad> SolicitarPreguntasAleatorias()
        {
            preguntasSeguridad = new PreguntasSeguridad();
            return preguntasSeguridad.ObtenerPreguntasAleatorias();
        }
    }
}
