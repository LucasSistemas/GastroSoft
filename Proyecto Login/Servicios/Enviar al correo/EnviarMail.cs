using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Servicios
{
    class EnviarMail
    {
        private static string host = ConfigurationManager.AppSettings["SmtpHost"];
        private static int port = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
        private static string email = ConfigurationManager.AppSettings["SmtpEmail"];
        private static string password = ConfigurationManager.AppSettings["SmtpPassword"];
        public static bool enviarmail(string correo, string asunto, string body,string titulo)
        {
            string from = email; //correo de la empresa
            string displayName = titulo; //Lo que se ve al recibir el mail
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from, displayName)
                };

                mail.To.Add(correo);
                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient(host,port)
                {
                    Credentials = new NetworkCredential(email,password),
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
