using Entidad;
using Entidad.Empleados_y_Usuarios;
using Logica;
using Logica.Cargar_datos_a_Formularios.Empleados_a_Dar_Alta;
using Logica.Gestion_de_Empleados;
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
    public partial class frmAltaEmpleadosRegistrados : Form
    {
        private BitacoraServicio bitacora = new BitacoraServicio();
        private frmMenuPrincipal menu;
        private CargarEmpleadosPendientes logica = new CargarEmpleadosPendientes();

        public frmAltaEmpleadosRegistrados(frmMenuPrincipal menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            menu.Show();
        }

        private void frmAltaEmpleadosRegistrados_Load(object sender, EventArgs e)
        {
            List<Empleados> listaempleadosespera = new List<Empleados>();

            listaempleadosespera = logica.CargarEmpleados();

            dgvAltaEmpleado.DataSource = null; // Reseteo el dgv
            dgvAltaEmpleado.DataSource = listaempleadosespera; // Cargo el dgv

            dgvAltaEmpleado.ReadOnly = true; // Que no se pueda editar
            dgvAltaEmpleado.AllowUserToAddRows = false; // No pueda agregar filas
            dgvAltaEmpleado.AllowUserToDeleteRows = false; //No pueda eliminar filas

            dgvAltaEmpleado.AllowUserToResizeRows = false; // No modificar tamaño de filas
            dgvAltaEmpleado.AllowUserToResizeColumns = false; // No modificar tamaño de columnas

            dgvAltaEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila
            dgvAltaEmpleado.MultiSelect = false; // Solo una fila

            dgvAltaEmpleado.RowHeadersVisible = false; // Sacar el margen
        }

        private void btDarAlta_Click(object sender, EventArgs e)
        {
            if (dgvAltaEmpleado.SelectedRows.Count > 0) // Toma datos
            {
                DataGridViewRow fila = dgvAltaEmpleado.SelectedRows[0];

                string documento = (string)fila.Cells["Documento"].Value;
                string correo = (string)fila.Cells["Mail"].Value;

                GestionDeEmpleados logica = new GestionDeEmpleados();
                var resultado = logica.DarAlta(documento, correo);
                if (!resultado.Exito)
                {
                    MessageBox.Show(resultado.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bitacora.Registrar("Alta de empleado","Se genero el codigo de acceso y se envio al empleado correctamente. ","USUARIO","INFO");

                    MessageBox.Show(resultado.mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAltaEmpleadosRegistrados_Load(sender, e); // Recargo el dgv
                }
            }
        }
    }
}
