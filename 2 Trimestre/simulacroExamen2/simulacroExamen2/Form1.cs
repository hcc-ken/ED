using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacroExamen2
{
    public partial class Form1 : Form
    {
        double [] articulos = new double[5];
        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contador < articulos.Length)
            {
                articulos[contador] = Convert.ToDouble(textBox1.Text);
                contador++;
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Ya se han ingresado los 5 artículos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(articulos);
            form2.ShowDialog();
        }
    }
}
