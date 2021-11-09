using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication20_listbox_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string isim = txtgir.Text;
            if (lstyer.Items.Contains(isim) == true)
            {
                MessageBox.Show(string.Format("{0} İsmi Listede Bulunmaktadır Lütfen Başka Bir İsim Giriniz !",isim));
            }
            else
            {
                if (txtgir.Text.Trim() != "")
                {
                    //lstyer.Items.Add(Convert.ToString(lstyer.Items.Count + 1) + "-" + isim);
                    lstyer.Items.Add(isim);
                    txtgir.ResetText();
                }
                else
                {
                    MessageBox.Show("LÜTFEN İSİM GİRİNİZ !");
                } 
            }
            txtgir.Focus();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("BU İSMİ SİLMEK İSTEDİĞİNİZDEN EMİNMİSİNİZ ?", "EMİNMİSİNİZ ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                string[] silinen = new string[lstyer.SelectedItems.Count];
                for (int i = 0; i < lstyer.SelectedItems.Count; i++)
                {
                    silinen[i] = (string)lstyer.SelectedItems[i];
                }
                foreach (var item in silinen)
                {
                    lstyer.Items.Remove(item);
                }
            }
            else
            {

            }
        }

        private void lstyer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                {
                    string[] silinen = new string[lstyer.SelectedItems.Count];
                    for (int i = 0; i < silinen.Length; i++)
                    {
                        silinen[i] = (string)lstyer.SelectedItems[i];
                    }
                    foreach (var item in silinen)
                    {
                        lstyer.Items.Remove(item);
                    }
                }
            }
        }

        private void btnkaristir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstyer.Items.Count; i++)
            {
                string gecici = "";
                Random rnd = new Random();
                int rast = rnd.Next(0, lstyer.Items.Count);
                gecici = (string)lstyer.Items[i];
                lstyer.Items[i] = lstyer.Items[rast];
                lstyer.Items[rast] = gecici;
            }
        }
    }
}
