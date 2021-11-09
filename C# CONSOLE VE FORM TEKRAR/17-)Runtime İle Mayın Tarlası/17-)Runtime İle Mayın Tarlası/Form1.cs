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

namespace _17__Runtime_İle_Mayın_Tarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.BringToFront();
        }

        private void msyeni_Click(object sender, EventArgs e)
        {
            yeni();
        }

        void yeni()
        {
            this.Size = new Size(319, 328);
            foreach (Control item in this.Controls)
            {
                if (item is MenuStrip)
                {

                }
                else if (item.Name == "btnkolay" | item.Name == "btnorta" | item.Name == "btnzor" | item is Label)
                {
                    item.Enabled = true;
                    item.Visible = true;
                }
                else
                {
                    this.Controls.Remove(item);
                    flp = new FlowLayoutPanel();
                }
            } 
        }

        void basla()
        {
            foreach (Control item in this.Controls)
            {
                if (item is MenuStrip)
                {

                }
                else if (item.Name == "btnkolay" | item.Name == "btnorta" | item.Name == "btnzor" | item is Label)
                {
                    item.Enabled = false;
                    item.Visible = false;
                }
            }
        }

        FlowLayoutPanel flp = new FlowLayoutPanel();
        int adet = 0;
        bool kont = false;
        int[] mayinlar;
        int a = 0;

        void mayinolustur (int x)
        {
            a = 0;
            int mayinsayisi = (x * 20) / 100;
            mayinlar = new int[mayinsayisi];
            int rast = 0;
            Random rnd = new Random();
            for (int i = 0; i < mayinsayisi; i++)
            {
                rast = rnd.Next(0, x);
                if (!mayinlar.Contains(rast))
                {
                    mayinlar[i] = rast;
                }
                else
                {
                    i--;
                }
            }
        }

        void tarlaolustur(int x)
        {
            Button btn = new Button();
            btn.Left = 10;
            btn.Top = 10;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Size = new Size(25, 25);
            btn.BackColor = Color.Gray;
            flp.Left = 30;
            flp.Top = 30;
            if (mayinlar.Contains(a))
            {
                btn.Tag = true;
            }
            else
            {
                btn.Tag = false;
            }
            if (x == 1 && kont == true)
            {
                this.ClientSize = new Size(370, 370);
                flp.Size = new Size(310, 310);
                kont = false;
                this.Controls.Add(flp);
            }
            else if (x == 2 && kont == true)
            {
                this.ClientSize = new Size(523, 523);
                flp.Size = new Size(465, 465);
                kont = false;
                this.Controls.Add(flp);
            }
            else if (x == 3 && kont == true)
            {
                this.ClientSize = new Size(680, 680);
                flp.Size = new Size(650, 650);
                kont = false;
                this.Controls.Add(flp);
            }
            flp.Controls.Add(btn);
            a++;
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button bttn = (Button)sender;
            if ((bool)bttn.Tag == true)
            {
                bttn.ForeColor = Color.Yellow;
                bttn.Text = "X";
                foreach (Control item in flp.Controls)
                {
                    if ((bool)item.Tag == true)
                    {
                        item.BackColor = Color.Red;
                    }
                    else
                    {
                        item.BackColor = Color.Green;
                    }
                    item.Enabled = false;
                }
                bttn.BackColor = Color.DarkRed;
                MessageBox.Show("BOOM ! YENİLDİNİZ...");
            }
            else
            {
                bttn.BackColor = Color.Green;
            }
        }

        private void btnkolay_Click(object sender, EventArgs e)
        {
            adet = 100;
            kont = true;
            basla();
            mayinolustur(adet);
            for (int i = 0; i < adet; i++)
            {
                tarlaolustur(1);
            }
        }

        private void btnorta_Click(object sender, EventArgs e)
        {
            adet = 225;
            kont = true;
            basla();
            mayinolustur(adet);
            for (int i = 0; i < adet; i++)
            {
                tarlaolustur(2);
            }
        }

        private void btnzor_Click(object sender, EventArgs e)
        {
            adet = 400;
            kont = true;
            basla();
            mayinolustur(adet);
            for (int i = 0; i < adet; i++)
            {
                tarlaolustur(3);
            }
        }
    }
}
