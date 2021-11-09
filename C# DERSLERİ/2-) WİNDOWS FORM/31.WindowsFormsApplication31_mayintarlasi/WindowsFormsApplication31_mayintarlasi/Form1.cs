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

namespace WindowsFormsApplication31_mayintarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int boyut = 50;
        int baslikboyut = 0;
        void icerikolustur(int kactane)
        {
            flowLayoutPanel1.Controls.Clear();
            int mayin = kactane / 5;
            int[] mayinlar = new int[mayin];
            Random rastgele = new Random();
            for (int i = 0; i < mayin; i++)
            {
                int secilen = rastgele.Next(0, kactane);
                if (!mayinlar.Contains(secilen))
                {
                    mayinlar[i] = secilen;
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < kactane; i++)
            {
                Button btn = new Button();
                btn.Text = (i + 3).ToString();
                btn.Width = 20;
                btn.Height = 20;
                btn.ForeColor = Color.GhostWhite;
                btn.BackColor = Color.GhostWhite;
                if (mayinlar.Contains(i))
                {
                    btn.Tag = true;
                }
                else
                {
                    btn.Tag = false;
                }

                btn.Click += Btn_Click;
                btn.Margin = new Padding(5, 5, 0, 0);
                flowLayoutPanel1.Width = (boyut * 5) + (4 * 5);
                flowLayoutPanel1.Height = (boyut * 8);
                this.Width = flowLayoutPanel1.Width + 50;
                this.Height = flowLayoutPanel1.Height;
                label1.Left = flowLayoutPanel1.Left + baslikboyut;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklananbtn = sender as Button;
            if ((bool)tiklananbtn.Tag == true)
            {
                int sayac = 0;
                tiklananbtn.BackColor = Color.PaleVioletRed;
                do
                {
                    sayac++;
                } while (sayac < 80000000);
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    if ((bool)item.Tag == true)
                    {
                        item.BackColor = Color.PaleVioletRed;
                    }
                    else
                    {
                        item.BackColor = Color.DarkSeaGreen;
                        item.Enabled = false;
                    }
                }
            }
            else
            {
                tiklananbtn.BackColor = Color.ForestGreen;
            }
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boyut = 40;
            baslikboyut = 0;
            icerikolustur(64);
            this.Height = flowLayoutPanel1.Height + 30;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boyut = 55;
            baslikboyut = 35;
            icerikolustur(121);
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boyut = 65;
            baslikboyut = 55;
            icerikolustur(169);
        }

        private void ınsaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boyut = 75;
            baslikboyut = 85;
            icerikolustur(225);
        }
    }
}
