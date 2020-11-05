using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Realizar un programa que lea un numero entero del 1 al 5 y de un mensaje por pantalla
//indicando el número que se ha introducido. Ej 1 -> Se ha apretado el uno, 2-> Se ha apretado el
//dos... (Utilizar switch case.)
namespace Práctica_3._7
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
                            
            switch (numero)
            {
                case 1:
                    MessageBox.Show (" el número que se a apretado es el 1");
                    break;
                case 2:
                    MessageBox.Show(" el número que se a apretado es el 2");
                    break;
                case 3:
                    MessageBox.Show(" el número que se a apretado es el 3");
                    break;
                case 4:
                    MessageBox.Show(" el número que se a apretado es el 4");
                    break;
                case 5:
                    MessageBox.Show(" el número que se a apretado es el 5");
                    break;
                default:
                    MessageBox.Show("");
                    break;
            }

        }
    }
}
