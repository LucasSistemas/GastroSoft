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
    public partial class frmPreguntasDeSeguridad : Form
    {
        private frmLogin loginForm;
        private GestionPreguntas _gestionPreguntas = new GestionPreguntas();

        private GestionGuardarRespuestas _gestionGuardar = new GestionGuardarRespuestas();

        private List<PreguntaSeguridad> _preguntasCargadas;


        public frmPreguntasDeSeguridad(frmLogin login)
        {
            InitializeComponent();
            loginForm = login;
        }

        private void frmPreguntasDeSeguridad_Load(object sender, EventArgs e)
        {
            //  Primero se ocultan todos los renglones de preguntas por defecto al momento de que se cargue la pantalla/formulario
            OcultarTodosLosCampos();

            // Luego se tare la lista aleatoria de preguta según la cantidad configurada en BD
            _preguntasCargadas = _gestionPreguntas.CargarPreguntasPantalla();

            // luego iteramos sobre las preguntas devueltas para activarlas dinámicamente
            for (int i = 0; i < _preguntasCargadas.Count; i++)
            {
                ActivarRenglonPregunta(i + 1, _preguntasCargadas[i].Pregunta);
            }
        }

        private void OcultarTodosLosCampos()
        {
            // Primero se apagan los controles visibles en el diseño diseño para luego ser activados la cantidad correspondiente segun las politicas
            lblPregunta1.Visible = false; txtRespuesta1.Visible = false;
            lblPregunta2.Visible = false; txtRespuesta2.Visible = false;
            lblPregunta3.Visible = false; txtRespuesta3.Visible = false;
            lblPregunta4.Visible = false; txtRespuesta4.Visible = false;
            lblPregunta5.Visible = false; txtRespuesta5.Visible = false;
        }

        private void ActivarRenglonPregunta(int numeroRenglon, string textoPregunta)
        {
            // Encendemos solo los controles necesarios y se setea el texto dinámico (osea la pregunta en cada lbl si es que corresponde segun las politicas)
            switch (numeroRenglon)
            {
                case 1:
                    lblPregunta1.Text = textoPregunta;
                    lblPregunta1.Visible = true; txtRespuesta1.Visible = true;
                    break;
                case 2:
                    lblPregunta2.Text = textoPregunta;
                    lblPregunta2.Visible = true; txtRespuesta2.Visible = true;
                    break;
                case 3:
                    lblPregunta3.Text = textoPregunta;
                    lblPregunta3.Visible = true; txtRespuesta3.Visible = true;
                    break;
                case 4:
                    lblPregunta4.Text = textoPregunta;
                    lblPregunta4.Visible = true; txtRespuesta4.Visible = true;
                    break;
                case 5:
                    lblPregunta5.Text = textoPregunta;
                    lblPregunta5.Visible = true; txtRespuesta5.Visible = true;
                    break;
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // txtRespuesta 1: Si el campo está visible y está vacío, frena y avisa y asi consecutivamente con los 5 textBox de respuestas
            if (txtRespuesta1.Visible && string.IsNullOrWhiteSpace(txtRespuesta1.Text))
            {
                MessageBox.Show("Por favor, responda la Pregunta 1.", "GastroSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRespuesta1.Focus();
                return;
            }

            // txtRespuesta  2
            if (txtRespuesta2.Visible && string.IsNullOrWhiteSpace(txtRespuesta2.Text))
            {
                MessageBox.Show("Por favor, responda la Pregunta 2.", "GastroSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRespuesta2.Focus();
                return;
            }

            // txtRespuesta  3
            if (txtRespuesta3.Visible && string.IsNullOrWhiteSpace(txtRespuesta3.Text))
            {
                MessageBox.Show("Por favor, responda la Pregunta 3.", "GastroSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRespuesta3.Focus();
                return;
            }

            // txtRespuesta  4
            if (txtRespuesta4.Visible && string.IsNullOrWhiteSpace(txtRespuesta4.Text))
            {
                MessageBox.Show("Por favor, responda la Pregunta 4.", "GastroSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRespuesta4.Focus();
                return;
            }

            // txtRespuesta  5
            if (txtRespuesta5.Visible && string.IsNullOrWhiteSpace(txtRespuesta5.Text))
            {
                MessageBox.Show("Por favor, responda la Pregunta 5.", "GastroSoft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRespuesta5.Focus();
                return;
            }

            // Se guardan las respuestas en la Base de Datos mediante la nueva clase lógica

            try
            {
                // Recorremos únicamente la cantidad de preguntas que se mostraron en pantalla
                for (int i = 0; i < _preguntasCargadas.Count; i++)
                {
                    string respuestaTexto = "";
                    switch (i + 1)
                    {
                        case 1: respuestaTexto = txtRespuesta1.Text; break;
                        case 2: respuestaTexto = txtRespuesta2.Text; break;
                        case 3: respuestaTexto = txtRespuesta3.Text; break;
                        case 4: respuestaTexto = txtRespuesta4.Text; break;
                        case 5: respuestaTexto = txtRespuesta5.Text; break;
                    }

                    // Guardamos la respuesta usando el método de la clase "GestioGuardarRespuestas.cs" de la capa Logica
                    _gestionGuardar.RegistrarRespuestaUsuario(_preguntasCargadas[i].IdPregunta, respuestaTexto);
                }

                MessageBox.Show("¡Todos los campos fueron completados correctamente!\n Configuración inicial completada.",
                                "GastroSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Luego de que se guarden las respuestas se da luz verde para abrir el menu princial
                SolicitarDatosEmpleado solicitarDatos = new SolicitarDatosEmpleado();

                string nombrecompleto= $"{solicitarDatos.SolicitarNombre()} {solicitarDatos.SolicitarApellido()}";

                frmMenuPrincipal menu = new frmMenuPrincipal(this.loginForm);
                menu.Show();

                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar guardar las respuestas en GastroSoft: ",
                                "GastroSoft - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}