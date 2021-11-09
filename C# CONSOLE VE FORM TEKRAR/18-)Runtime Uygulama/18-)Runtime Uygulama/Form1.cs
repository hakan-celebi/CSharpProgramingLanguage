using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18__Runtime_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] koyluler;
        int[] vampirler;
        int[] buyuculer;
        int[] doktorlar;

        void heroolustur(int x, int y, int z, int t, int u)
        {
            Random rnd = new Random();
            int rast = 0;
            koyluler = new int[y];
            vampirler = new int[z];
            buyuculer = new int[t];
            doktorlar = new int[u];
            for (int i = 0; i < y; i++)
            {
                Application.DoEvents();
                rast = rnd.Next(0, x);
                if (!koyluler.Contains(rast) | rast == 0)
                {
                    koyluler[i] = rast;
                }
                else
                {
                    i--;
                }
            }

            for (int i = 0; i < z; i++)
            {
                Application.DoEvents();
                rast = rnd.Next(0, x);
                if (!vampirler.Contains(rast) && !koyluler.Contains(rast) | rast == 0)
                {
                    vampirler[i] = rast;
                }
                else
                {
                    i--;
                }
            }

            for (int i = 0; i < t; i++)
            {
                Application.DoEvents();
                rast = rnd.Next(0, x);
                if (!buyuculer.Contains(rast) && !vampirler.Contains(rast) && !koyluler.Contains(rast) | rast == 0)
                {
                    buyuculer[i] = rast;
                }
                else
                {
                    i--;
                }
            }

            for (int i = 0; i < u; i++)
            {
                Application.DoEvents();
                rast = rnd.Next(0, x);
                if (!doktorlar.Contains(rast) && !buyuculer.Contains(rast) && !vampirler.Contains(rast) && !koyluler.Contains(rast) | rast == 0)
                {
                    doktorlar[i] = rast;
                }
                else
                {
                    i--;
                }
            }
        }

        void olustur(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Button btn = new Button();
                btn.Text = (i + 1).ToString();
                btn.Size = new Size(150, 120);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Margin = new Padding(20, 20, 0, 0);
                btn.ForeColor = Color.Red;
                btn.BackColor = Color.Navy;
                if (koyluler.Contains(i))
                {
                    btn.Tag = "k";
                }
                else if (vampirler.Contains(i))
                {
                    btn.Tag = "v";
                }
                else if (buyuculer.Contains(i))
                {
                    btn.Tag = "b";
                }
                else if (doktorlar.Contains(i))
                {
                    btn.Tag = "d";
                }
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tikbtn = sender as Button;
            if ((string)tikbtn.Tag == "k")
            {
                tikbtn.Enabled = false;
                MessageBox.Show("KÖYLÜSÜN BOL ŞANS...");
            }
            else if ((string)tikbtn.Tag == "v")
            {
                tikbtn.Enabled = false;
                MessageBox.Show("VAMPİRSİN BOL ŞANS...");
            }
            else if ((string)tikbtn.Tag == "b")
            {
                tikbtn.Enabled = false;
                MessageBox.Show("BÜYÜCÜSÜN BOL ŞANS...");
            }
            else if ((string)tikbtn.Tag == "d")
            {
                tikbtn.Enabled = false;
                MessageBox.Show("DOKTORSUN BOL ŞANS...");
            }
        }

        private void btnbasla_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int koylu = (int)nudkoylu.Value;
            int vampir = (int)nudvampir.Value;
            int buyucu = (int)nudbuyucu.Value;
            int doktor = (int)nuddoktor.Value;
            int toplamkisi = koylu + vampir + buyucu + doktor;
            heroolustur(toplamkisi, koylu, vampir, buyucu, doktor);
            olustur(toplamkisi);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
