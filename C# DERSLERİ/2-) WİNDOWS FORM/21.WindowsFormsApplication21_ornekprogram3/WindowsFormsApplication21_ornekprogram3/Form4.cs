using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication21_ornekprogram3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = txtisim.Text;
            string soyisim = txtsoyisim.Text;
            decimal kackere = numsayi.Value;
            do
            {
                if (kackere == 0)
                {

                }
                else
                {
                    lstisim.Items.Add(isim + soyisim);
                    kackere--;
                } 
            } while (kackere > 0);
            btngonder.Focus();
            txtisim.ResetText();
            txtsoyisim.ResetText();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lstisim.Items.Clear();
        }
    }
}
