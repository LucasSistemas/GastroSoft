using Datos;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Gestion_de_Empleados
{
    public class GestionDeEmpleados
    {
        public (bool Exito,string mensaje) DarAlta(string documento,string correo)
        {
            string codigo = CodigoAleatorio.GenerarCodigo(6);
            Empleado empdatos = new Empleado();
            bool resultado = empdatos.CargarCodigoAcceso(codigo,documento);

            if (resultado)
            {
                try
                {
                    // Enviar correo con el código de acceso
                    string asunto = "Código de acceso para dar de alta su cuenta";
                    string mensaje = codigo;
                    ArmarMail.armarMail.Preparar(correo, asunto, mensaje);
                    return (true, "Se ha enviado un correo con el código de acceso.");
                }
                catch (Exception ex)
                {
                    return (false, "Error al enviar el correo, verifique el appconfig. o su conexion a internet");
                }
            }
            else
            {
                return (false, "No se pudo generar el código de acceso.");
            }
        }
    }
}
