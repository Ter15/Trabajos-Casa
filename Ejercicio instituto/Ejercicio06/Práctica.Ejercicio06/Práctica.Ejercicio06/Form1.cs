using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Realizar un programa que lea el valor de dos variables de tipo entero y muestre por
//pantalla con un MessageBox el valor de la división entera y del resto de la división entera.
namespace Práctica.Ejercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dividendo = int.Parse(textBox1.Text);
            int divisor = int.Parse(textBox2.Text);
            int division = (dividendo / divisor);
            int resto = dividendo % divisor;
            textBox3.Text = resto.ToString();
            textBox4.Text = division.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
