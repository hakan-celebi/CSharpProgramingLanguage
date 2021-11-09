using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19__Otobüs_Otomasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbotobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbotobus.Text)
            {
                case "TREVEGO":
                    otobuskoltuk(8, false);
                    break;
                case "NEOPLAN":
                    otobuskoltuk(12, true);
                    break;
                case "SETRA":
                    otobuskoltuk(10, false);
                    break;
            }
        }

        int a = 0;

        void otobuskoltuk(int x,bool y)
        {
            yavasla:
            foreach (Control item in this.Controls)
            {
                if (item is Button && item.Name != "btnonaylaa")
                {
                    this.Controls.Remove(item);
                    goto yavasla;
                }
            }
            a = 0;
            for (int i = 0; i < x; i++)
            {
                for (int t = 0; t < 5; t++)
                {
                    Button btn = new Button();
                    if ((x*3) / 5 == i)
                    {
                        if (t < 2)
                        {
                            a++;
                            btn.Width = btn.Height = 60;
                            btn.FlatStyle = FlatStyle.Flat;
                            btn.BackColor = Color.Green;
                            btn.ForeColor = Color.Gray;
                            btn.Text = a.ToString();
                            btn.Top = 30 + (i * 65);
                            btn.Left = 10 + (t * 65);
                        }
                    }
                    else if (i == x-1 && y == true)
                    {
                        a++;
                        btn.Width = btn.Height = 60;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.BackColor = Color.Green;
                        btn.ForeColor = Color.Gray;
                        btn.Text = a.ToString();
                        btn.Top = 30 + (i * 65);
                        btn.Left = 10 + (t * 65);
                    }
                    else
                    {
                        if (t == 2)
                        {
                            continue;
                        }
                        else
                        {
                            a++;
                            btn.Width = btn.Height = 60;
                            btn.FlatStyle = FlatStyle.Flat;
                            btn.BackColor = Color.Green;
                            btn.ForeColor = Color.Gray;
                            btn.Text = a.ToString();
                            btn.Top = 30 + (i * 65);
                            btn.Left = 10 + (t * 65);
                        }
                    }
                    btn.ContextMenuStrip = contextMenuStrip1;
                    btn.MouseDown += Btn_MouseDown;
                    this.Controls.Add(btn);
                }
            }
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                sec = sender as Button;
            }
        }

        Button sec = new Button();

        ListViewItem lvi = new ListViewItem();
        bool kont = false;

        private void cmsreserveet_Click(object sender, EventArgs e)
        {
            if (cmbotobus.Text == string.Empty)
            {
                errorProvider1.SetError(cmbotobus, "BOŞ GEÇİLMEZ");
            }
            if (cmbnerden.Text == string.Empty)
            {
                errorProvider1.SetError(cmbnerden, "BOŞ GEÇİLMEZ");
            }
            if (cmbnereye.Text == string.Empty)
            {
                errorProvider1.SetError(cmbnereye, "BOŞ GEÇİLMEZ");
            }
            if (dtpgidistarihi.Text == string.Empty)
            {
                errorProvider1.SetError(dtpgidistarihi, "BOŞ GEÇİLMEZ");
            }
            if (nudfiyat.Value.ToString() == string.Empty)
            {
                errorProvider1.SetError(nudfiyat, "BOŞ GEÇİLMEZ");
            }
            if (cmbotobus.Text == string.Empty | cmbnerden.Text == string.Empty | cmbnereye.Text == string.Empty | dtpgidistarihi.Text == string.Empty | nudfiyat.Value.ToString() == string.Empty)
            {
                MessageBox.Show("LÜTFEN GEREKLİ ALANLARI DOLDURUNUZ...");
                return;
            }
            Kayitformu kayit = new Kayitformu();
            DialogResult dlr = kayit.ShowDialog();
            if (dlr == DialogResult.OK)
            {
                if (kayit.txtisim.Text == string.Empty && kayit.txtsoyisim.Text == string.Empty && kayit.mtxttc.Text == string.Empty && kayit.mtxttel.Text == string.Empty && kayit.nudyas.Value.ToString() == string.Empty)
                {
                    MessageBox.Show("LÜTFEN GEREKLİ ALANLARI DOLDURUNUZ...");
                }
                lvi = new ListViewItem();
                lvi.Text = kayit.txtisim.Text;
                lvi.SubItems.Add(kayit.txtsoyisim.Text);
                lvi.SubItems.Add(kayit.nudyas.Value.ToString());
                lvi.SubItems.Add(kayit.mtxttc.Text);
                lvi.SubItems.Add(kayit.mtxttel.Text);
                if (kayit.rbtnbay.Checked)
                {
                    lvi.SubItems.Add("BAY");
                    sec.BackColor = Color.Blue;
                }
                else if (kayit.rbtnbayan.Checked)
                {
                    lvi.SubItems.Add("BAYAN");
                    sec.BackColor = Color.Pink;
                }
                else
                {
                    MessageBox.Show("LÜTFEN CİNSİYET SEÇİNİZ...");
                    return;
                }
                lvi.SubItems.Add(cmbotobus.Text);
                lvi.SubItems.Add(string.Format("{0}-{1}",cmbnerden.Text,cmbnereye.Text));
                lvi.SubItems.Add(dtpgidistarihi.Text);
                lvi.SubItems.Add(nudfiyat.Value.ToString());
                lvi.SubItems.Add(sec.Text);
                kont = true;
            }
        }

        private void btnonaylaa_Click(object sender, EventArgs e)
        {
            if (kont == false)
            {
                return;
            }
            listView1.Items.Add(lvi);
            kont = false;
        }
    }
}
