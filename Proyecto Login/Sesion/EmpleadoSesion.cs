using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion
{
    public static class EmpleadoSesion
    {
        public static int IdEmpleado { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Documento { get; set; }
        public static string Sexo { get; set; }
        public static string Genero { get; set; }
        public static DateTime Fecha_Nac { get; set; }
        public static string Telefono { get; set; }
        public static string Mail { get; set; }
        public static string Calle { get; set; }
        public static string Numero { get; set; }
        public static string Piso { get; set; }
        public static string Departamento { get; set; }
        public static int CodigoPostal { get; set; }
        public static string Localidad { get; set; }
        
        #region Getters
        public static int ObtenerIdEmpleado()
        {
            return IdEmpleado;
        }
        public static string ObtenerNombre()
        {
            return Nombre;
        }
        public static string ObtenerApellido()
        {
            return Apellido;
        }
        public static string ObtenerDocumento()
        {
            return Documento;
        }
        public static string ObtenerSexo()
        {
            return Sexo;
        }
        public static string ObtenerGenero()
        {
            return Genero;
        }
        public static DateTime? ObtenerFecha_Nac()
        {
            return Fecha_Nac;
        }
        public static string ObtenerTelefono()
        {
            return Telefono;
        }
        public static string ObtenerMail()
        {
            return Mail;
        }
        public static string ObtenerCalle()
        {
            return Calle;
        }
        public static string ObtenerNumero()
        {
            return Numero;
        }
        public static string ObtenerPiso()
        {
            return Piso;
        }
        public static string ObtenerDepartamento()
        {
            return Departamento;
        }
        public static int ObtenerCodigoPostal()
        {
            return CodigoPostal;
        }
        public static string ObtenerLocalidad()
        {
            return Localidad;
        }
        #endregion
        /*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        */
        #region Setters
        public static void SetIdEmpleado(int idempleado)
        {
            EmpleadoSesion.IdEmpleado = idempleado;
        }
        public static void SetNombre(string nombre)
        {
            EmpleadoSesion.Nombre = nombre;
        }
        public static void SetApellido(string apellido)
        {
            EmpleadoSesion.Apellido = apellido;
        }
        public static void SetDocumento(string documento)
        {
            EmpleadoSesion.Documento = documento;
        }
        public static void SetSexo(string sexo)
        {
            EmpleadoSesion.Sexo = sexo;
        }
        public static void SetGenero(string genero)
        {
            EmpleadoSesion.Genero = genero;
        }
        public static void SetFecha_Nac(DateTime fecha_nac)
        {
            EmpleadoSesion.Fecha_Nac = fecha_nac;
        }
        public static void SetTelefono(string telefono)
        {
            EmpleadoSesion.Telefono = telefono;
        }
        public static void SetMail(string mail)
        {
            EmpleadoSesion.Mail = mail;
        }
        public static void SetCalle(string calle)
        {
            EmpleadoSesion.Calle = calle;
        }
        public static void SetNumero(string numero)
        {
            EmpleadoSesion.Numero = numero;
        }
        public static void SetPiso(string piso)
        {
            EmpleadoSesion.Piso = piso;
        }
        public static void SetDepartamento(string departamento)
        {
            EmpleadoSesion.Departamento = departamento;
        }
        public static void SetCodigoPostal(int codigoPostal)
        {
            EmpleadoSesion.CodigoPostal = codigoPostal;
        }
        public static void SetLocalidad(string localidad)
        {
            EmpleadoSesion.Localidad = localidad;
        }
        #endregion
        /*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        */
        public static void LimpiarSesion()
        {
            Nombre = null;
            Apellido = null;
            Documento = null;
            Sexo = null;
            Genero = null;
            Fecha_Nac = default(DateTime);
            Telefono = null;
            Mail = null;
            Calle = null;
            Numero = null;
            Piso = null;
            Departamento = null;
            CodigoPostal = 0;
            Localidad = null;
        }
    }
}
