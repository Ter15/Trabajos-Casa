using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica.Ejercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void BSuma_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = numero + b;

            textBox3.Text = c.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void BResta_Click(object sender, EventArgs e)
        {
            int a = int.Parse (textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a - b;

            textBox3.Text = c.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = numero / b;

            textBox3.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = numero % b;

            textBox3.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BMultiplicar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = numero * b;

            textBox3.Text = c.ToString();
        }
    }
}
