using Logica;
using Sesion;
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
    public partial class frmBitacora : Form
    {
        BitacoraLogica logica = new BitacoraLogica();

        private frmMenuPrincipal menu;
        public frmBitacora (frmMenuPrincipal menuPrincipal)
        {
            InitializeComponent();

            menu = menuPrincipal;
        }
     
        private void frmBitacora_Load(object sender, EventArgs e)
        {  
            dgvBitacora.DataSource = logica.Mostrar();

            cbTipo.Items.Add("LOGIN");
            cbTipo.Items.Add("SEGURIDAD");
            cbTipo.Items.Add("USUARIO");
            cbTipo.Items.Add("STOCK");

            cbNivel.Items.Add("INFO");
            cbNivel.Items.Add("ADVERTENCIA");
            cbNivel.Items.Add("CRITICO");

            cbAccion.DataSource = logica.MostrarAcciones();
            cbAccion.DisplayMember = "Accion";
            cbAccion.ValueMember = "Accion";
            cbAccion.SelectedIndex = -1;

            cbUsuario.DataSource = logica.MostrarUsuarios();
            cbUsuario.DisplayMember = "NombreUsuario";
            cbUsuario.ValueMember = "IdUsuario";
            cbUsuario.SelectedIndex = -1;

            dgvBitacora.ReadOnly = true; // Que no se pueda editar
            dgvBitacora.AllowUserToAddRows = false; // No pueda agregar filas
            dgvBitacora.AllowUserToDeleteRows = false; //No pueda eliminar filas
            dgvBitacora.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvBitacora.MultiSelect = false;
            dgvBitacora.ClearSelection();

            dgvBitacora.AllowUserToResizeRows = false; // No modificar tamaño de filas
            dgvBitacora.AllowUserToResizeColumns = false; // No modificar tamaño de columnas

            dgvBitacora.SelectionMode = DataGridViewSelectionMode.CellSelect; // Selecciona toda la fila
            dgvBitacora.MultiSelect = false; // Solo una fila

            dgvBitacora.RowHeadersVisible = false; // Sacar el margen
        }

        private void btnBuscarB_Click(object sender, EventArgs e)
        {
            string tipo = cbTipo.SelectedItem?.ToString();
            string accion = cbAccion.SelectedValue?.ToString();
            string nivel = cbNivel.SelectedItem?.ToString();

            string usuario = null;
            
            if(cbUsuario.Text != null)
            {
                usuario = cbUsuario.Text;
            }

            dgvBitacora.DataSource = logica.Filtrar(dtpDesde.Value,dtpHasta.Value,usuario,tipo,accion,nivel);
        }

        private void btnLimpiarB_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;

            cbUsuario.SelectedIndex = -1;
            cbTipo.SelectedIndex = -1;
            cbAccion.SelectedIndex = -1;
            cbNivel.SelectedIndex = -1;

            dgvBitacora.DataSource = logica.Mostrar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void dgvBitacora_SelectionChanged(object sender, EventArgs e)
        {
            dgvBitacora.ClearSelection();
        }
    }
}
