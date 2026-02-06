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
    public partial class Form2 : Form
    {

        public Sala[] cine;
        public Form2()
        {
            InitializeComponent();
            cine = new Sala[4];
        }

        private void cONFIGURARSALAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(cine);
            f1.MdiParent = this;
            f1.Show();
            
        }

        private void vENDERENTRADAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(cine);
            f3.MdiParent = this;
            f3.Show();
        }
    }
}
