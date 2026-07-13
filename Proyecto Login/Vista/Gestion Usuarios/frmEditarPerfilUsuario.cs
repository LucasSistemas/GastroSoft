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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class frmEditarPerfilUsuario : Form
    {

        frmMenuPrincipal menuPrincipal;
        SolicitarDatos logica;
        Logica.Gestion_de_Empleados.ActualizarEmpleado logicaEmpleado;

        public frmEditarPerfilUsuario(frmMenuPrincipal menu)
        {
            InitializeComponent();
            this.menuPrincipal = menu;
            logica = new SolicitarDatos();
            logicaEmpleado = new Logica.Gestion_de_Empleados.ActualizarEmpleado();
        }
        private void frmEditarPerfilUsuario_Load(object sender, EventArgs e)
        {
            tbEmpleado.Text = logica.SolicitarNombre();
            tbRol.Text = logica.SolicitarRol();
            tbUsuario.Text = logica.SolicitarUsuario();

            txtNombre.Text = EmpleadoSesion.Nombre;
            txtApellido.Text = EmpleadoSesion.Apellido;
            txtDocumento.Text = EmpleadoSesion.Documento;
            cbSexo.SelectedItem = EmpleadoSesion.Sexo;
            txtGenero.Text = EmpleadoSesion.Genero;
            dtpFechaNac.Value = EmpleadoSesion.Fecha_Nac;
            txtTelefono.Text = EmpleadoSesion.Telefono;
            txtMail.Text = EmpleadoSesion.Mail;
            txtCalle.Text = EmpleadoSesion.Calle;
            txtNumero.Text = EmpleadoSesion.Numero;
            txtPiso.Text = EmpleadoSesion.Piso;
            txtDepartamento.Text = EmpleadoSesion.Departamento;
            txtCodigoPostal.Text = EmpleadoSesion.CodigoPostal.ToString();
            cbLocalidad.SelectedItem = EmpleadoSesion.Localidad;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }
        private void Volver()
        {
            this.Dispose();
            this.Close();
            menuPrincipal.Show();
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


            if (string.IsNullOrWhiteSpace(dtpFechaNac.Text))
            {
                MessageBox.Show("Debe ingresar una fecha de nacimiento.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpFechaNac.Focus();
                return;
            }

            DateTime fechaNacimiento;

            if (!DateTime.TryParse(dtpFechaNac.Text, out fechaNacimiento))
            {
                MessageBox.Show("Debe ingresar una fecha valida.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpFechaNac.Focus();
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

                dtpFechaNac.Focus();
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

                txtCodigoPostal.Focus();
                return;
            }

            if (cbNacionalidad.SelectedIndex == -1)
            {
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

            int idLocalidadSeleccionada = Convert.ToInt32(cbLocalidad.SelectedValue);
            string fechaNacString = dtpFechaNac.Value.ToString("yyyy-MM-dd");

            bool exito = logicaEmpleado.ModificarEmpleado(
                EmpleadoSesion.Id,
                txtNombre.Text,
                txtApellido.Text,
                txtDocumento.Text,
                cbSexo.Text,
                txtGenero.Text,
                fechaNacString,
                txtTelefono.Text,
                txtMail.Text,
                txtCalle.Text,
                txtNumero.Text,
                txtPiso.Text,
                txtDepartamento.Text,
                Convert.ToInt32(txtCodigoPostal.Text),
                idLocalidadSeleccionada,
                cbLocalidad.Text
            );

            // 3. Validamos el resultado booleano
            if (exito)
            {
                MessageBox.Show("Perfil actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Volver();
            }
            else
            {
                MessageBox.Show("Hubo un error al intentar actualizar el perfil en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //si son correctas se actualiza los datos
            MessageBox.Show("Perfil actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void btCambiarRespuestas_Click(object sender, EventArgs e)
        {
            Vista.Gestion_Usuarios.frmCambiarRespuestas frmRespuestas = new Vista.Gestion_Usuarios.frmCambiarRespuestas(this, EmpleadoSesion.Id);
            frmRespuestas.Show();
            this.Hide();
        }

        private void btAtras_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            menuPrincipal.Show(); // Muestra el menú principal que pasaste en el constructor
        }
    }
}
