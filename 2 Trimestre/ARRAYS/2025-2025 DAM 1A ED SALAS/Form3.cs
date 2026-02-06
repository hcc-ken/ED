using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_2025_DAM_1A_ED_SALAS
{
    public partial class Form3 : Form
    {
        private Sala[] cine;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Sala[] cine)
        {
            InitializeComponent();
            this.cine = cine;
            for (int i = 0; i < cine.Length; i++)
            {
                cbSala.Items.Add("Sala " + (i + 1));
            }
        }

        private void cbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarlabels();
        }

        private void actualizarlabels()
        {
            float total = 0f;
            int pos = cbSala.SelectedIndex;
            lblButacas.Text = "ButacasLibres : " + cine[pos].ButacasLibres();
            lblPorcentaje.Text = "Ocupacion :" + cine[pos].PorcentajeOcupacion();
            lblIngresos.Text = "Ingresos :" + cine[pos].Ingresos();

            foreach (Sala s in cine)
            {
                if (s != null)
                {
                    total += s.Ingresos();
                }
            }
            lblTotales.Text = "Ingresos Totales: " + total;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int pos = cbSala.SelectedIndex;
            if (cine[pos].EntraUno()) 
            {
                actualizarlabels();
            }
            else
            {
                MessageBox.Show("No hay butacas libres");
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            int pos = cbSala.SelectedIndex;
            cine[pos].Vaciar();
            actualizarlabels();
        }
    }
}
