using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vista
{
    public partial class frmCrearUsuario : Form
    {
        private frmMenuPrincipalParaAdm menu;

        public frmCrearUsuario(frmMenuPrincipalParaAdm menu)
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
            // 1. Aca guardamos el contenido de los textbox en variables
            string nuevaContraseña = txtNuevaContraseña.Text;
            string repetirNuevaContraseña = txtRepetirNuevaContraseña.Text;

            // 2. y verificamos si los textbox están vacíos
            if (string.IsNullOrWhiteSpace(nuevaContraseña) || string.IsNullOrWhiteSpace(repetirNuevaContraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos de contraseña y no sea boludo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3.  y validamos si ambas contraseñas son iguales, para ver si el usuario es dislexico
            if (nuevaContraseña != repetirNuevaContraseña)
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden. Verifique el campo de repetición.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // =======================================================================================================
            // NUEVO: LEEMOS LAS POLÍTICAS DESDE LA BASE DE DATOS A TRAVÉS DE LA CAPA "LOGICA"
            // =======================================================================================================
            LogicaPoliticasSeguridad logica = new LogicaPoliticasSeguridad();
            PoliticasSeguridadEntidad politicasActuales = logica.LeerPoliticas();

            // 4. Validamos la longitud mínima requerida traída desde la Base de Datos
            if (nuevaContraseña.Length < politicasActuales.LongitudMinima)
            {
                MessageBox.Show($"La contraseña debe tener una longitud mínima de {politicasActuales.LongitudMinima} caracteres.", "Política de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Validamos si requiere mayúsculas según la configuración de la Base de Datos
            if (politicasActuales.RequiereMayusculas && !nuevaContraseña.Any(char.IsUpper))
            {
                MessageBox.Show("La contraseña debe contener al menos una letra mayúscula.", "Política de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 6. Validamos si requiere números según la configuración de la Base de Datos
            if (politicasActuales.RequiereNumeros && !nuevaContraseña.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe contener al menos un número.", "Política de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 7. Validamos si requiere caracteres especiales según la configuración de la Base de Datos
            if (politicasActuales.RequiereEspeciales && !nuevaContraseña.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("La contraseña debe contener al menos un carácter especial (ej: @, #, $, %, etc.).", "Política de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 8. POR COMPLETAR.......PREGUTNASR A Lu <3
            if (politicasActuales.NoRepetirContraseñas)
            {
                // Y ACA SE PNDRIA LA CONSULTA PARA TRAER LAS CONTRASEÑAS ANTERIIORES GUARDADAS EN LA BASE DE DATOS VERIFICAR QUE LA CONTRASEÑA BNUEVA NO ES IGUAL A ALGUNA DE LAS ANTERIORES USADAS POR EL OLVIDADIZO DEL USUARIO
            }

            // =========================================================================
            // SI LLEGÓ HASTA ACÁ Y NADA EXPLOTO ENTONCES PASÓ TODAS LAS RESTRICCIONES DE LA BD CON ÉXITO
            // =========================================================================

            // TODO: Aquí irá el Stored Procedure para actualizar el hash de la clave en tu tabla 'Contraseñas'

            MessageBox.Show("¡Contraseña validada y actualizada con éxito en GastroSoft!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Cerramos la pantalla actual
        }

        private void frmNuevaContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
