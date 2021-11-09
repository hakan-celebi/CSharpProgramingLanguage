using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20__Hata_Türleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            if (txtsayi1.Text.Trim() != string.Empty && txtsayi2.Text.Trim() != string.Empty)
            {
                long sonuc = 0;
                try
                {
                    long sayi1 = long.Parse(txtsayi1.Text);
                    long sayi2 = long.Parse(txtsayi2.Text);
                    sonuc = sayi1 + sayi2;
                    lblsonuc.ForeColor = Color.Black;
                    lblsonuc.Text = string.Format("SONUÇ: {0}", sonuc);
                    txtsayi1.Text = string.Empty;
                    txtsayi2.Text = string.Empty;
                    txtsayi1.Focus();
                }
                catch (FormatException ex)
                {
                    sonuc = 0;
                    MessageBox.Show(ex.Message + " YANLIZCA SAYI GİRİNİZ...");
                    return;
                }
                catch (OverflowException ex)
                {
                    sonuc = 0;
                    MessageBox.Show(ex + " LÜTFEN DAHA KÜÇÜK BİR SAYI GİRİNİZ...");
                    return;
                }
                finally
                {
                    if (sonuc == 0)
                    {
                        lblsonuc.ForeColor = Color.Red;
                        lblsonuc.Text = "SONUÇ: ERROR";
                    }
                }
            }
            else
            {
                MessageBox.Show("GEREKLİ ALANLARI DOLDURUN VE SAYI GİRİN...");
            }
        }
    }
}
