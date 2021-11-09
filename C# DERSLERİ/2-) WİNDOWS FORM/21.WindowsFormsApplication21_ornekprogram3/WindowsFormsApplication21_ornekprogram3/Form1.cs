using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication21_ornekprogram3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            txtsonuc.ResetText();
            decimal sayi1;
            decimal sayi2;
            if (decimal.TryParse(txtsayi1.Text, out sayi1) && decimal.TryParse(txtsayi2.Text, out sayi2))
            {
                if (radtoplama.Checked == true)
                {
                    if (sayi1 > sayi2)
                    {
                        decimal sonuc = sayi1 + sayi2;
                        txtsonuc.AppendText(sonuc.ToString());
                    }
                    else
                    {
                        decimal sonuc = sayi2 + sayi1;
                        txtsonuc.AppendText(sonuc.ToString());
                    }
                }
                else if (radcikarma.Checked == true)
                {
                    if (sayi1 > sayi2)
                    {
                        decimal sonuc = sayi1 - sayi2;
                        txtsonuc.AppendText(sonuc.ToString());
                    }
                    else
                    {
                        decimal sonuc = sayi2 - sayi1;
                        txtsonuc.AppendText(sonuc.ToString());
                    }
                }
                else if (radcarpma.Checked == true)
                {
                    if (sayi1 > sayi2)
                    {
                        decimal sonuc = sayi1 * sayi2;
                        txtsonuc.AppendText(sonuc.ToString());
                    }
                    else
                    {
                        decimal sonuc = sayi2 * sayi1;
                        txtsonuc.AppendText(sonuc.ToString());
                    }
                }
                else if (radbolme.Checked == true)
                {
                    if (sayi1 > sayi2)
                    {
                        decimal sonuc = sayi1 / sayi2;
                        txtsonuc.AppendText(sonuc.ToString());
                    }
                    else
                    {
                        decimal sonuc = sayi2 / sayi1;
                        txtsonuc.AppendText(sonuc.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("ADAMI DELİ ETME LAN SAYI GİR !!!");
            }
        }
    }
}
