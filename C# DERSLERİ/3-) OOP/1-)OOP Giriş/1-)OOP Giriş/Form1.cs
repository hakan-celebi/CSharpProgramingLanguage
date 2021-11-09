using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1__OOP_Giriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Bu şekilde ekleme işlemi yaptığımız zaman farklı bir click event tarafı değişir ve değişmesi gerektiği zaman teker teker her yerden değiştirmemiz gerekecek bu yüzden ekleme kısmını sınıf ile yapmak yani class ile yapmak (nesne) daha avantajlıdır tek bir yerden değiştirildiği zaman her yerden değiştirir.
        private void btnekle_Click(object sender, EventArgs e)
        {
            string isim = txtisim.Text;
            string soyisim = txtsoyisim.Text;
            DateTime dogumtarihi = dtpdogumtarihi.Value;
            personelekle(isim, soyisim, dogumtarihi);
        }

        void personelekle(string isim,string soyisim,DateTime dogumtarihi)
        {
            //VERİ TABANINA PERSONEL EKLEME İŞLEMİ YAPILIR
        }*/

        //Bu şekilde tanımlandığı zaman class tarafında bir veri değişmesi bizi ilgilendiren birşey değildir class üzerinden değiştirmemiz yeterlidir.
        private void btnekle_Click(object sender, EventArgs e)
        {
            Personel prs = new Personel();
            prs.isim = txtisim.Text;
            prs.soyisim = txtsoyisim.Text;
            prs.dogumtarihi = dtpdogumtarihi.Value;
            prs.personelekle();
        }
    }
}
