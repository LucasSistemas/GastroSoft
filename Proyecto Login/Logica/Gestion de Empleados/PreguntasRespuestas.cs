using Datos.Consultas_Tablas;
using Datos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Gestion_de_Empleados
{
    public class PreguntasRespuestas
    {
        private PreguntasSeguridad dal = new PreguntasSeguridad();

        public List<RespuestaSeguridadDTO> ObtenerRespuestasUsuario(int idUsuario)
        {
            if (idUsuario <= 0) throw new ArgumentException("El ID de usuario no es válido.");
            return dal.ObtenerRespuestas(idUsuario);
        }

        public bool GuardarCambiosRespuestas(int idUsuario, List<RespuestaSeguridadDTO> respuestasNuevas)
        {
            foreach (var item in respuestasNuevas)
            {
                if (string.IsNullOrWhiteSpace(item.Respuesta))
                {
                    throw new Exception("Todas las respuestas de seguridad deben ser completadas.");
                }
            }

            bool exito = true;
            foreach (var item in respuestasNuevas)
            {
                bool modificado = dal.ActualizarRespuesta(idUsuario, item.IdPregunta, item.Respuesta);
                if (!modificado) exito = false;
            }

            return exito;
        }
    }
}
