using Entidad;
using Logica;
using Logica.Pedir_datos_de_la_capa_Sesion;
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
    public partial class frmMenuPrincipal : Form
    {
        private string nombreEmpleado;
        private string nombreUsuario;
        CerrarSesion cerrarSesion = new Logica.CerrarSesion();
        frmLogin frmlogin;
        frmEditarPerfilUsuario frmEditarPerfilUsuario;
        frmRegistro frmRegistro;
        frmAltaEmpleadosRegistrados frmAltaEmpleadosRegistrados;
        frmPoliticasContraseña frmPoliticasContraseña;
        SolicitarDatosUsuario solicitarDatosUsuario = new SolicitarDatosUsuario();
        SolicitarDatosEmpleado solicitarDatosEmpleado = new SolicitarDatosEmpleado();
        BitacoraServicio bitacora = new BitacoraServicio();

        public frmMenuPrincipal(frmLogin login)
        {
            InitializeComponent();
            nombreEmpleado = solicitarDatosEmpleado.SolicitarNombre() + " " + solicitarDatosEmpleado.SolicitarApellido();
            nombreUsuario = solicitarDatosUsuario.SolicitarNombre();
            this.frmlogin = login;
        }

        private void frmMenuPrincipalParaAdm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombreEmpleado) || nombreEmpleado == " ")
            {
                lblBienvenido.Text = "¡Bienvenido, " + nombreUsuario + "!";
            }
            else
            {
                lblBienvenido.Text = "¡Bienvenido, " + nombreEmpleado + "!";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(solicitarDatosUsuario.SolicitarRol() == "AdminMaster")
            {
                MessageBox.Show("Este usuario no esta asociado con ningun empleado","Editar Perfil",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                frmEditarPerfilUsuario = new frmEditarPerfilUsuario(this);
                frmEditarPerfilUsuario.Show();

                this.Hide();
            }

        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //para que registre el cierre de sesion
                bitacora.Registrar( "Cierre de sesion","El usuario cerro sesion correctamente.","LOGIN","INFO");

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

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            frmBitacora frmbitacora = new frmBitacora(this);
            frmbitacora.Show();
            this.Hide();
        }
    }
}
