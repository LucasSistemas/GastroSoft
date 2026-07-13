using Datos.DTOs;
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

namespace Vista.Gestion_Usuarios
{
    public partial class frmCambiarRespuestas : Form
    {
        private frmEditarPerfilUsuario perfil;
        private PreguntasRespuestas logica = new PreguntasRespuestas();
        private int idUsuarioActual;
        private List<RespuestaSeguridadDTO> respuestasOriginales;

        // Constructor 1: Si necesitás pasarle la referencia del perfil
        public frmCambiarRespuestas(frmEditarPerfilUsuario perfil, int idUsuario)
        {
            InitializeComponent();
            this.perfil = perfil;
            this.idUsuarioActual = idUsuario;
        }

        // Constructor 2: Por si querés llamarlo solo con el ID (sobrecarga útil)
        public frmCambiarRespuestas(int idUsuario)
        {
            InitializeComponent();
            this.idUsuarioActual = idUsuario;
        }

        private void frmCambiarRespuestas_Load(object sender, EventArgs e)
        {
            CargarPreguntasUsuario();
        }

        private void CargarPreguntasUsuario()
        {
            try
            {
                respuestasOriginales = logica.ObtenerRespuestasUsuario(idUsuarioActual);

                if (respuestasOriginales != null && respuestasOriginales.Count >= 5)
                {
                    lblPregunta_1.Text = respuestasOriginales[0].Pregunta;
                    lblPregunta_2.Text = respuestasOriginales[1].Pregunta;
                    lblPregunta_3.Text = respuestasOriginales[2].Pregunta;
                    lblPregunta_4.Text = respuestasOriginales[3].Pregunta;
                    lblPregunta_5.Text = respuestasOriginales[4].Pregunta;

                    tbRespuesta_1.Text = respuestasOriginales[0].Respuesta;
                    tbRespuesta_2.Text = respuestasOriginales[1].Respuesta;
                    tbRespuesta_3.Text = respuestasOriginales[2].Respuesta;
                    tbRespuesta_4.Text = respuestasOriginales[3].Respuesta;
                    tbRespuesta_5.Text = respuestasOriginales[4].Respuesta;
                }
                else
                {
                    MessageBox.Show("No se pudieron cargar las 5 preguntas de seguridad del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las preguntas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btGuardar_Cambios_Click(object sender, EventArgs e)
        {
            // Validaciones de campos vacíos
            if (string.IsNullOrWhiteSpace(tbRespuesta_1.Text))
            {
                MessageBox.Show("Debe responder la pregunta 1.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRespuesta_1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbRespuesta_2.Text))
            {
                MessageBox.Show("Debe responder la pregunta 2.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRespuesta_2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbRespuesta_3.Text))
            {
                MessageBox.Show("Debe responder la pregunta 3.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRespuesta_3.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbRespuesta_4.Text))
            {
                MessageBox.Show("Debe responder la pregunta 4.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRespuesta_4.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbRespuesta_5.Text))
            {
                MessageBox.Show("Debe responder la pregunta 5.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRespuesta_5.Focus();
                return;
            }

            try
            {
                List<RespuestaSeguridadDTO> respuestasNuevas = new List<RespuestaSeguridadDTO>
                {
                    new RespuestaSeguridadDTO { IdPregunta = respuestasOriginales[0].IdPregunta, Respuesta = tbRespuesta_1.Text.Trim() },
                    new RespuestaSeguridadDTO { IdPregunta = respuestasOriginales[1].IdPregunta, Respuesta = tbRespuesta_2.Text.Trim() },
                    new RespuestaSeguridadDTO { IdPregunta = respuestasOriginales[2].IdPregunta, Respuesta = tbRespuesta_3.Text.Trim() },
                    new RespuestaSeguridadDTO { IdPregunta = respuestasOriginales[3].IdPregunta, Respuesta = tbRespuesta_4.Text.Trim() },
                    new RespuestaSeguridadDTO { IdPregunta = respuestasOriginales[4].IdPregunta, Respuesta = tbRespuesta_5.Text.Trim() }
                };

                bool exito = logica.GuardarCambiosRespuestas(idUsuarioActual, respuestasNuevas);

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

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}