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
    public partial class frmLogin : Form
    {
        int errores = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            string modulo = cbModulo.Text;
            frmBienvenida bienvenida = new frmBienvenida();
            switch (usuario)
            {
                case "Adm":
                    if (contrasena == "@1a" && (modulo == "ADM" || modulo == "COM" || modulo == "VTA"))
                    {
                        this.Hide();
                        bienvenida.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña y/o módulo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errores++;
                    }
                    break;
                case "John":
                    if (contrasena == "*2b" && modulo == "SIST")
                    {
                        this.Hide();
                        bienvenida.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña y/o módulo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errores++;
                    }
                    break;
                case "Ceci":
                    if (contrasena == "*@3c" && (modulo == "ADM" || modulo == "VTA"))
                    {
                        this.Hide();
                        bienvenida.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña y/o módulo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errores++;
                    }
                    break;
                case "God":
                    if (contrasena == "*@#4d" && modulo != "" )
                    {
                        this.Hide();
                        bienvenida.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña y/o módulo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errores++;
                    }
                    break;
                default:
                    MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errores++;
                    break;
            }
            if (errores == 2)
            {
                MessageBox.Show("Demasiados intentos erroneos. Se cerrará el formulario.");
                this.Close();
            }
        }
    }
}
