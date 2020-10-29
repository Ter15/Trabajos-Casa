using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Dada una cantidad ingresada en un banco por un cliente, y el interés anual, calcular
//el capital que tendría a final del año.
namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dinero = double.Parse(textBox1.Text);
            double interes = double.Parse(textBox2.Text);

            double beneficio = dinero * (interes / 100);
            double capital = beneficio + dinero;
            textBox3.Text = capital.ToString();

        }
    }
}
