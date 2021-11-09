using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9__Windows_Form_Genel_Uygulama
{
    public partial class ISIMARAMA : Form
    {
        public ISIMARAMA()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtekle.Text.Trim() != string.Empty)
            {
                string eklenenisim = txtekle.Text.Trim();
                lbcalisan.Items.Add(eklenenisim);
                kontrol = true;
                txtekle.Clear();
                txtekle.Focus();
            }
            else
            {
                txtekle.Focus();
                MessageBox.Show("LÜTFEN BİR İSİM GİRİNİZ.");
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int secilensayisi = lbcalisan.SelectedItems.Count;
            for (int i = 0; i < secilensayisi; i++)
            {
                string secilen = (string)lbcalisan.SelectedItems[0];
                lbcalisan.Items.Remove(secilen);
            }
        }
        string[] lbyedek = new string[0];
        bool kontrol = true;
        int ydsayi = 0;
        private void txtara_KeyUp(object sender, KeyEventArgs e)
        {
            int lbsayi = lbcalisan.Items.Count;
            string aranan = txtara.Text.Trim();
            int aranansayi = aranan.Length;
            if (kontrol == true)
            {
                Array.Resize(ref lbyedek, lbsayi);
                ydsayi = lbyedek.Length;
                for (int i = 0; i < ydsayi; i++)
                {
                    lbyedek[i] = (string)lbcalisan.Items[i];
                }
            }
            kontrol = false;
            if (aranan != string.Empty)
            { 
                int sayac = 0;
                lbcalisan.Items.Clear();
                for (int i = 0; i < ydsayi; i++)
                {
                    string lbyedekitem = lbyedek[i];
                    for (int t = 0; t < aranansayi; t++)
                    {
                        if (lbyedekitem.Length > aranan.Length && lbyedekitem[t] == aranan[t])
                        {
                            sayac++;
                        }
                    }
                    if (sayac == aranansayi)
                    {   
                        lbcalisan.Items.Add(lbyedekitem);
                    }
                    sayac = 0;
                }
            }
            else
            {
                lbcalisan.Items.Clear();
                for (int i = 0; i < ydsayi; i++)
                {
                    string gecer = lbyedek[i];
                    lbcalisan.Items.Add(gecer);
                }
            }
        }
    }
}
