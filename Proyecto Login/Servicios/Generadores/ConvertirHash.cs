using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ConvertirHash
    {
        public static string GenerateSHA256Hash(string usuarioh, string contrasenah)
        {
            string hash = $"{usuarioh}-{contrasenah}";
            /*
            ✅ Crea instancia del algoritmo SHA256
            ✅ "using" libera memoria automáticamente
            ✅ SHA256 produce SIEMPRE 32 bytes (256 bits) de salida
            */
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(hash);
                byte[] bytehash = sha256.ComputeHash(bytes);
                /*
                sha256.ComputeHash():

                Entrada:  [106, 117, 97, 110, 58, 77, 105...] (15 bytes)
                ➜ Hash: [94, 232, 72, 152, 218, 40, 71...](32 bytes FIJOS)
                Resultado: 94 e8 48 98 da 28 04 71 51 d0 e5 6f 8d c6 29 27 73 60 3d 0d 6a ab bd d6 2a 11 ef 72 1d 15 42 d8
                */

            return BytesToHex(bytehash).ToLowerInvariant();
            }
        }

        static string BytesToHex(byte[] bytes)
        {
            return string.Concat(bytes.Select(b => b.ToString("x2")));
            /*
            bytes = [94, 232, 72, 152, 218, 40...]

            1.b.ToString("x2") convierte cada byte a 2 dígitos hex:
               94 → "5e"
               232 → "e8"
               72 → "48"
               152 → "98"...

            2.Select() crea array: ["5e", "e8", "48", "98", ...]

            3. string.Concat() une: "5ee84898da280471..."

            4.ToLowerInvariant(): "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8"
            */
        }
    }
}




