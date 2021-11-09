using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11__Araba_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrenk_Click(object sender, EventArgs e)
        {
            DialogResult gelen = cdrenk.ShowDialog();
            if (gelen == DialogResult.OK)
            {
                btnrenk.BackColor = cdrenk.Color;
            }
        }

        private void cbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbmarka.Text.Trim())
            {
                case "PAR":
                    cbmodel.Items.Clear();
                    cbmodel.Items.Add("PAMLOK");
                    cbmodel.Items.Add("TTOAR");
                    cbmodel.Items.Add("XERYAH");
                    break;
                case "BMW":
                    cbmodel.Items.Clear();
                    cbmodel.Items.Add("SEDAN");
                    cbmodel.Items.Add("TOURİNG");
                    cbmodel.Items.Add("GRAN TURİSİMO");
                    break;
                case "AUDİ":
                    cbmodel.Items.Clear();
                    cbmodel.Items.Add("A1");
                    cbmodel.Items.Add("A2");
                    cbmodel.Items.Add("A3");
                    cbmodel.Items.Add("A4");
                    cbmodel.Items.Add("A5");
                    cbmodel.Items.Add("A6");
                    cbmodel.Items.Add("A7");
                    cbmodel.Items.Add("A8");
                    cbmodel.Items.Add("Q2");
                    cbmodel.Items.Add("Q3");
                    cbmodel.Items.Add("Q5");
                    cbmodel.Items.Add("Q7");
                    cbmodel.Items.Add("TT");
                    cbmodel.Items.Add("R8");
                    break;
                case "MASERATİ":
                    cbmodel.Items.Clear();
                    cbmodel.Items.Add("GHİBLİ");
                    cbmodel.Items.Add("LEVANTE");
                    cbmodel.Items.Add("QUATTROPORTE");
                    break;
                case "SUBARRU":
                    cbmodel.Items.Clear();
                    cbmodel.Items.Add("LEVORG");
                    cbmodel.Items.Add("FORESTER");
                    cbmodel.Items.Add("OUTBACK");
                    break;
            }
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            if (cbmarka.Text != string.Empty && cbmodel.Text != string.Empty && cbyakit.Text != string.Empty && cbkasa.Text != string.Empty && cbvites.Text != string.Empty && cbmotor.Text != string.Empty)
            {
                string marka = cbmarka.Text;
                string model = cbmodel.Text;
                string yakit = cbyakit.Text;
                string kasa = cbkasa.Text;
                string vites = cbvites.Text;
                string motor = cbmotor.Text;
                Color renk = btnrenk.BackColor;
                string yil = dtpyil.Text;
                ListViewItem lvi = new ListViewItem();
                lvi.UseItemStyleForSubItems = false;
                lvi.Text = marka;
                lvi.SubItems.Add(model);
                lvi.SubItems.Add(yakit);
                lvi.SubItems.Add(kasa);
                lvi.SubItems.Add(vites);
                lvi.SubItems.Add(motor);
                lvi.SubItems.Add("");
                lvi.SubItems[6].BackColor = renk;
                lvi.SubItems.Add(yil.ToString());
                lvsiparis.Items.Add(lvi);
                foreach (Control item in this.Controls)
                {
                    if (item is ComboBox)
                    {
                        ((ComboBox)item).SelectedIndex = -1;
                    }
                    else if (item is Button)
                    {
                        if (item.Name == "btnrenk")
                        {
                            item.BackColor = Color.White;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN GEREKLİ ALANLARI DOLDURUNUZ...");
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            if (lvsiparis.SelectedItems.Count > 0)
            {
                int secilen = lvsiparis.SelectedItems.Count;
                for (int i = 0; i < secilen; i++)
                {
                    lvsiparis.Items.Remove(lvsiparis.SelectedItems[0]);
                }
            }
        }

        ListViewItem secilen;
        bool kontrol = false;

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            if (lvsiparis.SelectedItems.Count == 1)
            {
                secilen = lvsiparis.SelectedItems[0];
                cbmarka.Text = secilen.Text;
                cbmodel.Text = secilen.SubItems[1].Text;
                cbyakit.Text = secilen.SubItems[2].Text;
                cbkasa.Text = secilen.SubItems[3].Text;
                cbvites.Text = secilen.SubItems[4].Text;
                cbmotor.Text = secilen.SubItems[5].Text;
                btnrenk.BackColor = secilen.SubItems[6].BackColor;
                dtpyil.Value = Convert.ToDateTime(string.Format("01.01.{0}", secilen.SubItems[7].Text));
                kontrol = true;
            }
            else
            {
                MessageBox.Show("HİÇ BİR KAYIT SEÇMEDİNİZ VEYA BİRDEN FAZLA KAYIT SEÇTİNİZ...");
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                secilen.Text = cbmarka.Text;
                secilen.SubItems[1].Text = cbmodel.Text;
                secilen.SubItems[2].Text = cbyakit.Text;
                secilen.SubItems[3].Text = cbkasa.Text;
                secilen.SubItems[4].Text = cbvites.Text;
                secilen.SubItems[5].Text = cbmotor.Text;
                secilen.SubItems[6].BackColor = btnrenk.BackColor;
                secilen.SubItems[7].Text = dtpyil.Text;
                foreach (Control item in this.Controls)
                {
                    if (item is ComboBox)
                    {
                        ((ComboBox)item).SelectedIndex = -1;
                    }
                    else if (item is Button)
                    {
                        if (item.Name == "btnrenk")
                        {
                            item.BackColor = Color.White;
                        }
                    }
                }
                kontrol = false;
            } 
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvsiparis.SelectedItems.Count > 0)
            {
                int secilen = lvsiparis.SelectedItems.Count;
                for (int i = 0; i < secilen; i++)
                {
                    lvsiparis.Items.Remove(lvsiparis.SelectedItems[0]);
                }
            }
        }

        private void dÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvsiparis.SelectedItems.Count == 1)
            {
                secilen = lvsiparis.SelectedItems[0];
                cbmarka.Text = secilen.Text;
                cbmodel.Text = secilen.SubItems[1].Text;
                cbyakit.Text = secilen.SubItems[2].Text;
                cbkasa.Text = secilen.SubItems[3].Text;
                cbvites.Text = secilen.SubItems[4].Text;
                cbmotor.Text = secilen.SubItems[5].Text;
                btnrenk.BackColor = secilen.SubItems[6].BackColor;
                dtpyil.Value = Convert.ToDateTime(string.Format("01.01.{0}", secilen.SubItems[7].Text));
                kontrol = true;
            }
            else
            {
                MessageBox.Show("HİÇ BİR KAYIT SEÇMEDİNİZ VEYA BİRDEN FAZLA KAYIT SEÇTİNİZ...");
            }
        }
    }
}
