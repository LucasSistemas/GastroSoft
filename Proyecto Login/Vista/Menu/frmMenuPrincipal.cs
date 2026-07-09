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
    public partial class frmMenuPrincipal : Form
    {
        private string nombreUsuario;
        CerrarSesion cerrarSesion = new Logica.CerrarSesion();
        frmLogin frmlogin;
        frmEditarPerfilUsuario frmEditarPerfilUsuario;
        frmRegistro frmRegistro;
        frmAltaEmpleadosRegistrados frmAltaEmpleadosRegistrados;
        frmPoliticasContraseña frmPoliticasContraseña;

        public frmMenuPrincipal(frmLogin login, string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.frmlogin = login;
        }

        private void frmMenuPrincipalParaAdm_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "¡Bienvenido, " + nombreUsuario + "!";
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarPerfilUsuario = new frmEditarPerfilUsuario(this);
            frmEditarPerfilUsuario.Show();

            this.Hide();
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                cerrarSesion.Cerrar();
                frmlogin.Show();
                this.Dispose();
                this.Close();
            }
        }

        private void btnEmpleadoCrear_Click_1(object sender, EventArgs e)
        {
            frmRegistro = new frmRegistro(this);
            frmRegistro.Show();
            this.Hide();
        }

        private void btnAltaEmpleados_Click(object sender, EventArgs e)
        {
            frmAltaEmpleadosRegistrados = new frmAltaEmpleadosRegistrados(this);
            frmAltaEmpleadosRegistrados.Show();
            this.Hide();
        }

        private void btnPoliticasContraseña_Click(object sender, EventArgs e)
        {
            frmPoliticasContraseña = new frmPoliticasContraseña(this);
            frmPoliticasContraseña.Show();
            this.Hide();
        }
    }
}
