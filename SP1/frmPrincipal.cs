using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
            this.Show();
        }

        private void cmdSignIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no disponible por mantenimiento...");
        }
    }
}
