using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication29_atyarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            AtDurumDegistirme(true);
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtDurumDegistirme(false);
        }

        void AtDurumDegistirme(bool durum, PictureBox birinci)
        {
            YAĞIZ.Enabled = POYRAZ.Enabled = RÜZGAR.Enabled = GÖLGE.Enabled = durum;
            birinci.Enabled = true;
        }

        void AtDurumDegistirme(bool durum)
        {
            YAĞIZ.Enabled = POYRAZ.Enabled = RÜZGAR.Enabled = GÖLGE.Enabled = durum;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rndilerleme = new Random();
            Random atlar = new Random();
            int yagizilk = atlar.Next(1, 10);
            int yagizson = atlar.Next(10, 25);
            int poyrazilk = atlar.Next(1, 10);
            int poyrazson = atlar.Next(10, 25);
            int ruzgarilk = atlar.Next(1, 10);
            int ruzgarson = atlar.Next(10, 25);
            int golgeilk = atlar.Next(1, 10);
            int golgeson = atlar.Next(10, 25);
            int bir = rndilerleme.Next(yagizilk, yagizson);
            int iki = rndilerleme.Next(poyrazilk, poyrazson);
            int uc = rndilerleme.Next(ruzgarilk, ruzgarson);
            int dort = rndilerleme.Next(golgeilk, golgeson);
            YAĞIZ.Left += bir;
            lblyagiz.Left += bir;
            POYRAZ.Left += iki;
            lblpoyraz.Left += iki;
            RÜZGAR.Left += uc;
            lblruzgar.Left += uc;
            GÖLGE.Left += dort;
            lblgolge.Left += dort;
            kazanan(YAĞIZ);
            kazanan(POYRAZ);
            kazanan(RÜZGAR);
            kazanan(GÖLGE);
        }
        void kazanan(PictureBox kazananat)
        {
            if (kazananat.Right - 5 >= label1.Left)
            {
                timer1.Stop();
                AtDurumDegistirme(false, kazananat);
                
                MessageBox.Show(kazananat.Name + " BİRİNCİLİĞİ ALDI");
            }
        }
    }
}
