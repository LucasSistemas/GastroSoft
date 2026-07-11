using Entidad;
using Logica;
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
    public partial class frmPoliticasContraseña : Form
    {
        private frmMenuPrincipal menu;
        public frmPoliticasContraseña(frmMenuPrincipal frmMenuPrincipal)
        {
            InitializeComponent();
            this.menu = frmMenuPrincipal; 
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            // 1. Instanciamos la entidad limpia de la capa "ENTIDAD" y la rellenamos con los valores de los controles de la pantalla
            PoliticasSeguridadContraseña nuevasPoliticas = new PoliticasSeguridadContraseña();

            nuevasPoliticas.LongitudMinima = (int)nudLongitud.Value;
            nuevasPoliticas.RequiereMayusculas = cbMayuscula.Checked;
            nuevasPoliticas.RequiereNumeros = cbNumeros.Checked;
            nuevasPoliticas.RequiereEspeciales = cbCaracteres.Checked;
            nuevasPoliticas.NoRepetirContraseñas = cbNoRepetir.Checked;
            nuevasPoliticas.ValidarDatosPersonales = cbValidar.Checked;

            // Aca se evaluan los radioButtons para saber la cantidad de preguntas dependiendo de cual este tildada / checkeada
            if (rbDos.Checked) nuevasPoliticas.CantidadPreguntasRequeridas = 2;
            else if (rbTres.Checked) nuevasPoliticas.CantidadPreguntasRequeridas = 3;
            else if (rbCinco.Checked) nuevasPoliticas.CantidadPreguntasRequeridas = 5;

            /// 2. Instanciamos la Capa Lógica y le enviamos el objeto "nuevasPoliticas" empaquetado,
            /// Capa Vista ------> Capa Lógica, si la capa Logica le da luz verde a los datos empaquetados de la capa Vista pues este le emvia los datos empaquetados al metodo "GuardarPoliticas" de la capa Datos y aca se inyectan los datos mediante el stored prosedure sp_ModificarConfiguracionSeguridad y ejecuta la consulta sql
            GestionPoliticasContraseña logica = new GestionPoliticasContraseña();
            bool exito = logica.ModificarPoliticas(nuevasPoliticas);

            // 3. Evaluamos la respuesta de las capas inferiores (datos y entidad) para avisarle al usuario
            if (exito)
            {
                MessageBox.Show("Políticas de seguridad guardadas con éxito en la Base de Datos de Gastrosoft.", "GastroSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error o los datos no son válidos para la Base de Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // y si pincha la conexion con la BD se muestra un mensaje de error
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
