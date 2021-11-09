using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14__Timer_İle_At_Yarışı_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbasla_Click(object sender, EventArgs e)
        {
            btnbasla.ForeColor = Color.OrangeRed;
            atdurum(true);
            timer1.Start();
        }

        void atdurum(bool durum)
        {
            HAKAN.Enabled = APO.Enabled = EMRE.Enabled = BATUS.Enabled = durum;
        }

        void atdurum(bool durum , PictureBox kazanan)
        {
            HAKAN.Enabled = APO.Enabled = EMRE.Enabled = BATUS.Enabled = durum;
            kazanan.Enabled = true;
        }

        void kazankontrol (PictureBox at)
        {
            if (at.Right >= label1.Left)
            {
                timer1.Stop();
                atdurum(false, at);
                MessageBox.Show(string.Format("{0} KAZANDI",at.Name));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atdurum(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            HAKAN.Left += rnd.Next(3, 15);
            APO.Left += rnd.Next(3, 15);
            EMRE.Left += rnd.Next(3, 15);
            BATUS.Left += rnd.Next(3, 15);
            kazankontrol(HAKAN);
            kazankontrol(APO);
            kazankontrol(EMRE);
            kazankontrol(BATUS);
        }
    }
}
