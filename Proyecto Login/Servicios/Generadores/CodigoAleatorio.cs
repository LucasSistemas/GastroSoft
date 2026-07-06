using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class CodigoAleatorio
    {
        public static string GenerarCodigo(int cantidadcaracteres)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] resultado = new char[8];

            for (int i = 0; i < cantidadcaracteres; i++)
            {
                resultado[i] = chars[random.Next(chars.Length)];
            }

            return new string(resultado);
        }
    }
}
