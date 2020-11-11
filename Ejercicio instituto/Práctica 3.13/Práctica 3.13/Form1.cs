using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Hacer un programa que muestre por pantalla los números pares del 1 al número introducido
//por el usuario. Hacer con for, while y do…while, cada uno en un botón del formulario.
namespace Práctica_3._13
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
            int i;
            string Mensaje = "";

            for ( i = 0; ((numero % 2) == 0); i ++ )
            {
                Mensaje += i + " ";
            }
            MessageBox.Show(Mensaje);
        }
    }
}
