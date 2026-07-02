using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sesion;

namespace Vista
{
    public partial class frmNuevaContraseña : Form
    {
        private frmMenuPrincipalParaAdm menu;

        public frmNuevaContraseña(frmMenuPrincipalParaAdm menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            menu.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // 1. Esto lo que hace es guardar el contenio de los textbox de la nueva contraseña en dos variable para poder compararlas y ver si ambos campos contiene exactamente la misma contraseña.
            string nuevaContraseña = txtNuevaContraseña.Text;
            string repetirNuevaContraseña = txtRepetirNuevaContraseña.Text;

            // 2. Antes de validar si ambo textbox son iguales, primero aca se verifica si los textbox estan vacios o no, en el caso de que el usuario sea tonto y no escriba nada pues se le muestra una alerta.
            if (string.IsNullOrWhiteSpace(nuevaContraseña) || string.IsNullOrWhiteSpace(repetirNuevaContraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos de contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Aca es donde se valida si ambas contraseñas escritas por el usuario son iguales o no, en el caso de que no lo sean se muestra una alerta al usuario.
            if (nuevaContraseña != repetirNuevaContraseña)
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden. Verifique el campo de repetición.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // =======================================================================================================
            // AHORA SE LEEN LAS POLÍTICAS DE LA CAPA "SESIÓN" Y SE APLICAN PARA VALIDAR EL FORMATO DE LAS CONTRASEÑAS
            // =======================================================================================================

            // 4. Aca se valida la longitud de la contraseña configurada anterioremente en la pantalla "frmConfiguracionDeSeguridadDelSistema"
            int longitudMinimaRequerida = UsuarioSesion.Politicas_De_Contraseñas.LongitudMinima;
            if (nuevaContraseña.Length < longitudMinimaRequerida)
            {
                MessageBox.Show($"La contraseña debe tener una longitud mínima de {longitudMinimaRequerida} caracteres.", "Política de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Aca se valida si contiene mayusculas o no dependiendo de lo que se haya configurado en la pantalla "frmConfiguracionDeSeguridadDelSistema"
            if (UsuarioSesion.Politicas_De_Contraseñas.RequiereMayusculas && !nuevaContraseña.Any(char.IsUpper))
            {
                MessageBox.Show("La contraseña debe contener al menos una letra mayúscula.", "Política de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 6. Aca valida si la contraseña contiene numeros o no (Minimo va a pedir 1 digito) dependiendo si se solicita o no segun la configuracion puesta en la pantalla "frmConfiguracionDeSeguridadDelSistema"
            if (UsuarioSesion.Politicas_De_Contraseñas.RequiereNumeros && !nuevaContraseña.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe contener al menos un número.", "Política de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 7. Aca se valida si la contraseña contiene "Caracteres Especiales" o no (ej: @, #, $, -, _, etc.) depeundiendo de la configuracion puesta en la pantalla "frmConfiguracionDeSeguridadDelSistema"
            if (UsuarioSesion.Politicas_De_Contraseñas.RequiereEspeciales && !nuevaContraseña.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("La contraseña debe contener al menos un carácter especial (ej: @, #, $, %, etc.).", "Política de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 8. Aca se valida que la contraseña nueva no sea igual a alguna otra contraseña vieja puesta por el usuario en anteriores cambios de contraseña
            // ¡¡ ACLARACION !! ESTA VALIDACION POR AHORA ES SOLO A NIVEL LOGICO AL IGUAL QUE LAS ANTERIORES VALIDACIONES YA QUE PARA VALIDAD LAS CONTRASEÑAS ANTIGUAS DEL USUSARIO ES NECESARIO QUE ESTAS ESTEN GUARDADAS EN LA BASE DE DATOS Y QUE ESTAS SEAN VERIFICADAS DE DE ALLÌ... AUN ESTOY TRABAJANDO EN ESO.
            if (UsuarioSesion.Politicas_De_Contraseñas.NoRepetirContraseñas)
            {
                string contrasenaActual = UsuarioSesion.ObtenerContraseña();
                if (nuevaContraseña == contrasenaActual)
                {
                    MessageBox.Show("La nueva contraseña no puede ser igual a la contraseña actual.", "Política de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // =====================================================================================================================================================================
            // SI LLEGÓ EL SISTEMA LLEGO HASTA ACÁ, ES PORQUE PASÓ TODAS LAS RESTRICCIONES CON ÉXITO Y SE PUEDE SEGUIR CON EL GUARDADO DE LA NUEVA CONTRASEÑA HACIA LA BASE DE DATOS
            // =====================================================================================================================================================================

            // 9. Guardamos temporalmente en la sesión para simular el cambio exitoso antes de ir a la Base de Datos
            UsuarioSesion.SetContraseña(nuevaContraseña);

            MessageBox.Show("¡Contraseña actualizada con éxito en GastroSoft!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Cerramos la pantalla actual
        }
    }
}
