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

namespace WindowsFormsApplication28_timer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int dakika = 525, saniye = 60, salise = 90;
        string dakikas, saniyes, salises;
        string kullaniciadi = "legenderygame47", parola = "qwe123rty654";
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == kullaniciadi && txtparola.Text == parola)
            {
                timer1.Stop();
                lblkalan.Text = "00.00.00";
                MessageBox.Show("TEBRİKLER REAL WORLD REAL LİFE HESABINIZ AKTİF EDİLMİŞTİR...");
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE YANLIŞTIR TEKRAR DENEYİNİZ...");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise--;
            if (salise == 0)
            {
                saniye--;
                salise = 90;
            }
            if (saniye == 0)
            {
                dakika--;
                saniye = 60;
            }
            if (dakika < 10)
            {
                dakikas = "0" + dakika + ":";
            }
            else
            {
                dakikas = dakika + ":";
            }
            if (saniye < 10)
            {
                saniyes = "0" + saniye + ":";
            }
            else
            {
                saniyes = saniye + ":";
            }
            if (salise < 10)
            {
                salises = "0" + salise;
            }
            else
            {
                salises = salise.ToString();
            }
            lblkalan.Text = dakikas + saniyes + salises;
        }
        //Application.DoEvents() : Programa dur ve başka bir işlem varmı kontrol et demeye yarıyor.
        //Thread.Sleep(); : Uygulamayı verilen saniye kadar uyutmayı bekletmeyi yarar.
        //lblsaniye.Text=saniye<10?string.Format("0{0}",saniye):saniye.ToString(); bu işleme turnery if denir.

    }
}
