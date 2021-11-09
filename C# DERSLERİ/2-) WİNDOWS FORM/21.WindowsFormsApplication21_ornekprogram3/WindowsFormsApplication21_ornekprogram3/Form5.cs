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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            txtsonuc.ResetText();
            string isim = "";
            decimal no = 0;
            decimal gun = 0;
            decimal mesai = 0;
            decimal saatucret = 0;  
            if (string.IsNullOrEmpty(txtisim.Text) == false && string.IsNullOrEmpty(txtno.Text) == false && string.IsNullOrEmpty(txtgun.Text) == false && string.IsNullOrEmpty(txtsaatucret.Text) == false)
            {
                if (string.IsNullOrEmpty(txtsaat.Text) == false)
                {
                    mesai = Convert.ToDecimal(txtsaat.Text) + Convert.ToDecimal(txtsaat.Text) / 2;
                }
                isim = txtisim.Text;
                no = Convert.ToDecimal(txtno.Text);
                gun = Convert.ToDecimal(txtgun.Text);
                saatucret = Convert.ToDecimal(txtsaatucret.Text);
                decimal gunluk = 8 * saatucret;
                decimal gunsonuc = gun * gunluk;
                decimal mesaiucret = mesai * saatucret;
                decimal messonuc = mesaiucret + gunsonuc;
                if (string.IsNullOrEmpty(txtsaat.Text))
                {
                    listsonuc.Items.Add(string.Format("{0}-{1} : {2} TL", no, isim, gunsonuc));
                    txtsonuc.AppendText(gunsonuc.ToString());
                }
                else
                {
                    listsonuc.Items.Add(string.Format("{0}-{1} : {2} TL", no, isim, messonuc));
                    txtsonuc.AppendText(messonuc.ToString());
                }
                txtno.ResetText();
                txtisim.ResetText();
                txtgun.ResetText();
                txtsaat.ResetText();
                txtsaatucret.ResetText();
                txtisim.Focus();
            }
            else
            {
                MessageBox.Show("LÜTFEN DEĞERLERİ KONTROL EDİNİZ...");
                listsonuc.Items.Remove(listsonuc.Items.Count -1);
            }    
        }

        private void btnodendi_Click(object sender, EventArgs e)
        {
            string gecici = listsonuc.SelectedItem.ToString();
            listsonuc.Items.Remove(listsonuc.SelectedItem);
            listsonuc.Items.Add(gecici + " ÖDENDİ");
        }

        private void btnaysonu_Click(object sender, EventArgs e)
        {
            listsonuc.Items.Clear();
        }
    }
}
