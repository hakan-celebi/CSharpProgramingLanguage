using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12__Pizza_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtadet.Text = "1";
            Ebatlar kck = new Ebatlar { adi = "KÜÇÜK BOY", carpani = 1 };
            Ebatlar orta = new Ebatlar { adi = "ORTA BOY", carpani = 1.25 };
            Ebatlar buyuk = new Ebatlar { adi = "BÜYÜK BOY", carpani = 1.5 };
            Ebatlar max = new Ebatlar { adi = "MAX BOY", carpani = 2 };
            cmbebatlar.Items.Add(kck);
            cmbebatlar.Items.Add(orta);
            cmbebatlar.Items.Add(buyuk);
            cmbebatlar.Items.Add(max);
            Pizzalar klasik = new Pizzalar { adi = "KLASİK", fiyati = 10 };
            Pizzalar karisik = new Pizzalar { adi = "KARIŞIK", fiyati = 12 };
            Pizzalar extravaganza = new Pizzalar { adi = "EXTRAVAGANZA", fiyati = 17 };
            Pizzalar italiano = new Pizzalar { adi = "İTALİANO", fiyati = 23 };
            Pizzalar turkish = new Pizzalar { adi = "TÜRKİSH", fiyati = 15 };
            Pizzalar tuna = new Pizzalar { adi = "TUNA", fiyati = 15 };
            Pizzalar seafeed = new Pizzalar { adi = "SEAFEED", fiyati = 21 };
            Pizzalar kastamonu = new Pizzalar { adi = "KASTAMONU", fiyati = 13 };
            Pizzalar calypso = new Pizzalar { adi = "CALYPSO", fiyati = 27 };
            Pizzalar akdeniz = new Pizzalar { adi = "AKDENİZ", fiyati = 18 };
            Pizzalar karadeniz = new Pizzalar { adi = "KARADENİZ", fiyati = 8 };
            cmbpizzalar.Items.Add(klasik);
            cmbpizzalar.Items.Add(karisik);
            cmbpizzalar.Items.Add(extravaganza);
            cmbpizzalar.Items.Add(italiano);
            cmbpizzalar.Items.Add(turkish);
            cmbpizzalar.Items.Add(tuna);
            cmbpizzalar.Items.Add(seafeed);
            cmbpizzalar.Items.Add(kastamonu);
            cmbpizzalar.Items.Add(calypso);
            cmbpizzalar.Items.Add(akdeniz);
            cmbpizzalar.Items.Add(karadeniz);
            Kenar ince = new Kenar { kenar = "İNCE", carpani = 0 };
            rbtnincekenar.Tag = ince;
            Kenar kalin = new Kenar { kenar = "KALIN", carpani = 2 };
            rbtnkalinkenar.Tag = kalin;
            cmbebatlar.SelectedIndex = 0;
            cmbpizzalar.SelectedIndex = 0;
        }

        Pizzalar p;

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            int adet = 0;
            try
            {
                adet = int.Parse(txtadet.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("LÜTFÜN ADETİ SAYI İLE BELİRTİNİZ.");
                return;
            }
            p = (Pizzalar)cmbpizzalar.SelectedItem;
            Ebatlar ebt = (Ebatlar)cmbebatlar.SelectedItem;
            p.adeti = adet;
            p.ebati = ebt;
            p.kenari = rbtnincekenar.Checked ? (Kenar)rbtnincekenar.Tag : (Kenar)rbtnkalinkenar.Tag;
            p.malzemeler = new List<string>();
            foreach (CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    p.malzemeler.Add(item.Text);
                }
            }
            lbltutar.Text = string.Format("TUTAR: {0} TL", p.topfiyati);
        }

        Sepet spt = new Sepet();

        private void btnsepetekle_Click(object sender, EventArgs e)
        {
            cmbebatlar.SelectedIndex = 0;
            cmbpizzalar.SelectedIndex = 0;
            txtadet.Text = "1";
            foreach (CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    item.Checked = false;
                }
            }
            lbltutar.Text = "TUTAR: 0 TL";
            spt.pizza.Add(p);
            spt.piza = p;
            lbsepet.Items.Add(spt);
            lbltoplamtutar.Text = string.Format("TOPLAM TUTAR: {0} TL", spt.sepettoplam.ToString());
        }

        private void btnsiparisionayla_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("TOPLAM TUTAR: {0} TL BİZİ SEÇTİĞİNİZ İÇİN TEŞEKKÜR EDER BİRDAHA BEKLERİZ",spt.sepettoplam.ToString()), spt.sepettoplam.ToString());
            lbsepet.Items.Clear();
            spt = new Sepet();
            p = new Pizzalar();
            lbltutar.Text = "TUTAR: 0 TL";
            lbltoplamtutar.Text = "TOPLAM TUTAR: 0 TL";
        }
    }
}
