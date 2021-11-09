using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication36_hataayiklama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Hata Türleri:
         * 1-Derleme Hataları (Build Error)
         * 2-Çalışma Zamanı Hataları (Runtime Error)
         * 3-Mantıksal Hatalar (Logical Error)
         */

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Çalışma zamanı hatalarını tespit edip yakalamak için try cacth yapısı kullanılır.
            string sayi1 = textBox1.Text;
            string sayi2 = textBox2.Text;
            try
            {
                int sayiilk = Convert.ToInt32(sayi1);
                int sayiiki = Convert.ToInt32(sayi2); ;
                int toplam = sayiilk + sayiiki;
                textBox3.Text = toplam.ToString();
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message + " SADECE SAYI GİREBİLİRSİNİZ");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message + " BU KADAR BÜYÜK SAYI GİREMESSİNİZ ");
            }
            finally
            {
                //Try içerisindeki komutlar hata versede vermesede finally bloğu her halukarda çalışır örnek bağlantı kapatılması.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Mantıksal Hatalar Breakpoint ile çözülür.
            //F10 tuşu ile bir sonraki adıma geçilir.
            //Eğer metod var ise F11 ile de metod içerisine girilir. 
            int toplam = 0;
            for (int i = 1; i < 101; i++)
            {
                toplam += i;
            }
            MessageBox.Show(toplam.ToString());
        }
    }
}
