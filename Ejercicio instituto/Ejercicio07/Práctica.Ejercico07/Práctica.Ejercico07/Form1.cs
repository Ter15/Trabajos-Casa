using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica.Ejercico07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double altura = double.Parse(textBox1.Text);
            double resultado = altura / 100;

            

            label3.Text = "Tu altura es: " + resultado.ToString() + " metros.";
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
