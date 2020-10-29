using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// . En una tienda se adquieren tres productos. Introduciendo el precio de cada uno de
//los productos, mostrar por pantalla el importe total a abonar, sin IVA y con IVA,
//siendo éste del 21%
namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Producto1 = double.Parse(textBox1.Text);
            double Producto2 = double.Parse(textBox2.Text);
            double Producto3 = double.Parse(textBox3.Text);

            double sinIVA = Producto1 + Producto2 + Producto3;
            double resultadoConIva = (sinIVA * 0.21) + sinIVA;
           

            textBox4.Text = resultadoConIva.ToString();
            textBox5.Text = sinIVA.ToString();



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
