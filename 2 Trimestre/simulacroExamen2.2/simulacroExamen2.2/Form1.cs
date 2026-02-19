using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacroExamen2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] matriz = new int[2, 4];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++) 
                { 
                    Button btn = new Button();
                    btn.Text = "P " + i + ", " + j;
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Left = j * 100;
                    btn.Top = i * 50;

                    btn.Tag = i + ","+  j;
                    this.Controls.Add(btn);

                    btn.Click += button1_Click;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string plaza = btn.Tag.ToString();
            
            btn.Text = " ";
            btn.BackColor = Color.Red;

            if (btn.BackColor != Color.Red)
            {
                MessageBox.Show("Coche aparcado correctamente en P " + plaza);
            }
            else 
            {
                MessageBox.Show("Plaza ocupada, elige otra");
            }
            
        }
    }
}
