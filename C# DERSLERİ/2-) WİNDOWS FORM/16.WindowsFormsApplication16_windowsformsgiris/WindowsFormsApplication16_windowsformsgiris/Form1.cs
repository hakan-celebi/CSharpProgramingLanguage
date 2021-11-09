using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16_windowsformsgiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnİşlem_MouseHover(object sender, EventArgs e)
        {
            btnİşlem.BackColor = Color.DarkOrange;
        }

        private void btnİşlem_MouseLeave(object sender, EventArgs e)
        {
            btnİşlem.BackColor = Color.White;
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {

        }
    }
}
