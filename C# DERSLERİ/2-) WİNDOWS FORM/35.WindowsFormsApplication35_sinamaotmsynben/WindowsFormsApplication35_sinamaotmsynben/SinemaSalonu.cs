using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication35_sinamaotmsynben
{
    public partial class SinemaSalonu : Form
    {
        public SinemaSalonu()
        {
            InitializeComponent();
        }

        int sayac = 0;

        void koltukolusturma(int sira)
        {
            baknevar:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    if (ctrl.Text != "PAY" && ctrl.Text != "OKAY")
                    {
                        this.Controls.Remove(ctrl);
                        goto baknevar;
                    }
                }
            }
            int koltukno = 0;
            for (int i = 0; i < sira; i++)
            {
                if ((sira / 2) + 1 == i)
                {
                    continue;
                }
                for (int t = 0; t < 13; t++)
                {
                    if (t == 6)
                    {
                        continue;
                    }
                    koltukno++;
                    Button koltuk = new Button();
                    koltuk.BackColor = Color.White;
                    koltuk.Width = 50;
                    koltuk.Height = 50;
                    koltuk.Left = 40 + (t * 55);
                    koltuk.Top = 10 + (i * 55);
                    koltuk.ForeColor = Color.Black;
                    koltuk.FlatStyle = FlatStyle.Flat;
                    koltuk.Text = koltukno.ToString();
                    koltuk.Click += Koltuk_Click;
                    koltuk.MouseDown += Koltuk_MouseDown;
                    this.Controls.Add(koltuk);
                }
            }
        }

        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            Button vazgec = sender as Button;
            if (e.Button == MouseButtons.Right)
            {
                if (vazgec.BackColor == Color.LimeGreen)
                {
                    sayac--;
                    vazgec.BackColor = Color.White;
                }
            }
        }

        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button tiklanankoltuk = sender as Button;
            if (tiklanankoltuk.BackColor != Color.LimeGreen && tiklanankoltuk.BackColor != Color.DarkRed)
            {
                tiklanankoltuk.BackColor = Color.LimeGreen;
                sayac++;
            }
            else if (tiklanankoltuk.BackColor == Color.DarkRed)
            {
                MessageBox.Show("BU KOLTUKLAR DOLUDUR BAŞKA KOLTUK SEÇİNİZ...");   
            }
        }

        private void cmbsalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbsalon.Text)
            {
                case "MOVIE THEATER 1": koltukolusturma(8); break;
                case "MOVIE THEATER 2": koltukolusturma(10); break;
                case "MOVIE THEATER 3": koltukolusturma(12); break;
                case "MOVIE THEATER 4": koltukolusturma(14); break;
                case "MOVIE THEATER 5": koltukolusturma(16); break;
                default:
                    break;
            }
        }

        private void SinemaSalonu_Load(object sender, EventArgs e)
        {
            cmbsalon.SelectedIndex = 0;
            cmbboyut.SelectedIndex = 0;
        }
        int tiklanma = 0;
        Form1 odeme = new Form1();
        private void btnode_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                MessageBox.Show("KOLTUK SEÇİNİZ...");
                return;
            }
            tiklanma++;
            odeme.nudkartbilet.Text = sayac.ToString();
            odeme.nutnakitbilet.Text = sayac.ToString();
            odeme.nudkartbilet.Value = sayac;
            odeme.nutnakitbilet.Value = sayac;
            if (cmbfilm.Text != string.Empty)
            {
                odeme.ShowDialog();
            }
            else
            {
                errorProvider1.SetError(cmbfilm,"(FİLM SEÇİNİZ)");
                MessageBox.Show("LÜTFEN ÖNCE GEREKLİ ALANLARI DOLDURUNUZ");
            }
        }

        private void btnonayla_Click(object sender, EventArgs e)
        {
            if (tiklanma == 0)
            {
                MessageBox.Show("ÖNCE ÖDEME YAPINIZ...");
            }
            else
            {
                ListViewItem lvi = new ListViewItem();
                if (odeme.txtkartsahibi.Text == string.Empty)
                {
                    lvi.Text = odeme.txtnakitisim.Text;
                    lvi.SubItems.Add(odeme.mtxtnakittel.Text);
                    lvi.SubItems.Add(sayac.ToString());
                    lvi.SubItems.Add(cmbfilm.Text);
                    lvi.SubItems.Add(cmbsalon.Text);
                    lvi.SubItems.Add(dtpsaat.Text);
                    lvi.SubItems.Add(cmbboyut.Text);
                    lvi.SubItems.Add(odeme.lblnakittutar.Text);
                    listView1.Items.Add(lvi);
                }
                else if (odeme.txtnakitisim.Text == string.Empty)
                {
                    lvi.Text = odeme.txtkartsahibi.Text;
                    lvi.SubItems.Add(odeme.mtxtkartsahibitel.Text);
                    lvi.SubItems.Add(sayac.ToString());
                    lvi.SubItems.Add(cmbfilm.Text);
                    lvi.SubItems.Add(cmbsalon.Text);
                    lvi.SubItems.Add(dtpsaat.Text);
                    lvi.SubItems.Add(cmbboyut.Text);
                    lvi.SubItems.Add(odeme.lblkarttutar.Text);
                    listView1.Items.Add(lvi);
                }
                foreach (Control item in this.Controls)
                {
                    if (item.BackColor == Color.LimeGreen)
                    {
                        item.BackColor = Color.DarkRed;
                    }
                }
                odeme.txtnakitisim.ResetText();
                odeme.txtkartsahibi.ResetText();
                odeme.mtxtnakittel.ResetText();
                odeme.mtxtkartsahibitel.ResetText();
                odeme.mtxtkartnumara.ResetText();
                odeme.lblkarttutar.ResetText();
                odeme.lblnakittutar.ResetText();
                odeme.nudkartbilet.Value = 1;
                odeme.nutnakitbilet.Value = 1;
                tiklanma = 0;
                sayac = 0;
            }
        }

        private void cmbfilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbfilm.Text)
            {
                case "Çılgın Hırsız 3" : pictureBox1.Image = Image.FromFile(@"C:\\Users\\KadirOcsoy\\Downloads\\cilginhirsiz.jpg"); break;
                case "Şansımı Seveyim": pictureBox1.Image = Image.FromFile(@"C:\\Users\\KadirOcsoy\\Downloads\\sansimiseveyim.jpg"); break;
                case "Anabelle: Kötülüğün Doğuşu": pictureBox1.Image = Image.FromFile(@"C:\\Users\\KadirOcsoy\\Downloads\\anabelle.jpg"); break;
                case "Şanslı Logan": pictureBox1.Image = Image.FromFile(@"C:\\Users\\KadirOcsoy\\Downloads\\logan.jpg"); break;
                case "Cumali Ceber: Allah Seni Alsın": pictureBox1.Image = Image.FromFile(@"C:\\Users\\KadirOcsoy\\Downloads\\ceber.jpg"); break;
                default:
                    break;
            }
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                listView1.ContextMenuStrip = this.contextMenuStrip1;
            }
        }
    }
}
