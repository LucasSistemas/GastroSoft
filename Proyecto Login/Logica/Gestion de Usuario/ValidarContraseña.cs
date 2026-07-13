using Entidad;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Gestion_de_Usuario
{
    public class ValidarContraseña
    {
        public (bool Exito,string Mensaje) Validar(string contraseña,string usuario)
        {
            GestionPoliticasContraseña logica = new GestionPoliticasContraseña();
            PoliticasSeguridadContraseña politicasActuales = logica.LeerPoliticas();

            // Aquí puedes implementar la lógica de validación de la contraseña según tus políticas de seguridad
            // Por ejemplo, verificar longitud mínima, presencia de caracteres especiales, etc.
            if (contraseña.Length < politicasActuales.LongitudMinima)
            {
                return (false, "Contraseña demasiado corta");
            }
            if (politicasActuales.RequiereMayusculas &&  !contraseña.Any(char.IsUpper))
            {
                return (false, "La contraseña debe contener al menos una letra mayúscula");
            }
            if (politicasActuales.RequiereNumeros && !contraseña.Any(char.IsDigit))
            {
                return (false, "La contraseña debe contener al menos un dígito");
            }
            if (politicasActuales.RequiereEspeciales && !contraseña.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return (false, "La contraseña debe contener al menos un carácter especial");
            }
            if (politicasActuales.NoRepetirContraseñas)
            {
                // Y ACA SE PNDRIA LA CONSULTA PARA TRAER LAS CONTRASEÑAS ANTERIIORES GUARDADAS EN LA BASE DE DATOS VERIFICAR QUE LA
                // CONTRASEÑA BNUEVA NO ES IGUAL A ALGUNA DE LAS ANTERIORES USADAS POR EL OLVIDADIZO DEL USUARIO
            }

            // Si todas las validaciones pasan, se puede proceder a crear el usuario
            string userpass = usuario + "-" + contraseña;
            string hash = ConvertirHash.GenerateSHA256Hash(userpass);

            CrearNuevoUsuario crearNuevo = new CrearNuevoUsuario();
            bool resultado = crearNuevo.CrearUsuario(usuario, hash);

            if (resultado)
            {
                return (true, "Usuario creado exitosamente! Inicie sesión y continúe con el proceso");
            }
            else
            {
                return (false, "Error al crear el usuario");
            }
        }
    }
}
