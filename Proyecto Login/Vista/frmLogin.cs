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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (txtContrasena.Text.Contains("-"))
                {
                    IniciarSesion iniciarSesion = new IniciarSesion();
                    var resultado = iniciarSesion.Iniciar(txtContrasena.Text);

                    if (resultado.Exito)
                    {
                        MessageBox.Show(resultado.Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMenuPrincipalParaAdm menu = new frmMenuPrincipalParaAdm(this,resultado.NombreUsuario);
                        menu.Show();
                        txtContrasena.Clear();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(resultado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtContrasena.Clear();
                        txtContrasena.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Formato incorrecto. Use: usuario-contraseña. Inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Clear();
                    txtContrasena.Focus();
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            txtContrasena.UseSystemPasswordChar = true; 

            checkContra.Checked = false;

        }

        private void checkContra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkContra.Checked)
            {

                txtContrasena.UseSystemPasswordChar = false;

            }
            else
            {
                txtContrasena.UseSystemPasswordChar= true;
            }
               
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro que desea salir?", "Iniciar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.No)
            {
                e.Cancel = false;
            }
        }
    }
}
