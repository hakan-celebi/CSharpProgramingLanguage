using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13__Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        int saat = 0;
        int dakika = 0;
        int saniye = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dakika == 59)
            {
                saat++;
                if (saat < 10)
                {
                    lblsaat.Text = string.Format("0{0} :", saat.ToString());
                }
                else
                {
                    lblsaat.Text = string.Format("{0} :", saat.ToString());
                }
                dakika = 0; 
            }
            if (saniye == 59)
            {
                if (dakika < 10)
                {
                    lbldakika.Text = string.Format("0{0} :", dakika.ToString());
                }
                else
                {
                    lbldakika.Text = string.Format("{0} :", dakika.ToString());
                }
                dakika++;
                saniye = 0;
            }  
            if (saniye < 10)
            {
                lblsaniye.Text = string.Format("0{0}",saniye.ToString());
            }
            else
            {
                lblsaniye.Text = saniye.ToString();
            }
            saniye++;
        }

        private void btndurdur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnsifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            saat = 0;
            saniye = 0;
            dakika = 0;
            lblsaat.Text = "00 :";
            lbldakika.Text = "00 :";
            lblsaniye.Text = "00";
        }
    }
}
