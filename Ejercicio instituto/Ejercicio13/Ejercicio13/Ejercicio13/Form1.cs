using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Un trabajador a lo largo del mes trabaja un número de horas normales y un número
//de horas extras. Las horas extras se pagan el doble que las horas normales. Realizar
//un programa en el que se introduzcan el número de horas trabajadas (normales y
//extras) y la paga por hora normal, y se calcule la nomina mensual, aplicando una
//retención del 18%.
namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double horasextra = double.Parse(textBox1.Text);
            double horasnormales = double.Parse(textBox2.Text);
            double euroHNormal = double.Parse(textBox4.Text);

            double euroHExtra = euroHNormal * 2;
            double reduccion = (horasextra * euroHExtra + horasnormales * euroHNormal) * 0.18;
            double totalNomina = (horasextra * euroHExtra + horasnormales * euroHNormal) - reduccion;

            textBox5.Text = euroHExtra.ToString();
            textBox3.Text = totalNomina.ToString();  

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
