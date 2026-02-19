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
    public partial class Form2 : Form
    {
        double[] lista = new double[5];

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(double[] articulos)
        {
            InitializeComponent();
            lista = articulos;
            MostrarInformacion();

        }

        private void MostrarInformacion()
        {
            string mensaje = "Los artículos son: \n";
            double suma = 0;

            for (int i = 0; i < lista.Length; i++)
            {
                mensaje = mensaje + "Producto " + (i + 1) + ": " + lista[i] + "\n";
                suma += lista[i];
            }

            label1.Text = mensaje;
            label2.Text = "El total a pagar es: " + suma;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
