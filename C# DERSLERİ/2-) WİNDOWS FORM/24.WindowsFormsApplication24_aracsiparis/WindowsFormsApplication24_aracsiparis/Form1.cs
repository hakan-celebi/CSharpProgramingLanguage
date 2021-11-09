using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication24_aracsiparis
{
    public partial class Form1 : Form
    {
        /* is değişkeni item combobox mı diye sormasını sağlar. Eğer combobox ise true değeri gelir değil ise false gelir.
         * Gelen item elemanı şu tip mi diye doğrulamak için is kullanılır.
         * Bir değişkeni değerine göre sorgulamak için ==kullanılırkentipinegöresorgulamakiçiiskullanılır.
         * Item tanımlanırken Control kullanılır çünkü Controlkendinehasözellikleridevardırfakatayn özellikler vardır label veya başkabirşeygeldiğizamanbütüntiplerialabiliyor.
         * Return : Return komuduna gelindikten sonra Altındaki kodları çalıştırmaz.
         *
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrenk_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                btnrenk.BackColor = colorDialog1.Color;
            }
        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbmarka.Text)
            {
                case "Pambly Cartin":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("CORTA RESAULT");
                    cmbmodel.Items.Add("PERTY MASRET");
                    cmbmodel.Items.Add("GURTİN TREND");
                    cmbmodel.Items.Add("MAXERZENT");
                    break;
                case "Alfa Romeo":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("GIULIA QUADRIFOGLIO");
                    cmbmodel.Items.Add("STELVIO");
                    cmbmodel.Items.Add("STELVIO QUADRIFOGLIO");
                    cmbmodel.Items.Add("4C COUPE");
                    cmbmodel.Items.Add("4C SPIDER");
                    break;
                case "Aston Martin":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("VANQUISH S ULTIMATE SUPER GT");
                    cmbmodel.Items.Add("VANQUISH VOLANTE ULTIMATE VOLANTE");
                    cmbmodel.Items.Add("DB9 GT DEFINITION OF AN ICON");
                    cmbmodel.Items.Add("VANTAGE GT8 RACE - PROVEN V8");
                    cmbmodel.Items.Add("ASTON MARTIN VULCAN INTENSE PERFORMANCE");
                    cmbmodel.Items.Add("DB11 A DESIGN EVOLUTION");
                    break;
                case "Audi":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("A7");
                    cmbmodel.Items.Add("A8");
                    cmbmodel.Items.Add("Q7");
                    break;
                case "Bentley":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("GT Supersports");
                    cmbmodel.Items.Add("GT Speed");
                    break;
                case "BMW":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("M4 Coupé");
                    cmbmodel.Items.Add("M4 Cabrio");
                    cmbmodel.Items.Add("740e plug-in hybrid");
                    cmbmodel.Items.Add("X6 M");
                    cmbmodel.Items.Add("i8");
                    cmbmodel.Items.Add("Gran Coupé");
                    cmbmodel.Items.Add("520 İ");
                    cmbmodel.Items.Add("418 İ");
                    cmbmodel.Items.Add("M6 Coupé");
                    break;
                case "Bugatti":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("VEYRON");
                    cmbmodel.Items.Add("BRAND");
                    break;
                case "Buick":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    break;
                case "Chevrolet":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Citroen":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Ferrari":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Fiat":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Ford":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Honda":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Hyundai":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Volvo":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Volkswagen":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Porsche":
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Toyota":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Renault":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    break;
                case "Nissan":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Opel":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Peugeot":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Mercedes Benz":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                case "Maserati":
                    cmbmodel.Items.Clear();
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    cmbmodel.Items.Add("");
                    break;
                default:
                    break;
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (cmbmarka.Text == string.Empty && cmbkasa.Text == string.Empty && cmbbenzin.Text == string.Empty && cmbmodel.Text == string.Empty && cmbmotortipi.Text == string.Empty && cmbvites.Text == string.Empty)
            {
                MessageBox.Show("LÜTFEN ARAC ÖZELLİKLERİNİ GİRİNİZ");
                return;
            }
            ListViewItem lvi = new ListViewItem();

            lvi.UseItemStyleForSubItems = false;
            lvi.Text = cmbmarka.Text;
            lvi.SubItems.Add(cmbmodel.Text);
            lvi.SubItems.Add(cmbvites.Text);
            lvi.SubItems.Add(cmbkasa.Text);
            lvi.SubItems.Add(cmbbenzin.Text);
            lvi.SubItems.Add(string.Empty);
            lvi.SubItems[5].BackColor = btnrenk.BackColor;
            lvi.SubItems.Add(cmbmotortipi.Text);
            lvi.SubItems.Add(dtpmodel.Text);
            listView1.Items.Add(lvi);
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                else if (item is Button)
                {
                    Button btnrenks = ((Button)item);
                    if (btnrenks.Name == "btnrenk")
                    {
                        btnrenks.BackColor = Color.White;
                    }
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.UtcNow;
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                if (listView1.SelectedItems.Count != 0)
                {
                    DialogResult sonuc = MessageBox.Show("BU ARABAYI SEPETİNİZDEN KALDIRMAK İSTEDİĞİNİZE EMİNMİSİNİZ", "EMİNMİSİNİZ ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        listView1.Items.Remove(listView1.SelectedItems[0]);
                    }
                }
                else
                {
                    MessageBox.Show("HİÇ BİR ELEMAN SEÇİLMEMİŞTİR...");
                }
            }
            else
            {
                MessageBox.Show("SEPETİNİZDE ARABA BULUNMAMAKTADIR...");
            }
        }
        ListViewItem secilen;
        private void btnduzenle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("LÜTFEN DÜZENLEMEK İSTEDİĞİNİZ ARACI SEÇİNİZ...");
                return;
            }
            secilen = listView1.SelectedItems[0];
            cmbmarka.Text = secilen.Text;
            cmbmodel.Text = secilen.SubItems[1].Text;
            cmbvites.Text = secilen.SubItems[2].Text;
            cmbkasa.Text = secilen.SubItems[3].Text;
            cmbbenzin.Text = secilen.SubItems[4].Text;
            btnrenk.BackColor = secilen.SubItems[5].BackColor;
            cmbmotortipi.Text = secilen.SubItems[6].Text;
            dtpmodel.Value = Convert.ToDateTime(string.Format("01.01.{0}", secilen.SubItems[7].Text));
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                else if (item is Button)
                {
                    Button btnrenks = ((Button)item);
                    if (btnrenks.Name == "btnrenk")
                    {
                        btnrenks.BackColor = Color.White;
                    }
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            secilen.SubItems[0].Text = cmbmarka.Text;
            secilen.SubItems[1].Text = cmbmodel.Text;
            secilen.SubItems[2].Text = cmbvites.Text;
            secilen.SubItems[3].Text = cmbkasa.Text;
            secilen.SubItems[4].Text = cmbbenzin.Text;
            secilen.SubItems[5].BackColor = btnrenk.BackColor;
            secilen.SubItems[6].Text = cmbmotortipi.Text;
            secilen.SubItems[7].Text = dtpmodel.Text;
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listView1.Items.Count != 0)
                {
                    if (listView1.SelectedItems.Count != 0)
                    {
                        DialogResult sonuc = MessageBox.Show("BU ARABAYI SEPETİNİZDEN KALDIRMAK İSTEDİĞİNİZE EMİNMİSİNİZ", "EMİNMİSİNİZ ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (sonuc == DialogResult.Yes)
                        {
                            listView1.Items.Remove(listView1.SelectedItems[0]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("HİÇ BİR ELEMAN SEÇİLMEMİŞTİR...");
                    }
                }
                else
                {
                    MessageBox.Show("SEPETİNİZDE ARABA BULUNMAMAKTADIR...");
                }
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("LÜTFEN DÜZENLEMEK İSTEDİĞİNİZ ARACI SEÇİNİZ...");
                return;
            }
            secilen = listView1.SelectedItems[0];
            cmbmarka.Text = secilen.Text;
            cmbmodel.Text = secilen.SubItems[1].Text;
            cmbvites.Text = secilen.SubItems[2].Text;
            cmbkasa.Text = secilen.SubItems[3].Text;
            cmbbenzin.Text = secilen.SubItems[4].Text;
            btnrenk.BackColor = secilen.SubItems[5].BackColor;
            cmbmotortipi.Text = secilen.SubItems[6].Text;
            dtpmodel.Value = Convert.ToDateTime(string.Format("01.01.{0}", secilen.SubItems[7].Text));
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secilen.SubItems[0].Text = cmbmarka.Text;
            secilen.SubItems[1].Text = cmbmodel.Text;
            secilen.SubItems[2].Text = cmbvites.Text;
            secilen.SubItems[3].Text = cmbkasa.Text;
            secilen.SubItems[4].Text = cmbbenzin.Text;
            secilen.SubItems[5].BackColor = btnrenk.BackColor;
            secilen.SubItems[6].Text = cmbmotortipi.Text;
            secilen.SubItems[7].Text = dtpmodel.Text;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                if (listView1.SelectedItems.Count != 0)
                {
                    DialogResult sonuc = MessageBox.Show("BU ARABAYI SEPETİNİZDEN KALDIRMAK İSTEDİĞİNİZE EMİNMİSİNİZ", "EMİNMİSİNİZ ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        listView1.Items.Remove(listView1.SelectedItems[0]);
                    }
                }
                else
                {
                    MessageBox.Show("HİÇ BİR ELEMAN SEÇİLMEMİŞTİR...");
                }
            }
            else
            {
                MessageBox.Show("SEPETİNİZDE ARABA BULUNMAMAKTADIR...");
            }
        }
    }
}
