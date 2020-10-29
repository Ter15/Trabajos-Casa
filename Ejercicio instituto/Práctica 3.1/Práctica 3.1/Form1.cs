using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int numero = int.Parse(textBox1.Text);


            if (numero == 2)
            {
                MessageBox.Show("has introducido el numero 2 ");


            }
            else
            {
                MessageBox.Show("has introducido un numero distinto a 2");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
