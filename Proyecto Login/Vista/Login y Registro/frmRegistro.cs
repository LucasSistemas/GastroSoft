using Logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using System.Runtime.Remoting.Messaging;

namespace Vista
{
    public partial class frmRegistro : Form
    {
        #region LISTAS Y VALIABLES
            //Listas para cargar los combobox 

            private List<Nacionalidades> listanac = new List<Nacionalidades> { };
            private List<Provincias> listaprov = new List<Provincias> { };
            private List<Partidos> listapart = new List<Partidos> { };
            private List<Localidades> listaloc = new List<Localidades> { };

            //Variebles e instancias de Utilidad
            CargarFormularios cargar = new CargarFormularios();
            Registrar logica = new Registrar();
            int idNacionalidad;
            int idProvincia;
            int idPartido;
            private frmMenuPrincipalParaAdm menu;
        #endregion
        /*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        */
        public frmRegistro(frmMenuPrincipalParaAdm menu)
        {
            InitializeComponent();
            this.menu = menu;
            CargarTodasLasListas();
        }

        private void CargarTodasLasListas()
        {
            //Se cargan todas las listas
            listanac = cargar.CargarNacionalidades();
            listaprov = cargar.CargarProvincias();
            listapart = cargar.CargarPartidos();
            listaloc = cargar.CargarLocalidades();

            CargarNacionalidades();
            LimpiarSiguientes();
        }

        #region FILTROS
        //SE REALIZAN LOS FILTROS
        private void cbNacionalidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //1.Se verifica q la opcion elegida sea de index mas de 1
            if (cbNacionalidad.SelectedIndex < 0) return;
            LimpiarSiguientes();

            //2.Se guarda en una variable la index de la opcion elegida del combobox
            idNacionalidad = (int)cbNacionalidad.SelectedValue;

            //3. Se crea un objeto tipo var que actua como lista para cargar los filtros con la opcion elegida en el combobox
            var provinciasFiltradas = listaprov.Where(p => p.IdNacionalidad == idNacionalidad).OrderBy(p => p.Provincia).ToList();

            CargarProvincias(provinciasFiltradas);

            LimpiarPartidoLocalidad();
            cbProvincia.SelectedIndex = -1;
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1.Se verifica q la opcion elegida sea de index mas de 1
            if (cbProvincia.SelectedIndex < 0) return;

            //2. Se asegura de que la opcion sea valida
            if (cbProvincia.SelectedValue == null || cbProvincia.SelectedValue.ToString() == "0" || (int)cbProvincia.SelectedValue == 0) return;

            //3.Se guarda en una variable la index de la opcion elegida del combobox
            idProvincia = (int)cbProvincia.SelectedValue;

            //4. Se crea un objeto tipo var que actua como lista para cargar los filtros con la opcion elegida en el combobox
            var partidosFiltrados = listapart.Where(p => p.IdProvincia == idProvincia).OrderBy(p => p.Partido).ToList();

            CargarPartidos(partidosFiltrados);
            LimpiarLocalidad();
        }

        private void cbPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1.Se verifica q la opcion elegida sea de index mas de 1
            if (cbPartido.SelectedIndex < 0) return;

            //2. Se asegura de que la opcion sea valida
            if (cbPartido.SelectedValue == null || cbPartido.SelectedValue.ToString() == "0" || (int)cbPartido.SelectedValue == 0) return;

            //3.Se guarda en una variable la index de la opcion elegida del combobox
            idPartido = (int)cbPartido.SelectedValue;

            //4. Se crea un objeto tipo var que actua como lista para cargar los filtros con la opcion elegida en el combobox
            var localidadesFiltradas = listaloc.Where(l => l.IdPartido == idPartido).OrderBy(l => l.Localidad).ToList();

            CargarLocalidades(localidadesFiltradas);
        }
        #endregion

        /*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        */
        #region CARGAR COMBOBOX
        //SE CARGAN LOS COMBOBOX
        private void CargarNacionalidades()
        {
            cbNacionalidad.DataSource = null;
            cbNacionalidad.DisplayMember = "Nacionalidad";
            cbNacionalidad.ValueMember = "IdNacionalidad";
            cbNacionalidad.DataSource = listanac;
            cbNacionalidad.SelectedIndex = -1;
        }

        private void CargarProvincias(List<Provincias> lista)
        {
            cbProvincia.DataSource = null;
            cbProvincia.DisplayMember = "Provincia";
            cbProvincia.ValueMember = "IdProvincia";
            cbProvincia.DataSource = lista;
            cbProvincia.SelectedIndex = -1;
        }

        private void CargarPartidos(List<Partidos> lista)
        {
            cbPartido.DataSource = null;
            cbPartido.DisplayMember = "Partido";
            cbPartido.ValueMember = "IdPartido";
            cbPartido.DataSource = lista;
            cbPartido.SelectedIndex = -1;
        }

        private void CargarLocalidades(List<Localidades> lista)
        {
            cbLocalidad.DataSource = null;
            cbLocalidad.DisplayMember = "Localidad";
            cbLocalidad.ValueMember = "IdLocalidad";
            cbLocalidad.DataSource = lista;
            cbLocalidad.SelectedIndex = -1;
        }
        #endregion
        /*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        */
        #region LIMPIAR TODOS LOS CAMPOS
        //SE LIMPIAN LOS COMBOBOX
        private void LimpiarSiguientes()
        {
            cbProvincia.DataSource = null;
            cbProvincia.Items.Clear();
            cbProvincia.Items.Add("-- Seleccione --");
            cbPartido.DataSource = null;
            cbPartido.Items.Clear();
            cbPartido.Items.Add("-- Seleccione --");
            cbLocalidad.DataSource = null;
            cbLocalidad.Items.Clear();
            cbLocalidad.Items.Add("-- Seleccione --");
        }

        private void LimpiarPartidoLocalidad()
        {
            cbPartido.DataSource = null;
            cbPartido.Items.Clear();
            cbPartido.Items.Add("-- Seleccione --");
            cbLocalidad.DataSource = null;
            cbLocalidad.Items.Clear();
            cbLocalidad.Items.Add("-- Seleccione --");
        }

        private void LimpiarLocalidad()
        {
            cbLocalidad.DataSource = null;
            cbLocalidad.Items.Clear();
            cbLocalidad.Items.Add("-- Seleccione --");
        }

        private void btnLimpiarTodo_Click_1(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            cbSexo.Items.Clear();
            txtGenero.Clear();
            txtFechaNac.Clear();
            txtTelefono.Clear();
            txtMail.Clear();
            txtCalle.Clear();
            txtNumero.Clear();
            txtPiso.Clear();
            txtDepartamento.Clear();
            LimpiarSiguientes();
        }
        #endregion
        /*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        */
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }
        private void Volver()
        {
            this.Dispose();
            this.Close();
            menu.Show();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; //impide caracteres
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; //impide caracteres
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //impide ingresar mas de 8 digitos
            if (txtDocumento.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //impide caracteres
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //impide caracteres
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //impide caracteres
            }
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //impide caracteres
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES DE LOS CAMPOS
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) //para que el nombre no este vacio
            {
                MessageBox.Show("Debe ingresar un nombre. ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text)) //para que el apellido no este vacio
            {
                MessageBox.Show("Debe ingresar un apellido. ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                txtApellido.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDocumento.Text)) //para que el doc no este vacio
            {
                MessageBox.Show("Debe ingresar un documento. ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                txtDocumento.Focus();
                return;
            }

            if (txtDocumento.Text.Length < 7 || txtDocumento.Text.Length > 8) //para la longitud del dni
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 digitos.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtDocumento.Focus();
                return;
            }

            if (cbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un sexo.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cbSexo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGenero.Text))
            {
                MessageBox.Show("Debe ingresar un genero", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtGenero.Focus();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtFechaNac.Text))
            {
                MessageBox.Show("Debe ingresar una fecha de nacimiento.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtFechaNac.Focus();
                return;
            }

            DateTime fechaNacimiento;

            if (!DateTime.TryParse(txtFechaNac.Text, out fechaNacimiento))
            {
                MessageBox.Show("Debe ingresar una fecha valida.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtFechaNac.Focus();
                return;
            }

            int edad = DateTime.Today.Year - fechaNacimiento.Year; //para calcular la edad

            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }

            if (edad < 18)
            {
                MessageBox.Show("Debe ser mayor de 18 años.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtFechaNac.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Debe ingresar un telefono.");
                txtTelefono.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("Debe ingresar un correo electronico.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtMail.Focus();
                return;
            }

            if (!txtMail.Text.Contains("@") || !txtMail.Text.Contains("."))
            {
                MessageBox.Show("Debe ingresar un correo valido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtMail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCalle.Text))
            {
                MessageBox.Show("Debe ingresar una calle.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCalle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Debe ingresar un numero de domicilio.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtNumero.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCodigoPostal.Text))
            {
                MessageBox.Show("Debe ingresar un codigo postal", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtGenero.Focus();
                return;
            }

            if (cbNacionalidad.SelectedIndex == -1) {
                MessageBox.Show("Debe seleccionar una nacionalidad.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbNacionalidad.Focus();
                return;
            }

            if (cbProvincia.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una provincia.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbProvincia.Focus();
                return;
            }

            if (cbPartido.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una partido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbPartido.Focus();
                return;
            }

            if (cbLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una localidad.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLocalidad.Focus();
                return;
            }
            #endregion
            /*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////              
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            */

            var resultado = logica.RegistrarEmpleado(txtNombre.Text, txtApellido.Text, txtFechaNac.Text, txtDocumento.Text, cbSexo.Text, txtGenero.Text, txtTelefono.Text,
                txtMail.Text, txtCalle.Text, txtNumero.Text, txtPiso.Text, txtDepartamento.Text, Convert.ToInt32(txtCodigoPostal.Text), cbLocalidad.SelectedIndex);

            if (resultado.Exito)
            {
                MessageBox.Show(resultado.Mensaje, "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Volver();
            }
            else
            {
                MessageBox.Show(resultado.Mensaje, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
