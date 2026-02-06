using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
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

                    btn.Tag = pokemon[i, j]; // Tag sirve para almacenar un dato extra, se podrá usar para utilizarlo después.

                    string nombre = pokemon[i, j];
                    string ruta = $"imagenes/{nombre}.png";

                    if (File.Exists(ruta))
                    {
                        btn.BackgroundImage = Image.FromFile(ruta);
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                    }

                    this.Controls.Add(btn); // Eso añade (btn) o sea, el botón para que se muestre.

                    btn.Click += button1_Click; // Al pulsar, añadir "+=" event handler. Lo que hay abajo.
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Esto es un Event Handler, aquí ocurrirá lo que queremos que pase cuando el botón es pulsado.
        {
            Button btn = (Button)sender;
            string nombre = btn.Tag.ToString();

            string ruta = $"imagenes/{nombre}.png";
            
            if (File.Exists(ruta))
            {
                btn.BackgroundImage = Image.FromFile(ruta);
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Text = " ";
            }

            MessageBox.Show("Has pulsado el botón de " + nombre);
        }
    }
}
