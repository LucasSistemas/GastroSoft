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
    public partial class frmMenuPrincipalParaAdm : Form
    {
        private string nombreUsuario;
        CerrarSesion cerrarSesion = new Logica.CerrarSesion();
        frmLogin frmlogin;
        frmEditarPerfilUsuario frmEditarPerfilUsuario;
        frmNuevaContraseña frmNuevaContraseña;
        frmRegistro frmRegistro;
        frmAltaEmpleadosRegistrados frmAltaEmpleadosRegistrados;

        public frmMenuPrincipalParaAdm(frmLogin login, string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.frmlogin = login;
        }

        private void frmMenuPrincipalParaAdm_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "¡Bienvenido, " + nombreUsuario + "!";
        }

        private void btnSesion_Click(object sender, EventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarPerfilUsuario = new frmEditarPerfilUsuario(this);
            frmEditarPerfilUsuario.Show();

            this.Hide();
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            frmNuevaContraseña = new frmNuevaContraseña(this);
            frmNuevaContraseña.Show();
            this.Hide();
        }

        private void btnEmpleadoCrear_Click(object sender, EventArgs e)
        {
            frmRegistro = new frmRegistro(this);
            frmRegistro.Show();
            this.Hide();
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            frmAltaEmpleadosRegistrados = new frmAltaEmpleadosRegistrados(this);
            frmAltaEmpleadosRegistrados.Show();
            this.Hide();
        }
    }
}
