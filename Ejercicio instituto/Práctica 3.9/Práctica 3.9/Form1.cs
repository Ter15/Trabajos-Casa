using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Realizar un programa que pida una cantidad de dinero (en pesetas), y muestre en una etiqueta
//cuantos billetes de 10.000, de 5.000, de 2.000, de 1000 y monedas de 100 y 25 le corresponden.
//Por ejemplo: 27.375 le corresponde 2 de 10.000, 1 de 5.000, 1 de 2.000, 3 de 100 y 3 de 25.
//Hacerlo de forma que si corresponde 0 billetes no aparezca
namespace Práctica_3._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            double quantity = double.Parse(textBox1.Text);
            double billetes10000 = cociente(quantity, 10000);
            double resto10000 = resto(quantity, 10000);
            if (billetes10000 >= 1) 
                label2.Text = "Hay " + Math.Floor(billetes10000) + " billetes de 10.000 \n";
            double billetes5000 = cociente(resto10000 , 5000);
            double resto5000 = resto(resto10000, 5000);
            if (billetes5000 >= 1)
               label2.Text += "Hay " + Math.Floor(billetes5000 )+ " billetes de 5.000 \n";
            double billetes2000 = cociente(resto5000, 2000);
            double rest2000 = resto(resto5000, 2000);
            if (billetes2000 >= 1)
                label2.Text += "Hay " + Math.Floor(billetes2000) + " billetes de 2.000 \n";
            double billetes1000 = cociente(rest2000, 1000);
            double resto1000 = resto(rest2000, 1000);
            if (billetes1000 >= 1)
                label2.Text += "Hay " + Math.Floor(billetes1000) + " billetes de 1.000 \n";
            double billetes100 = cociente(resto1000, 100);
            double rest100 = resto(resto1000, 100);
            if (billetes100 >= 1)
                label2.Text += "Hay " + Math.Floor(billetes100) + " monedas de 100 \n";
            double billetes25 = cociente(rest100, 25);
            double rest25 = resto(rest100, 25);
            if (billetes25 >= 1)
                label2.Text += "Hay " + Math.Floor(billetes25) + " monedas de 25 \n";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private double cociente ( double dividendo, double divisor)
        {
            double cociente = dividendo / divisor;
            return cociente;
        }
        private double resto (double dividendo, double divisor)
        {
            double resto = dividendo % divisor;
                return resto;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
