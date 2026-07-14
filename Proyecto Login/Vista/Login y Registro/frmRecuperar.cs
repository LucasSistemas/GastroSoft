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
    public partial class frmRecuperar : Form
    {
        frmLogin login;
        public frmRecuperar(frmLogin login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }
    }
}
