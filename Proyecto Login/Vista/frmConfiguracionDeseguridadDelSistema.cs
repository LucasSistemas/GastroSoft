using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using Sesion;

namespace Vista
{
    public partial class frmConfiguracionDeseguridadDelSistema : Form
    {
        public frmConfiguracionDeseguridadDelSistema()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void frmConfiguracionDeseguridadDelSistema_Load(object sender, EventArgs e)
        {
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            // Para la longitud de la contraseña del textbox "LongitudMinima" configurado en el "nudLongitud"
            UsuarioSesion.Politicas_De_Contraseñas.LongitudMinima = (int)nudLongitud.Value;

            // Para los CheckBoxes
            UsuarioSesion.Politicas_De_Contraseñas.RequiereMayusculas = cbMayuscula.Checked;
            UsuarioSesion.Politicas_De_Contraseñas.RequiereNumeros = cbNumeros.Checked;
            UsuarioSesion.Politicas_De_Contraseñas.RequiereEspeciales = cbCaracteres.Checked;
            UsuarioSesion.Politicas_De_Contraseñas.NoRepetirContraseñas = cbNoRepetir.Checked;

            // Para la cantidad de preguntas dependiendo del "RadioButtons" tildado
            if (rbDos.Checked) UsuarioSesion.Politicas_De_Contraseñas.CantidadPreguntasRequeridas = 2;
            else if (rbTres.Checked) UsuarioSesion.Politicas_De_Contraseñas.CantidadPreguntasRequeridas = 3;
            else if (rbCinco.Checked) UsuarioSesion.Politicas_De_Contraseñas.CantidadPreguntasRequeridas = 5;

            MessageBox.Show("Políticas de seguridad actualizadas correctamente.", "GastroSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}