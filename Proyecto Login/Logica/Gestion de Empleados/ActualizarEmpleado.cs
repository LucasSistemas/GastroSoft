using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Sesion;

namespace Logica.Gestion_de_Empleados
{
    public class ActualizarEmpleado
    {
        private Empleado capaDatosEmpleado = new Empleado();

        public bool ModificarEmpleado(int idEmpleado, string nombre, string apellido, string documento, string sexo,
            string genero, string fecha_nac, string telefono, string mail, string calle, string numero,
            string piso, string departamento, int codigopostal, int idlocalidad, string nombreLocalidad)
        {
            bool exito = capaDatosEmpleado.ActualizarEmpleado(idEmpleado, nombre, apellido, documento, sexo, genero,
                                                fecha_nac, telefono, mail, calle, numero, piso,
                                                departamento, codigopostal, idlocalidad);
            if (exito)
            {
                EmpleadoSesion.Nombre = nombre;
                EmpleadoSesion.Apellido = apellido;
                EmpleadoSesion.Documento = documento;
                EmpleadoSesion.Sexo = sexo;
                EmpleadoSesion.Genero = genero;
                EmpleadoSesion.Fecha_Nac = Convert.ToDateTime(fecha_nac);
                EmpleadoSesion.Telefono = telefono;
                EmpleadoSesion.Mail = mail;
                EmpleadoSesion.Calle = calle;
                EmpleadoSesion.Numero = numero;
                EmpleadoSesion.Piso = piso;
                EmpleadoSesion.Departamento = departamento;
                EmpleadoSesion.CodigoPostal = codigopostal;
                EmpleadoSesion.Localidad = nombreLocalidad;
            }
            return exito;
        }
    }
}
