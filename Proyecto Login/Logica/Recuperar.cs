using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Recuperar
    {
        public bool RecuperarContrasena(string strRecuperar)
        {
            if (PassRandom(strRecuperar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PassRandom(string correo)
        {
            ArmarMail.armarMail.DireccionCorreo = correo;
            ArmarMail.armarMail.Asunto = "Recuperar";

            string contrasenaaleatoria = ContrasenaAleatoria.GenerarContrasena();
            ArmarMail.armarMail.NuevaContraseña = contrasenaaleatoria;


            return ArmarMail.armarMail.Preparar();
        }
    }
}
