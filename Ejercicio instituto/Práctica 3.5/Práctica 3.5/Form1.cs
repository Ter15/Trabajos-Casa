using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //hacer una función que se le pasen 3 enteros y que devuelva el mayor d elos 3
               
            public static int EsMayorDe3(int a, int b, int c)
            {
                if (a > b)
                {
                    if (a > c)
                        return a;
                    else
                        return c;
                }
                else
                {
                    if (b > c)
                        return b;
                    else
                        return c;
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int numero3 = int.Parse(textBox3.Text);

            int mayor = EsMayorDe3(numero1, numero2, numero3);

            MessageBox.Show(" el numero mayor es el: " + mayor);
        }
    }
}
