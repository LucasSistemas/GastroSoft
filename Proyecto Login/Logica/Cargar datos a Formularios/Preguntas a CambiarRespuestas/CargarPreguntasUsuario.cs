using Entidad.Preguntas_y_Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Cargar_datos_a_Formularios.Preguntas_a_CambiarRespuestas
{
    public class CargarPreguntasUsuario
    {
        private CargarPreguntasSeguridad cargarPreguntas;
        public (bool Exito, string Mensaje, List<Preguntas_Seguridad> Preguntas) CargarPreguntas()
        {
            try
            {
                cargarPreguntas = new CargarPreguntasSeguridad();

                List<Preguntas_Seguridad> listaPreguntas = cargarPreguntas.SolicitarPreguntasUsuario();

                if (listaPreguntas != null && listaPreguntas.Count > 0)
                {
                    return (true, null, listaPreguntas);
                }

                return (false, "No se encontraron preguntas.", null);
            }
            catch (Exception)
            {
                return (false, "Ocurrió un error al cargar las preguntas.", null);
            }
        }
    }
}
