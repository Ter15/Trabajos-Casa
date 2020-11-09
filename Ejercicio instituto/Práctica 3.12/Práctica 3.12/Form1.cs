using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Realizar un programa que muestre por pantalla los números del 1 al número introducido por
//el usuario.Hacer con 3 botones: Uno con for, otro con while y otro con do..while.
namespace Práctica_3._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero =int.Parse(textBox1.Text);
            int i;
            string MensajeMostrar = "";

            for ( i = 1; numero >= i; i++ )
            {
                MensajeMostrar += i + " ";
                
            }
            MessageBox.Show(MensajeMostrar);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int i = 0;
            string MensajeMostrar = "";
           
            while  (numero >= i )
            {
                MensajeMostrar += i + " ";
                i++;
            }
            MessageBox.Show(MensajeMostrar);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int i = 0;
            string MensajeMostrar = "";

            do
            {
                MensajeMostrar += i + " ";
                i++;
            }
            while(numero >= i);
            MessageBox.Show(MensajeMostrar);
        }
    }
}
