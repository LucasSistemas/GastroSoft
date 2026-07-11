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
        frmPreguntasDeSeguridad frmPreguntasDeSeguridad;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            if (txtContrasena.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Este if es para iniciar sesion con usuario y contraseña
                if (txtContrasena.Text.Contains("-"))
                {
                    var resultado = iniciarSesion.Iniciar(txtContrasena.Text);

                    if (resultado.Exito)
                    { 
                        if (resultado.Mensaje == "Complete el formulario de seguridad para continuar")
                        {
                            MessageBox.Show(resultado.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmPreguntasDeSeguridad = new frmPreguntasDeSeguridad(this);
                            frmPreguntasDeSeguridad.Show();
                            txtContrasena.Clear();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(resultado.Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmMenuPrincipal menu = new frmMenuPrincipal(this, resultado.Nombre);
                            menu.Show();
                            txtContrasena.Clear();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show(resultado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtContrasena.Clear();
                        txtContrasena.Focus();
                    }
                }
                // Este else if es para iniciar sesion con contraseña enviada al correo de 6 digitos
                else if (txtContrasena.Text.Length == 6)
                {
                    var resultado = iniciarSesion.Iniciar(txtContrasena.Text);
                    if (resultado.Exito)
                    {
                        MessageBox.Show(resultado.Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmCrearUsuario frmCrearUsuario = new frmCrearUsuario(this,resultado.Nombre);
                        frmCrearUsuario.Show();
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
