using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16__Runtime_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cms1on_Click(object sender, EventArgs e)
        {
            sil();
            for (int i = 0; i < 10 * 10; i++)
            {
                butonekleme(10);
            }
            boyut(10, 10);
        }

        private void cms120_Click(object sender, EventArgs e)
        {
            sil();
            for (int i = 0; i < 10 * 20; i++)
            {
                butonekleme(10);
            }
            boyut(10, 20);
        }

        private void cms130_Click(object sender, EventArgs e)
        {
            sil();
            for (int i = 0; i < 10 * 30; i++)
            {
                butonekleme(10);
            }
            boyut(10, 30);
        }

        private void cms210_Click(object sender, EventArgs e)
        {
            sil();
            for (int i = 0; i < 20 * 10; i++)
            {
                butonekleme(20);
            }
            boyut(20, 10);
        }

        private void csm220_Click(object sender, EventArgs e)
        {
            sil();
            for (int i = 0; i < 20 * 20; i++)
            {
                butonekleme(20);
            }
            boyut(20, 20);
        }

        private void csm230_Click(object sender, EventArgs e)
        {
            sil();
            for (int i = 0; i < 20 * 30; i++)
            {
                butonekleme(20);
            }
            boyut(20, 30);
        }

        int btnleft = 10;
        int btntop = 10;
        int sayac = 0;
        int btnisim = 0;
        int formwidth = 0;
        int formheight = 0;

        void butonekleme(int a)
        {
            Button btn = new Button();
            btnisim++;
            sayac++;
            btn.Width = 60;
            btn.Height = 30;
            btn.Left = btnleft;
            btnleft += btn.Width + 10;
            btn.Top = btntop;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.Orange;
            btn.Text = btnisim.ToString();
            this.Controls.Add(btn);
            if (sayac == a)
            {
                btntop += btn.Height + 2;
                btnleft = 10;
                sayac = 0;
                //this.Width = btn.Right + 50;
                //this.Height = btn.Bottom + 50;
            }
        }

        int sdboyut = 0;

        void sil()
        {
            btnleft = 10;
            btntop = 10;
            sayac = 0;
            btnisim = 0;
            formwidth = 0;
            formheight = 0;
            /*foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    this.Controls.Remove(item);
                }
            }*/
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    sdboyut++;
                }
            }
            Control[] silinecekler = new Control[sdboyut];
            int z = 0;
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    silinecekler[z] = item;
                    z++;
                }
            }
            foreach (Control item in silinecekler)
            {
                if (item is Button)
                {
                    this.Controls.Remove(item);
                }
            }
        }

        void boyut(int a, int b)
        {
            int sayacc = 0;
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    sayacc++;
                    formwidth += item.Width + 12;
                }
                if (sayacc == a)
                {
                    sayacc = 0;
                    break;
                }
            }
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    sayacc++;
                    formheight += item.Height + 7;
                }
                if (sayacc == b)
                {
                    sayacc = 0;
                    break;
                }
            }
            this.Width = formwidth;
            this.Height = formheight;
        }
    }
}
