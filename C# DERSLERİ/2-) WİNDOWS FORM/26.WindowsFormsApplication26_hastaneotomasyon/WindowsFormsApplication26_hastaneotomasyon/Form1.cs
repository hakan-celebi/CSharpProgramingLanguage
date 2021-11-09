using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication26_hastaneotomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbsehir_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbsehir.Text)
            {
                case "KONYA":
                    cmbklinik.Items.Clear();
                    cmbklinik.Items.Add("Medicana Konya Hastanesi Selçuklu");
                    cmbklinik.Items.Add("ACİL ÇOCUK GÖZLEM");
                    cmbklinik.Items.Add("ALERJİ VE İMMÜNOLOJİ YAN. DAH.");
                    cmbklinik.Items.Add("BEYİN VE SİNİR CERRAHİSİ SERVİSİ");
                    cmbklinik.Items.Add("ÇOCUK CERRAHİSİ SERVİSİ");
                    cmbklinik.Items.Add("GENEL YOĞUN BAKIM MERAM EKBİNA");
                    break;
                case "İSTANBUL":
                    cmbklinik.Items.Clear();
                    cmbklinik.Items.Add("Anesteziyoloji");
                    cmbklinik.Items.Add("Çocuk Cerrahisi ");
                    cmbklinik.Items.Add("Çocuk Ruh Sağlığı ve Hastalıkları ");
                    cmbklinik.Items.Add("Çocuk Sağlığı ve Hastalıkları");
                    cmbklinik.Items.Add("Dermatoloji");
                    cmbklinik.Items.Add("Enfeksiyon Hastalıkları");
                    cmbklinik.Items.Add("Klinik Farmakoloji");
                    cmbklinik.Items.Add("Fiziksel Tıp ve Rehabilitasyon");
                    cmbklinik.Items.Add("Genel Cerrahi");
                    cmbklinik.Items.Add("Göğüs Cerrahisi");
                    cmbklinik.Items.Add("Göğüs Hastalıkları");
                    cmbklinik.Items.Add("Göz Hastalıkları");
                    cmbklinik.Items.Add("İç Hastalıkları");
                    cmbklinik.Items.Add("Gastroenteroloji");
                    break;
                case "ANKARA":
                    cmbklinik.Items.Clear();
                    cmbklinik.Items.Add("KARDİYOLOJİ");
                    cmbklinik.Items.Add("KOZMETİK DERMATOLOJİ");
                    cmbklinik.Items.Add("GERİATRİ");
                    cmbklinik.Items.Add("KADIN HASTALIKLARI VE DOĞUM");
                    cmbklinik.Items.Add("CİLDİYE");
                    cmbklinik.Items.Add("DAHİLİYE");
                    cmbklinik.Items.Add("GENEL CERRAHİ");
                    cmbklinik.Items.Add("ORTOPEDİ");
                    break;
                case "SİVAS":
                    cmbklinik.Items.Clear();
                    cmbklinik.Items.Add("FİZİK TEDAVİ VE REHABİLTASYON");
                    cmbklinik.Items.Add("KULAK BURUN BOĞAZ");
                    cmbklinik.Items.Add("NÖROLOJİ BÖLÜMÜ");
                    cmbklinik.Items.Add("DİYETİSYEN");
                    break;
                case "ERZURUM":
                    cmbklinik.Items.Clear();
                    cmbklinik.Items.Add("Özel Erzurum Şifa Hastanesi");
                    cmbklinik.Items.Add("Erzurum Özel Buhara Hastanesi");
                    cmbklinik.Items.Add("Mareşal Çakmak Asker Hastanesi");
                    cmbklinik.Items.Add("Net Gör Özel Göz Merkezi Erzurum");
                    break;
                case "YOZGAT":
                    cmbklinik.Items.Clear();
                    cmbklinik.Items.Add("Akdağmadeni Devlet Hastanesi ");
                    cmbklinik.Items.Add("Boğazlıyan Devlet Hastanesi ");
                    cmbklinik.Items.Add("Bozok Üniversitesi Araştırma ve Uygulama Hastanesi ");
                    cmbklinik.Items.Add("Özel Sorgun Anadolu Tıp Merkezi");
                    break;
                default:
                    break;
            }
        }

        private void cmbklinik_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbklinik.Text)
            {
                case "Medicana Konya Hastanesi Selçuklu":
                    cmbdoktor.Items.Clear();
                    cmbdoktor.Items.Add("UZM. PROF. DR. Volkan TAMAN");
                    cmbdoktor.Items.Add("UZM DR. Kadir OÇSOY");
                    cmbdoktor.Items.Add("DR. Hakan ÇELEBİ");
                    cmbdoktor.Items.Add("DR. Muhammed Said AYDIN");
                    cmbdoktor.Items.Add("DOÇ. DR. Ömer SAİM");
                    break;
                case "ACİL ÇOCUK GÖZLEM":
                    cmbdoktor.Items.Clear();
                    cmbdoktor.Items.Add("UZM. DR. Hüsnü BILDIRCIN");
                    cmbdoktor.Items.Add("PROF. DR. Muzaffer KABAK");
                    cmbdoktor.Items.Add("DR. Mine AKMAN");
                    break;
                case "ALERJİ VE İMMÜNOLOJİ YAN. DAH.":
                    cmbdoktor.Items.Clear();
                    cmbdoktor.Items.Add("PROF. DR. Hülya KOÇYİĞİT");
                    cmbdoktor.Items.Add("DR. Can SENDER");
                    break;
                case "BEYİN VE SİNİR CERRAHİSİ SERVİSİ":
                    cmbdoktor.Items.Clear();
                    cmbdoktor.Items.Add("PROF. Selçuk KIROĞLU");
                    cmbdoktor.Items.Add("DR. Ziya TATAR");
                    cmbdoktor.Items.Add("PROF DR. Elif CANER");
                    break;
                case "ÇOCUK CERRAHİSİ SERVİSİ":
                    cmbdoktor.Items.Clear();
                    cmbdoktor.Items.Add("UZM. DR. Gülhan MUTLU");
                    cmbdoktor.Items.Add("UZM. PROF. DR. Hüseyin ÇELİK");
                    cmbdoktor.Items.Add("DR. Abdullah BACAK");
                    break;
                case "GENEL YOĞUN BAKIM MERAM EKBİNA":
                    cmbdoktor.Items.Clear();
                    cmbdoktor.Items.Add("Medicana Konya Hastanesi Selçuklu");
                    cmbdoktor.Items.Add("ACİL ÇOCUK GÖZLEM");
                    cmbdoktor.Items.Add("ALERJİ VE İMMÜNOLOJİ YAN. DAH.");
                    break;
                case "İSTANBUL":
                    cmbklinik.Items.Clear();
                    cmbklinik.Items.Add("Anesteziyoloji");
                    cmbklinik.Items.Add("Çocuk Cerrahisi ");
                    cmbklinik.Items.Add("Çocuk Ruh Sağlığı ve Hastalıkları ");
                    cmbklinik.Items.Add("Çocuk Sağlığı ve Hastalıkları");
                    cmbklinik.Items.Add("Dermatoloji");
                    cmbklinik.Items.Add("Enfeksiyon Hastalıkları");
                    cmbklinik.Items.Add("Klinik Farmakoloji");
                    cmbklinik.Items.Add("Fiziksel Tıp ve Rehabilitasyon");
                    cmbklinik.Items.Add("Genel Cerrahi");
                    cmbklinik.Items.Add("Göğüs Cerrahisi");
                    cmbklinik.Items.Add("Göğüs Hastalıkları");
                    cmbklinik.Items.Add("Göz Hastalıkları");
                    cmbklinik.Items.Add("İç Hastalıkları");
                    cmbklinik.Items.Add("Gastroenteroloji");
                    break;
                case "ANKARA":
                    cmbklinik.Items.Clear();
                    cmbklinik.Items.Add("KARDİYOLOJİ");
                    cmbklinik.Items.Add("KOZMETİK DERMATOLOJİ");
                    cmbklinik.Items.Add("GERİATRİ");
                    cmbklinik.Items.Add("KADIN HASTALIKLARI VE DOĞUM");
                    cmbklinik.Items.Add("CİLDİYE");
                    cmbklinik.Items.Add("DAHİLİYE");
                    cmbklinik.Items.Add("GENEL CERRAHİ");
                    cmbklinik.Items.Add("ORTOPEDİ");
                    break;
                case "SİVAS":
                    cmbklinik.Items.Clear();
                    cmbklinik.Items.Add("FİZİK TEDAVİ VE REHABİLTASYON");
                    cmbklinik.Items.Add("KULAK BURUN BOĞAZ");
                    cmbklinik.Items.Add("NÖROLOJİ BÖLÜMÜ");
                    cmbklinik.Items.Add("DİYETİSYEN");
                    break;
                case "ERZURUM":
                    cmbklinik.Items.Clear();
                    cmbklinik.Items.Add("Özel Erzurum Şifa Hastanesi");
                    cmbklinik.Items.Add("Erzurum Özel Buhara Hastanesi");
                    cmbklinik.Items.Add("Mareşal Çakmak Asker Hastanesi");
                    cmbklinik.Items.Add("Net Gör Özel Göz Merkezi Erzurum");
                    break;
                case "YOZGAT":
                    cmbklinik.Items.Clear();
                    cmbklinik.Items.Add("Akdağmadeni Devlet Hastanesi ");
                    cmbklinik.Items.Add("Boğazlıyan Devlet Hastanesi ");
                    cmbklinik.Items.Add("Bozok Üniversitesi Araştırma ve Uygulama Hastanesi ");
                    cmbklinik.Items.Add("Özel Sorgun Anadolu Tıp Merkezi");
                    break;
                default:
                    break;
            }
        }

        private void btnsaat1_Click(object sender, EventArgs e)
        {
            if (btnsaat1.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat1.Text;
        }

        private void btnsaat2_Click(object sender, EventArgs e)
        {
            if (btnsaat2.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat2.Text;
        }

        private void btnsaat3_Click(object sender, EventArgs e)
        {
            if (btnsaat3.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat3.Text;
        }

        private void btnsaat4_Click(object sender, EventArgs e)
        {
            if (btnsaat4.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat4.Text;
        }

        private void btnsaat5_Click(object sender, EventArgs e)
        {
            if (btnsaat5.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat5.Text;
        }

        private void btnsaat6_Click(object sender, EventArgs e)
        {
            if (btnsaat6.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat6.Text;
        }

        private void btnsaat7_Click(object sender, EventArgs e)
        {
            if (btnsaat7.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat7.Text;
        }

        private void btnsaat8_Click(object sender, EventArgs e)
        {
            if (btnsaat8.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat8.Text;
        }

        private void btnsaat9_Click(object sender, EventArgs e)
        {
            if (btnsaat9.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat9.Text;
        }

        private void btnsaat10_Click(object sender, EventArgs e)
        {
            if (btnsaat10.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat10.Text;
        }

        private void btnsaat11_Click(object sender, EventArgs e)
        {
            if (btnsaat11.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat11.Text;
        }

        private void btnsaat12_Click(object sender, EventArgs e)
        {
            if (btnsaat12.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat12.Text;
        }

        private void btnsaat13_Click(object sender, EventArgs e)
        {
            if (btnsaat13.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat13.Text;
        }

        private void btnsaat14_Click(object sender, EventArgs e)
        {
            if (btnsaat14.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat14.Text;
        }

        private void btnsaat15_Click(object sender, EventArgs e)
        {
            if (btnsaat15.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat15.Text;
        }

        private void btnsaat16_Click(object sender, EventArgs e)
        {
            if (btnsaat16.BackColor == Color.Red)
            {
                MessageBox.Show("Bu Saatte Randevu Bulunmaktadır Lütfen Başka Bir Saat Seçin !");
                return;
            }
            txtalinanisim.Text = txtisim.Text;
            txtalinansaat.Text = btnsaat16.Text;
        }
        string saats;
        private void button1_Click(object sender, EventArgs e)
        {
            if (mtxttckn.Text == string.Empty)
            {
                MessageBox.Show("LÜTFEN TCKN GİRİNİZ !");
                return;
            }
            if (txtalinanisim.Text != string.Empty && txtalinansaat.Text != string.Empty)
            {
                MessageBox.Show("SAYIN " + txtalinanisim.Text + " RANDEVUNUZ BAŞARI İLE SAAT " + txtalinansaat.Text + "'a ALINMIŞTIR");
                saats = txtalinansaat.ToString();
            }
            else
            {
                MessageBox.Show("LÜTFEN İSMİNİZİ VE SAATİ SEÇİNİZ");
                return;
            }
            if (btnsaat1.Text == txtalinansaat.Text)
            {
                btnsaat1.BackColor = Color.Red;
            }
            else if (btnsaat2.Text == txtalinansaat.Text)
            {
                btnsaat2.BackColor = Color.Red;
            }
            else if (btnsaat3.Text == txtalinansaat.Text)
            {
                btnsaat3.BackColor = Color.Red;
            }
            else if (btnsaat4.Text == txtalinansaat.Text)
            {
                btnsaat4.BackColor = Color.Red;
            }
            else if (btnsaat5.Text == txtalinansaat.Text)
            {
                btnsaat5.BackColor = Color.Red;
            }
            else if (btnsaat6.Text == txtalinansaat.Text)
            {
                btnsaat6.BackColor = Color.Red;
            }
            else if (btnsaat7.Text == txtalinansaat.Text)
            {
                btnsaat7.BackColor = Color.Red;
            }
            else if (btnsaat8.Text == txtalinansaat.Text)
            {
                btnsaat8.BackColor = Color.Red;
            }
            else if (btnsaat9.Text == txtalinansaat.Text)
            {
                btnsaat9.BackColor = Color.Red;
            }
            else if (btnsaat10.Text == txtalinansaat.Text)
            {
                btnsaat10.BackColor = Color.Red;
            }
            else if (btnsaat11.Text == txtalinansaat.Text)
            {
                btnsaat11.BackColor = Color.Red;
            }
            else if (btnsaat12.Text == txtalinansaat.Text)
            {
                btnsaat12.BackColor = Color.Red;
            }
            else if (btnsaat13.Text == txtalinansaat.Text)
            {
                btnsaat13.BackColor = Color.Red;
            }
            else if (btnsaat14.Text == txtalinansaat.Text)
            {
                btnsaat14.BackColor = Color.Red;
            }
            else if (btnsaat15.Text == txtalinansaat.Text)
            {
                btnsaat15.BackColor = Color.Red;
            }
            else if (btnsaat16.Text == txtalinansaat.Text)
            {
                btnsaat16.BackColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = string.Format("{0:HH}:{0:mm}", DateTime.Now);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (txtalinansaat.Text != string.Empty)
            {
                saats = txtalinansaat.Text;
            }
            if (saats == lbltarih.Text)
            {
                timer2.Stop();
                MessageBox.Show("RANDEVU ZAMANINIZ GELMİŞTİR !");
            }
        }

        private void txtisim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
