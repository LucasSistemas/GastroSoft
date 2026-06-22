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
    public partial class frmNuevaContraseña : Form
    {
        private frmMenuPrincipalParaAdm menu;

        public frmNuevaContraseña(frmMenuPrincipalParaAdm menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            menu.Show();
        }

    }
}
