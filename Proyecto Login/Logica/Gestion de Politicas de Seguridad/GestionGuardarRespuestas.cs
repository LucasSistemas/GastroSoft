using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Servicios;
using Sesion;

namespace Logica
{
    public class GestionGuardarRespuestas
    {
        private DatosPoliticasSeguridad _datosPoliticas = new DatosPoliticasSeguridad();


        // Registra la respuesta del usuario a una pregunta de seguridad en la base de datos

        public bool RegistrarRespuestaUsuario(int idPregunta, string respuesta)
        {
            // Convertimos la respuesta a un hash para almacenarla de forma segura
            string hashRespuesta = ConvertirHash.GenerateSHA256Hash(respuesta);
            // Y usamos el metodo "DatosPoliticasSeguridad" de la capa DATOS
            return _datosPoliticas.GuardarRespuesta(UsuarioSesion.ObtenerIdUsuario(), idPregunta, hashRespuesta);
        }
    }
}