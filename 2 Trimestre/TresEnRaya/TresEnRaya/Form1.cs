using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TresEnRaya
{
    public partial class Form1 : Form
    {
        int player = 0;
        public Form1()
        {
            InitializeComponent();

            Button[,] buttons = new Button[3, 3];

            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 150;
                    buttons[i, j].Height = 150;

                    buttons[i, j].Top = i * 150;
                    buttons[i, j].Left = j * 150;

                    buttons[i, j].Click += new EventHandler(buttonsPressed);

                    this.Controls.Add(buttons[i, j]);

                }
            }
        }

        private void buttonsPressed(object sender, EventArgs e)
        {
            Button buttonsPressed = (Button)sender;
            if (buttonsPressed.Image != null)
            {
                MessageBox.Show("Éste movimiento no está permitido.");
                return;
            }

            if (player == 0) 
            {
                buttonsPressed.Image = Image.FromFile("C:\\Users\\Alumno1\\Pictures\\images O.jfif");
                player++;
            }
            else
            {
                buttonsPressed.Image = Image.FromFile("C:\\Users\\Alumno1\\Pictures\\images.jfif");
                player--;
            }


        }
        //for (int i = 0; i < botones.GetLength(0); i++)
        //{
        //    for (int j = 0; j < botones.GetLength(1); j++)
        //    {
        //        botones[i, j] = new Button();
        //
        //botones[i, j].Width = 100;
        //botones[i, j].Height = 100;
        //
        //botones[i, j].Top = i * 100;
        //botones[i, j].Left = j * 100;
        //
        //botones[i, j].Text = "Botón " + i + " " + j;
        //botones[i, j].Tag = " " + i + " " + j;
        //
        //botones[i, j].Click += new EventHandler(botonPulsado);
        //
        //this.Controls.Add(botones[i, j]);
        //}
        //}
        //botones[i, j].Click += new EventHandler(botonPulsado);

        //this.Controls.Add(botones[i, j]);
    }
}
