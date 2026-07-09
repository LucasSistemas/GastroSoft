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
using Logica.Gestion_de_Usuario;


namespace Vista
{
    public partial class frmCrearUsuario : Form
    {
        private string nombreapellidoempleado;
        private ValidarContraseña validarContraseña;
        frmLogin login = new frmLogin();
        CerrarSesion cerrarSesion = new Logica.CerrarSesion();

        public frmCrearUsuario(frmLogin login,string nomape)
        {
            InitializeComponent();
            nombreapellidoempleado = nomape;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // 1. Aca guardamos el contenido de los textbox en variables
            string nuevousuario = txtNuevoUsuario.Text;
            string nuevaContraseña = txtNuevaContraseña.Text;
            string repetirNuevaContraseña = txtRepetirNuevaContraseña.Text;

            validarContraseña = new ValidarContraseña();
            
            // 2. Verificamos si los textbox están vacíos
            if (string.IsNullOrWhiteSpace(nuevaContraseña) || string.IsNullOrWhiteSpace(repetirNuevaContraseña) || string.IsNullOrWhiteSpace(nuevousuario))
            {
                MessageBox.Show("Por favor, complete todos los campos de contraseña.", "Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validamos si ambas contraseñas son iguales
            if (nuevaContraseña != repetirNuevaContraseña)
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden. Verifique el campo de repetición.", "Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Validamos la contraseña usando la clase ValidarContraseña
                var resultadoValidacion = validarContraseña.Validar(nuevaContraseña, nuevousuario);
                if (!resultadoValidacion.Exito)
                {
                    MessageBox.Show(resultadoValidacion.Mensaje, "Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    return;
                }
                else
                {
                    MessageBox.Show(resultadoValidacion.Mensaje, "Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cerrarSesion.Cerrar();
                    login.Show();
                    this.Dispose();
                    this.Close();
                }
            }
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            lblCrearUsuarioa.Text = $"Crear Usuario a : {nombreapellidoempleado}";
        }

        private void checkMostrarNuevaContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrarNuevaContraseña.Checked)
            {

                txtNuevaContraseña.UseSystemPasswordChar = false;

            }
            else
            {
                txtNuevaContraseña.UseSystemPasswordChar = true;
            }
        }
    }
}
