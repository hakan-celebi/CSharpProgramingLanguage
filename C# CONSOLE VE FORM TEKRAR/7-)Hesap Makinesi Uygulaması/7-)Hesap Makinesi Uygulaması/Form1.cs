using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7__Hesap_Makinesi_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            decimal sonuc = 0;
            if (cbislem.Text == null)
            {
                MessageBox.Show("LÜTFEN BİR İŞLEM SEÇİNİZ");
            }
            else
            {
                decimal ilksayi = int.Parse(txtsayi1.Text);
                decimal ikincisayi = int.Parse(txtsayi2.Text);
                switch (cbislem.Text)
                {
                    case "+":
                        sonuc = ilksayi + ikincisayi;
                        break;
                    case "-":
                        sonuc = ilksayi - ikincisayi;
                        break;
                    case "*":
                        sonuc = ilksayi * ikincisayi;
                        break;
                    case "/":
                        sonuc = ilksayi / ikincisayi;
                        break;
                }
                txtsonuc.Text = Convert.ToString(sonuc);
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbislem.SelectedIndex = 0;
        }
    }
}
