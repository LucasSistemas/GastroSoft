using Datos;
using Datos.Consultas_Tablas;
using Entidad;
using Entidad.Preguntas_y_Respuestas;
using Servicios;
using Sesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Gestion_de_Usuario
{
    public class GestionRespuestasSeguridad
    {
        private PoliticasSeguridad _datosPoliticas = new PoliticasSeguridad();
        private Usuario datosusuario = new Usuario();


        // Registra la respuesta del usuario a una pregunta de seguridad en la base de datos

        public bool RegistrarRespuestaUsuario(List<Respuestas_Seguridad> registroRespuestas)
        {
            foreach (var item in registroRespuestas)
            {
                // Convertimos la respuesta a un hash para almacenarla de forma segura
                string hashRespuesta = ConvertirHash.GenerateSHA256Hash(item.RespuestaHash);


                bool resultado = datosusuario.RegistrarRespuesta(UsuarioSesion.ObtenerIdUsuario(), item.IdPregunta, item.RespuestaHash);
                if (resultado == false)
                {
                    return false;
                }
            }
            return true;
        }

        public bool ActualizarCambiosRespuestas(List<Respuestas_Seguridad> respuestasNuevas)
        {
            foreach (var item in respuestasNuevas)
            {
                string hashRespuesta = ConvertirHash.GenerateSHA256Hash(item.RespuestaHash);

                bool resultado = datosusuario.ActualizarRespuesta(UsuarioSesion.ObtenerIdUsuario(), item.IdPregunta, item.RespuestaHash);
                if(resultado == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
