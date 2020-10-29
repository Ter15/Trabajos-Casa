using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//. Realizar un programa que cambie de pesetas a euros y viceversa:
namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double euro = double.Parse(textBox1.Text);
            double pesetas = euro * 166.3860;

            textBox2.Text = pesetas.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pesetas = double.Parse(textBox2.Text);
            double euros = pesetas * 0.0060;

            textBox1.Text = euros.ToString();
        }
    }
}
