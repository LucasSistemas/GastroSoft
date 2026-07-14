using Entidad.Preguntas_y_Respuestas;
using Logica;
using Logica.Cargar_datos_a_Formularios.Preguntas_a_CambiarRespuestas;
using Logica.Gestion_de_Empleados;
using Logica.Gestion_de_Usuario;
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
using TextBox = System.Windows.Forms.TextBox;

namespace Vista.Gestion_Usuarios
{
    public partial class frmCambiarRespuestas : Form
    {
        frmEditarPerfilUsuario frmEditarPerfil;

        CargarPreguntasUsuario cargar;
        private GestionRespuestasSeguridad gestionperfil;
        private List<Preguntas_Seguridad> listaPreguntas = new List<Preguntas_Seguridad>();
        private CargarPreguntasSeguridad cargarPreguntas;


        // Constructor 1: Si necesitás pasarle la referencia del perfil
        public frmCambiarRespuestas(frmEditarPerfilUsuario perfil)
        {
            InitializeComponent();
            this.frmEditarPerfil = perfil;
        }

        private void frmCambiarRespuestas_Load(object sender, EventArgs e)
        {
            //  Primero se ocultan todos los renglones de preguntas por defecto al momento de que se cargue la pantalla/formulario
            OcultarTodosLosCampos();

            cargar = new CargarPreguntasUsuario();

            var resultado = cargar.CargarPreguntas();

            Label[] labelspregunta ={lblPregunta1,lblPregunta2,lblPregunta3,lblPregunta4,lblPregunta5};
            Label[] labelsrespuesta = { lblRespuesta1, lblRespuesta2, lblRespuesta3, lblRespuesta4, lblRespuesta5 };
            TextBox[] textBoxes = {txtRespuesta1,txtRespuesta2,txtRespuesta3,txtRespuesta4,txtRespuesta5 };


            if (!resultado.Exito)
            {
                MessageBox.Show(resultado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Preguntas_Seguridad> preguntas = resultado.Preguntas;

                for (int i = 0; i < labelspregunta.Length; i++)
                {
                    if (i < preguntas.Count)
                    {
                        labelspregunta[i].Text = preguntas[i].Pregunta;
                        labelspregunta[i].Visible = true;
                        labelsrespuesta[i].Visible = true;
                        textBoxes[i].Visible = true;
                    }
                    else
                    {
                        labelspregunta[i].Visible = false;
                        labelsrespuesta[i].Visible = false;
                        textBoxes[i].Visible = false;
                    }
                }
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

        private void btGuardar_Cambios_Click(object sender, EventArgs e)
        {
            // Validaciones de campos vacíos
            if (txtRespuesta1.Visible && string.IsNullOrWhiteSpace(txtRespuesta1.Text))
            {
                MessageBox.Show("Debe responder la pregunta 1.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRespuesta1.Focus();
                return;
            }

            if (txtRespuesta2.Visible && string.IsNullOrWhiteSpace(txtRespuesta2.Text))
            {
                MessageBox.Show("Debe responder la pregunta 2.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRespuesta2.Focus();
                return;
            }

            if (txtRespuesta3.Visible && string.IsNullOrWhiteSpace(txtRespuesta4.Text))
            {
                MessageBox.Show("Debe responder la pregunta 3.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRespuesta4.Focus();
                return;
            }

            if (txtRespuesta4.Visible && string.IsNullOrWhiteSpace(txtRespuesta3.Text))
            {
                MessageBox.Show("Debe responder la pregunta 4.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRespuesta3.Focus();
                return;
            }

            if (txtRespuesta5.Visible && string.IsNullOrWhiteSpace(txtRespuesta5.Text))
            {
                MessageBox.Show("Debe responder la pregunta 5.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRespuesta5.Focus();
                return;
            }

            try
            {
                List<Respuestas_Seguridad> respuestasNuevas = new List<Respuestas_Seguridad>
                {
                    new Respuestas_Seguridad { IdPregunta = listaPreguntas[0].IdPregunta, RespuestaHash = txtRespuesta1.Text},
                    new Respuestas_Seguridad { IdPregunta = listaPreguntas[1].IdPregunta, RespuestaHash = txtRespuesta2.Text},
                    new Respuestas_Seguridad { IdPregunta = listaPreguntas[2].IdPregunta, RespuestaHash = txtRespuesta3.Text},
                    new Respuestas_Seguridad { IdPregunta = listaPreguntas[3].IdPregunta, RespuestaHash = txtRespuesta4.Text},
                    new Respuestas_Seguridad { IdPregunta = listaPreguntas[4].IdPregunta, RespuestaHash = txtRespuesta5.Text}
                };

                gestionperfil = new GestionRespuestasSeguridad();
                bool exito = gestionperfil.ActualizarCambiosRespuestas(respuestasNuevas);

                if (exito)
                {
                    MessageBox.Show("Respuestas de seguridad actualizadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudieron actualizar todas las respuestas. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar los cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            frmEditarPerfil.Show();
        }
    }
}