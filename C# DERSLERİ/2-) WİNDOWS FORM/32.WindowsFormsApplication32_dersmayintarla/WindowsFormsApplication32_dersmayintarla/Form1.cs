using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication32_dersmayintarla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void mayinolusturma(int saga, int alta)
        {
            flowLayoutPanel1.Controls.Clear();
            int mayin = (saga * alta) / 10;
            int[] mayindizi = new int[mayin];
            Random rnd = new Random();
            for (int i = 0; i < mayindizi.Length; i++)
            {
                int secilen = rnd.Next(0, saga * alta);
                if (mayindizi.Contains(secilen) != true)
                {
                    mayindizi[i] = secilen;
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < saga * alta; i++)
            {
                Button alan = new Button();
                alan.Width = alan.Height = 25;
                alan.Text = (i + 1).ToString();
                alan.ForeColor = Color.LightGray;
                alan.BackColor = Color.LightGray;
                if (mayindizi.Contains(i))
                {
                    alan.Tag = true;
                }
                else
                {
                    alan.Tag = false;
                }
                alan.Margin = new Padding(5,5,0,0);
                alan.Click += Alan_Click;
                flowLayoutPanel1.Width = (saga * 25) + (5 * saga);
                flowLayoutPanel1.Height = (alta * 25) + (5 * alta);
                this.Width = flowLayoutPanel1.Width + 120;
                this.Height = flowLayoutPanel1.Height + 150;
                flowLayoutPanel1.Controls.Add(alan);
            }
        }

        private void Alan_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            if ((bool)tiklanan.Tag == true)
            {
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    Button btn = item as Button;
                    if ((bool)btn.Tag == true)
                    {
                        btn.BackColor = Color.Red;
                    }
                    else
                    {
                        btn.BackColor = Color.LightGreen;
                    }
                }
            }
            else
            {
                tiklanan.BackColor = Color.Green;
            }
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinolusturma(10, 10);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinolusturma(15, 15);
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinolusturma(20, 20);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
