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

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String[,] pokemon = {
                {"Bulbasaur", "Charmander", "Squirtle" },
                { "Chikorita", "Cyndaquil", "Totodile"}
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Text = pokemon[i, j];
                    btn.Width = 100;
                    btn.Height = 30;
                    btn.Left = j * 110;
                    btn.Top = i * 40;

                    this.Controls.Add(btn);
                }
            }

            if ()
            {
                MessageBox.Show("El primer Pokémon es Bulbasaur");
            }
    }
}
