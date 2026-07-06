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

            public static bool Preparar(string correo,string asunto, string mensaje)
            {
                string body = $@"
                              <!DOCTYPE html>
                               <html lang='es'>
                                <head>
                                 <meta charset='UTF-8'>
                                </head>
                                <body style='margin:0; padding:0; background-color:#f4f4f4; font-family:Arial, Helvetica, sans-serif;'>

                                    <table width='100%' cellpadding='0' cellspacing='0' style='background-color:#f4f4f4; padding:40px 0;'>
                                <tr>
                                   <td align='center'>

                                    <table width='600' cellpadding='0' cellspacing='0'
                                     style='background-color:#ffffff; border-radius:10px; padding:40px; box-shadow:0 2px 8px rgba(0,0,0,.1);'>

                                <tr>
                                    <td align='center'>
                                      <h2 style='color:#2c3e50;'>Código de Verificación</h2>

                                    <p style='font-size:16px; color:#555;'>
                                        Hola,
                                        </p>

                                <p style='font-size:16px; color:#555;'>
                                Utiliza el siguiente código para completar la verificación de tu cuenta en GastroSoft:
                                    </p>

                                    <div style='margin:30px 0;'>
                                        <span style='
                                        display:inline-block;
                                        padding:15px 35px;
                                        font-size:32px;
                                        font-weight:bold;
                                        letter-spacing:6px;
                                        color:#ffffff;
                                        background:#0078D4;
                                        border-radius:8px;'>
                                        {mensaje}
                                    </span>
                                </div>

                                <p style='font-size:14px; color:#777;'>
                                    Este código expirará en <strong>20 minutos</strong>.
                                </p>

                                <hr style='margin:30px 0; border:none; border-top:1px solid #ddd;'>

                                <p style='font-size:12px; color:#999;'>
                                    Si no solicitaste este código, puedes ignorar este correo.
                                </p>

                            </td>
                            </tr>

                        </table>

                        </td>
                        </tr>
                        </table>

                            </body>
                            </html>";

                return EnviarMail.enviarmail(correo, asunto, body,"Autenticacion de Cuenta GastroSoft");
            }
        }
    }
}
