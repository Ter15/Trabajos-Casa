using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            if ( numero1 > numero2)
            {               
                MessageBox.Show("el número mayor es: " + numero1);
            }
            else if(numero1 == numero2)
            {
                MessageBox.Show("los números son iguales");
            }
            else 
            {
                MessageBox.Show("el número mayor es: " + numero2);
            }
        }

    }
}
