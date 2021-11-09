using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication22_genelwform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            if (mtbtc.MaskFull == true)
            {
                string atc = mtbtc.Text;
                string son = mtbtc.Text[10].ToString();
                int sonrakam = Convert.ToInt32(son);
                int sonuc = 0;
                if (Convert.ToInt32(sonrakam) % 2 == 0)
                {
                    for (int i = 0; i < atc.Length - 1; i++)
                    {
                        string sayi = atc[i].ToString();
                        sonuc += Convert.ToInt32(sayi);
                    }
                    if (sonuc % 10 == Convert.ToInt32(sonrakam))
                    {
                        MessageBox.Show("T.C. VATANDAŞISINIZ...");
                    }
                    else
                    {
                        MessageBox.Show("T.C. VATANDAŞLIĞINIZ  BULUNMAMAKTADIR...");
                    }
                }
                else
                {
                    MessageBox.Show("T.C. VATANDAŞLIĞINIZ  BULUNMAMAKTADIR...");
                }
            }
            else
            {
                MessageBox.Show("TCKN 11 HANELİ OLMASI GEREKİR !");
            }
        }
    }
}
