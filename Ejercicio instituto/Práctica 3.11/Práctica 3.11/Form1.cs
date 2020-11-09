using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Realizar un programa en el que introduzcamos una hora con minutos y segundos. Tras
//validar los datos (que sea una hora correcta) nos escribirá la hora de un segundo después. Validar
//la hora significa que la hora esté entre 0 y 23, los minutos entre 0 y 59 y los segundos entre 0 y
//59, en otro caso nos dará un mensaje de error
namespace Práctica_3._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int hora = int.Parse(textBox1.Text);            
           int minutos = int.Parse(textBox2.Text);
           int segundo = int.Parse(textBox3.Text);

            if (segundo < 59 && segundo > 0)
            {
                segundo = segundo + 1;
            }
            else if (segundo == 59)
            {
                segundo = 00;
            }
            else if (minutos == 59)
            {
                minutos = 00;
            }
                              
            
            else
            {
                MessageBox.Show("has introducido un error A");
            }

            if (minutos < 59 && minutos > 0)
            {
                minutos = minutos + 1;
            }
            else if (minutos == 59)
            {
                hora = hora + 1;
                minutos = 0;
            }
            else
            {
                MessageBox.Show("has introducido un error B");
            }

            if (hora < 23 && hora > 0)
            {
                hora++;
            }
            else if (hora == 23)
            {
                hora = 00;
            }
            else
            {
                MessageBox.Show("has introducido un error C");
            }
            MessageBox.Show("La hora siguiente es: " + hora + " : " + minutos + " : " + segundo);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
