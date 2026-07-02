using Datos;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Registrar
    {
        public (bool Exito,string Mensaje) RegistrarEmpleado(string nombre, string apellido, string fechaNacimiento, string documento, string sexo, string genero, string telefono, string mail, string calle, string numero, string piso, string departamento,int codigopostal, int idlocalidad)
        {
            Empleados emp = new Empleados();
            if (!emp.CargarNuevoEmpleado(nombre, apellido, documento, sexo, genero, fechaNacimiento, telefono, mail, calle, numero, piso, departamento,codigopostal, idlocalidad))
            {
                return (false,"No se pudo registrar al empleado");
            }
            else
            {
                return (true, "Empleado registrado correctamente");
            }
        }
    }
}
