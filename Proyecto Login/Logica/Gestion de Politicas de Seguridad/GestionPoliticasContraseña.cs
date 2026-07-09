using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class GestionPoliticasContraseña
    {
        // Aca intanciamos la clase "DatosPoliticasSeguridad" de la capa de datos para poder comunicarnos con la Base de Datos 
        private DatosPoliticasSeguridad _datosPoliticas = new DatosPoliticasSeguridad();

        // Método para leer las políticas de seguridad desde la base de datos.       
        public PoliticasSeguridadContraseña LeerPoliticas()
        {
            // Este seria como el puente directo hacia la capa de Datos y tener a mano dichos datos de las politicas de contraseñas
            return _datosPoliticas.ObtenerPoliticas();
        }

        // Método para modificar las políticas. Aquí aplicamos reglas de negocio antes de guardar
        public bool ModificarPoliticas(PoliticasSeguridadContraseña nuevasPoliticas)
        {
            // Si todo esta en orden y no se rompe nada se deveria dar luz verde para llevar todo a la capa de Datos para que impacten los cambios en la base de datos
            return _datosPoliticas.GuardarPoliticas(nuevasPoliticas);
        }
    }
}