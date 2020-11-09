using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_3._8
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                                 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto;            
            texto = textBox1.Text;                      
            label3.Text += "\n" + texto;            
                                                                                              
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
