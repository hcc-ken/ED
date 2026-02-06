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
    public partial class Form1 : Form
    {
        private Sala[] cine;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Sala[] cine)
        {
            InitializeComponent();
            this.cine = cine;

            for (int i = 0; i < cine.Length; i++)
            {
                cbSala.Items.Add("Sala " + (i + 1));
            }
        }

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            String pelicula;
            int aforo, ocupadas;
            float entrada = 0;
            Sala misala;

            int posicion;

            pelicula = txtPelicula.Text;
            aforo = (int)nudAforo.Value;  //.VALUE SIEMPRE DEVUELVE DECIMAL, HAY QUE CONVERTIRLO A INT CUANDO LA VARIABLE ES INT CON (INT) ANTES DE NUD
            ocupadas = (int)nudOcupadas.Value;
            if (rb5.Checked)
            {
                entrada = 5f; //LA F AL FINAL ES PARA DECIRLE AL COMPILADOR QUE ES UN FLOAT
            }
            else
            {
                if (rb6.Checked)
                {
                    entrada = 6.5f;
                }
                else
                {
                    if (rb8.Checked)
                    {
                        entrada = 8f;
                    }
                    else
                        entrada = 0f;
                }
            }
            misala = new Sala(pelicula, aforo, ocupadas, entrada);

            posicion = cbSala.SelectedIndex;
            if (posicion == -1) {
                MessageBox.Show("Seleccione una sala");
            
            }
            else
            {
                cine[posicion] = misala;
                Limpiar();
            }   
        }

        private void Limpiar()
        {
            cbSala.SelectedIndex = -1;
            txtPelicula.Clear();
            nudAforo.Value = 0;
            nudOcupadas.Value = 0;
            rb5.Checked = false;
            rb6.Checked = false;
            rb8.Checked = false;
        }

    }

}
