using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    class EnviarMail
    {
        public static bool enviarmail(string to, string asunto, string body)
        {
            string from = "lukytasperez@gmail.com"; //correo de la empresa
            string displayName = "Recuperacion de Cuenta"; //Lo que se ve al recibir el mail
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from, displayName)
                };

                mail.To.Add(to);
                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(from, "fqudmrgqnmejudzt"),
                    EnableSsl = true
                };
                client.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
