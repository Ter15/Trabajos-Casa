using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
// Realizar un programa que lea un numero correspondiente a una nota y escriba si el resultado
//es muy deficiente, insuficiente, suficiente, bien, notable o sobresaliente. Las notas pueden tener
//decimales. Por ejemplo: 7,25
namespace Práctica_3._6
{ 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string NOTAS(double numero)
        {

            if (numero < 5)
            {
                return "insuficinete";
            }
            else if (numero >= 5 && numero < 6)
            {
                return "suficinete";
            }
            else
            {
                if (numero >= 6 && numero < 7)
                    return "bien";
                else if (numero >= 7 && numero < 9)
                    return "notable";
                else if (numero >= 9 && numero <= 10)
                    return "sobresaliente";
                else
                    return "nada";

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(textBox1.Text);
            string  NOTAS2= NOTAS(numero);
            MessageBox.Show( NOTAS2);

        }
    }
}
