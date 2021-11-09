using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8__Listeleyiciler_A_Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtisim.Text.Trim() != string.Empty)
            {
                string isim = string.Format("{0}-){1}",lbogrenciler.Items.Count+1,txtisim.Text.Trim());
                lbogrenciler.Items.Add(isim);
                txtisim.Clear();
                txtisim.Focus();
            }
            else
            {
                MessageBox.Show("LÜTFEN BİR ÖĞRENCİ İSMİ GİRİNİZ...");
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //Silmek İçin İlk Yöntem Sil Butonuna Tıklandığı Anda İkinci Yöntem Delete Tuşuna Basıldığı Anda
            object silinecek;
            int secilensayisi = lbogrenciler.SelectedItems.Count;
            for (int i = 0; i < secilensayisi; i++)
            {
                silinecek = lbogrenciler.SelectedItems[0];
                lbogrenciler.Items.Remove(silinecek);
            }
        }

        private void lbogrenciler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int silineceksayisi = lbogrenciler.SelectedItems.Count;
                string[] silinecekler = new string[silineceksayisi];
                for (int i = 0; i < silineceksayisi; i++)
                {
                    silinecekler[i] = (string)lbogrenciler.SelectedItems[i];
                }
                foreach (string item in silinecekler)
                {
                    lbogrenciler.Items.Remove(item);
                }
            }
        }

        private void btnkaristir_Click(object sender, EventArgs e)
        {
            int lbelemansayisi = lbogrenciler.Items.Count;
            int rastgele;
            string gecici;
            Random rnd = new Random();
            for (int i = 0; i < lbelemansayisi; i++)
            {
                rastgele = rnd.Next(0,lbelemansayisi);
                gecici = (string)lbogrenciler.Items[i];
                lbogrenciler.Items[i] = lbogrenciler.Items[rastgele];
                lbogrenciler.Items[rastgele] = gecici;
            }
        }
    }
}
