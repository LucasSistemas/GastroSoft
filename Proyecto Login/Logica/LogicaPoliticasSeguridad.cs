using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class LogicaPoliticasSeguridad
    {
        // Aca intanciamos la clase "DatosPoliticasSeguridad" de la capa de datos para poder comunicarnos con la Base de Datos 
        private DatosPoliticasSeguridad _datosPoliticas = new DatosPoliticasSeguridad();

        // Método para leer las políticas de seguridad desde la base de datos.       
        public PoliticasSeguridadEntidad LeerPoliticas()
        {
            // Este seria como el puente directo hacia la capa de Datos y tener a mano dic hos datos de las politicas de contraseñas
            return _datosPoliticas.ObtenerPoliticas();
        }

        // Método para modificar las políticas. Aquí aplicamos reglas de negocio antes de guardar

        public bool ModificarPoliticas(PoliticasSeguridadEntidad nuevasPoliticas)
        {
            ///pero tambien funciona como un metodo de seguridad para no romper la base de datos,
            ///en caso de que por alguna razon el administrador ingrese mal las politicas de las contraseñas y ponga
            ///que las contraseñas pueden ser de -5 caracteres y se rompa todo, por eso se hace una pequeña validacion para asegurar que todo este en orden con este valor.
            ///tambien se podrian agregar otras validaciones super basicas pero con la longitud minima de la contraseña va.
            if (nuevasPoliticas.LongitudMinima < 4)
            {

                return false;
            }

            // Si todo esta en orden y no se rompe nada se deveria dar luz verde para llevar todo a la capa de Datos para que impacten los cambios en la base de datos
            return _datosPoliticas.GuardarPoliticas(nuevasPoliticas);
        }
    }
}