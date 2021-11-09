using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication35_sinamaotmsynben
{
    public partial class Form1 : Form
    {
        int bilet = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnalnakit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnalkart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nutnakitbilet_ValueChanged(object sender, EventArgs e)
        {
            int tutar = (int)nutnakitbilet.Value * 12;
            lblnakittutar.Text = tutar.ToString() + "$";
        }

        private void nudkartbilet_ValueChanged(object sender, EventArgs e)
        {
            int tutar = (int)nudkartbilet.Value * 12;
            lblkarttutar.Text = tutar.ToString() + "C$";
        }
    }
}
