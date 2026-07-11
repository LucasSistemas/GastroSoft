using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using Sesion; // Conexión directa a la sesión de GastroSoft

namespace Logica
{
    public class DatosPersonalesContraseña
    {
        private DatosPoliticasSeguridad _datosPoliticas = new DatosPoliticasSeguridad();

        // Valida si la contraseña contiene datos personales del empleado en sesión
        // La clave en texto plano a validar retorna True si es segura, False si contiene datos personales
        public bool ValidarNoDatosPersonales(string contraseñaPlana)
        {
            // Aca se lee la configuración de políticas desde la Base de Datos
            PoliticasSeguridadContraseña politicas = _datosPoliticas.ObtenerPoliticas();

            // Si no hay políticas o el checkbox está desmarcado, pasa directo sin validar
            if (politicas == null || !politicas.ValidarDatosPersonales)
            {
                return true;
            }

            // Aca se traen los datos personales del usuario (Nombre, Apellido y Documento) usando los métodos de la clase "EmpleadoSesion"
            string clave = contraseñaPlana.ToLower().Trim();
            string nombre = EmpleadoSesion.ObtenerNombre().ToLower().Trim();
            string apellido = EmpleadoSesion.ObtenerApellido().ToLower().Trim();
            string documento = EmpleadoSesion.ObtenerDocumento().ToLower().Trim();

            // Si la contraseña contiene el nombre, apellido o el documento del empleado pues rebota
            if (clave.Contains(nombre) || clave.Contains(apellido) || clave.Contains(documento))
            {
                return false;
            }

            return true; // pero si la contraseña esta limpia pues devuelve un true
        }
    }
}