using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication34_busotomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void koltukdoldur(int sira, bool varmi)
        {
            baknevar:
            foreach (Control item in this.Controls)
            {
                if (item is Button && item.Text != "BUY")
                {
                    this.Controls.Remove(item);
                    goto baknevar;
                }
            }
            int koltukno = 0;
            for (int i = 0; i < sira; i++)
            {
                for (int t = 0; t < 5; t++)
                {
                    if (i == sira / 2 && t > 2)
                    {
                        continue;
                    }
                    if (varmi == true)
                    {
                        if (i != sira - 1 && t == 2)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (t == 2)
                        {
                            continue;
                        }
                    }
                    Button koltuk = new Button();
                    koltuk.Width = koltuk.Height = 50;
                    koltuk.Top = 23 + (i * 55);
                    koltuk.Left = 175 + (t * 55);
                    koltukno++;
                    koltuk.Text = koltukno.ToString();
                    koltuk.ContextMenuStrip = this.contextMenuStrip1;
                    koltuk.BackColor = Color.Green;
                    koltuk.FlatStyle = FlatStyle.Flat;
                    koltuk.ForeColor = Color.White;
                    koltuk.MouseDown += Koltuk_MouseDown;
                    this.Controls.Add(koltuk);
                }
            }
        }

        Button tiklanan;

        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
        }

        private void cmbotobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbotobus.Text)
            {
                case "TRAVEGO": koltukdoldur(8, false); break;
                case "SETRA": koltukdoldur(12, true); break;
                case "NEOPLAN": koltukdoldur(10, false); break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbotobus.SelectedIndex = 0;
            cmbnerden.SelectedIndex = 0;
            cmbnereye.SelectedIndex = 1;
        }
       
        private void rESERVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitFormu kf = new KayitFormu();
            DialogResult tus = kf.ShowDialog();
            if (tus == DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = string.Format("{0} {1}",kf.txtisim.Text,kf.txtsoyisim.Text);
                lvi.SubItems.Add(kf.mtbtelefon.Text);
                if (kf.rbtnbay.Checked)
                {
                    tiklanan.FlatStyle = FlatStyle.Flat;
                    tiklanan.ForeColor = Color.White;
                    tiklanan.BackColor = Color.DarkBlue;
                    lvi.SubItems.Add("MAN");
                }
                else
                {
                    tiklanan.ForeColor = Color.White;
                    tiklanan.FlatStyle = FlatStyle.Flat;
                    tiklanan.BackColor = Color.HotPink;
                    lvi.SubItems.Add("LADY");
                }
                lvi.SubItems.Add(cmbnerden.Text);
                lvi.SubItems.Add(cmbnereye.Text);
                lvi.SubItems.Add(tiklanan.Text);
                lvi.SubItems.Add(dttarih.Text);
                lvi.SubItems.Add(nudfiyat.Value.ToString() + " $");
                listView1.Items.Add(lvi);
            }
        }
    }
}
