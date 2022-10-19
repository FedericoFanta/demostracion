using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class FormNotas : Form
    {
        public FormNotas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txtNota1.Text); //convierte mi dato base a decimal
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota3.Text);
            decimal nota4 = Convert.ToDecimal(txtNota4.Text);

            MessageBox.Show("Nota 1: " +nota1 +
                "\nNota 2: " +nota2 +
                "\nNota 3: " +nota3 +
                "\nNota 4: " +nota4);

            if ((nota1 > nota2) && (nota1 > nota3) && (nota1 > nota4))
            {
                MessageBox.Show("La mayor nota es: "+nota1);
            }

            else if ((nota2 > nota1) && (nota2 > nota3) && (nota2 > nota4))
            {
                MessageBox.Show("La mayor nota es: "+nota2);
            }

            else if ((nota3 > nota1) && (nota3 > nota2) && (nota3 >nota4))
            {
                MessageBox.Show("La mayor nota es: "+nota3);
            }

            else 
            {
                MessageBox.Show("La mayor nota es: "+nota4);
            }

            decimal promedio = (nota1+nota2+nota3+nota4)/4;

            MessageBox.Show("El promedio es: "+promedio);
           
            if (promedio >= 9)
            {
                MessageBox.Show("Excelente");
            }

            else if ((promedio < 9) && (promedio >= 7))
            {
                MessageBox.Show("Muy bien");
            }

            else if ((promedio < 7) && (promedio >= 4))
            {
                MessageBox.Show("Regular");
            }

            else 
            {
                MessageBox.Show("En proceso de aprendizaje");
            }
        }
    }
}
