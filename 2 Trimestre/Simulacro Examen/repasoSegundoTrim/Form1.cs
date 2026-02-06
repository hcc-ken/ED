using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repasoSegundoTrim
{
    public partial class Form1 : Form
    {
        char[] codigo = new char[10];
        int auxiliar = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new string(codigo));
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (auxiliar < codigo.Length)
            {
                codigo[auxiliar] = '0';
                auxiliar++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (auxiliar < codigo.Length)
            {
                codigo[auxiliar] = '1';
                auxiliar++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (auxiliar < codigo.Length)
            {
                codigo[auxiliar] = '2';
                auxiliar++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (auxiliar < codigo.Length)
            {
                codigo[auxiliar] = '3';
                auxiliar++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (auxiliar < codigo.Length)
            {
                codigo[auxiliar] = '4';
                auxiliar++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (auxiliar < codigo.Length)
            {
                codigo[auxiliar] = '5';
                auxiliar++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (auxiliar < codigo.Length)
            {
                codigo[auxiliar] = '6';
                auxiliar++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (auxiliar < codigo.Length)
            {
                codigo[auxiliar] = '7';
                auxiliar++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (auxiliar < codigo.Length)
            {
                codigo[auxiliar] = '8';
                auxiliar++;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (auxiliar < codigo.Length)
            {
                codigo[auxiliar] = '9';
                auxiliar++;
            }
        }
    }
}
