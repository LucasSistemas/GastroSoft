using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ArmarMail
    {
        public static class armarMail
        {
            public static string DireccionCorreo { get; set; }
            public  static string Asunto { get; set; }
            public  static string NuevaContraseña { get; set; }

            public static bool Preparar()
            {
                string body = @"<style>
                                h1{color:dodgerblue;}
                                h2{color:darkorange;}
                               </style>
                                <h1> Contraseña de ingreso: </h1></br>
                                <h2> " + NuevaContraseña + "</h2>";

                return EnviarMail.enviarmail(DireccionCorreo, Asunto, body);
            }
        }
    }
}
