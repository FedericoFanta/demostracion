using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string password = txtContraseña.Text;

            if (nombre.ToUpper() == "GABY" && password == "123456")
            {
                MessageBox.Show("Bienvenida! " + nombre);
            }
            else
            {
                MessageBox.Show("No está registrado.");
            }

        }
    }
}
