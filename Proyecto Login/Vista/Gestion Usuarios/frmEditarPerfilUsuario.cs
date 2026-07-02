using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class frmEditarPerfilUsuario : Form
    {
        frmMenuPrincipalParaAdm menuPrincipalParaAdm;
        SolicitarDatos logica;
        public frmEditarPerfilUsuario(frmMenuPrincipalParaAdm menu)
        {
            InitializeComponent();
            this.menuPrincipalParaAdm = menu;
            logica = new SolicitarDatos();
        }
        private void frmEditarPerfilUsuario_Load(object sender, EventArgs e)
        {
            lblEmpleado.Text = "Empleado: " + logica.SolicitarNombre();
            lblRol.Text = "Rol: " + logica.SolicitarRol();
            lblUsuario.Text = "Usuario: " + logica.SolicitarUsuario();

        }
        #region Eventos para validar campos
        private void tbNombre_R_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo letras

            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbApellido_R_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo letras

            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbTelefono_R_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo numeros

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Guardar Cambios
        private void btGuardar_Cambios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre_R.Text))
            {
                MessageBox.Show("Debe ingresar un nombre.");
                tbNombre_R.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbApellido_R.Text))
            {
                MessageBox.Show("Debe ingresar un apellido.");
                tbApellido_R.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbEmail_R.Text))
            {
                MessageBox.Show("Debe ingresar un email");
                tbEmail_R.Focus();
                return;
            }
            //formato basico de mail
            if (!tbEmail_R.Text.Contains("@")|| !tbEmail_R.Text.Contains("."))
            {
                MessageBox.Show("Debe ingresar un email valido.");
                tbEmail_R.Focus();
                return;
            }
            //para que el telefono no este vacio

            if (string.IsNullOrWhiteSpace (tbTelefono_R.Text))
            {
                MessageBox.Show("Debe ingresar un telefono.");
                tbTelefono_R.Focus();
                return;
            }

            if (tbTelefono_R.Text.Length < 8)
            {
                MessageBox.Show("Debe ingresar un telefono valido.");

                tbTelefono_R.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbRespuesta_1.Text))
            {
                MessageBox.Show("Debe responder la pregunta 1.");

                tbRespuesta_1.Focus();
                return;
                
            }

            if (string.IsNullOrWhiteSpace(tbRespuesta_2.Text))
            {
                MessageBox.Show("Debe responder la pregunta 2.");

                tbRespuesta_2.Focus();
                return;
                
            }

            if (string.IsNullOrWhiteSpace(tbRespuesta_3.Text))
            {
                MessageBox.Show("Debe responder la pregunta 3.");

                tbRespuesta_3.Focus();
                return;
                
            }

            if (string.IsNullOrWhiteSpace(tbRespuesta_4.Text))
            {
                MessageBox.Show("Debe responder la pregunta 4.");

                tbRespuesta_4.Focus();
                return;
                
            }

            if (string.IsNullOrWhiteSpace(tbRespuesta_5.Text))
            {
                MessageBox.Show("Debe responder la pregunta 5.");

                tbRespuesta_5.Focus();
                return;
                
            }
            //si son correctas se actualiza los datos
            MessageBox.Show("Perfil actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menuPrincipalParaAdm.Show();
            this.Dispose();
            this.Close();
        }
    }
}
