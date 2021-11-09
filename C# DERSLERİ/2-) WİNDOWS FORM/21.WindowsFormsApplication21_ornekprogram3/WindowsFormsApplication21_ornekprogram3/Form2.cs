using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication21_ornekprogram3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            checksayi1.Text = rnd1.Next(0, 1000000).ToString();
            checksayi2.Text = rnd1.Next(0, 1000000).ToString();
            checksayi3.Text = rnd1.Next(0, 1000000).ToString();
            checksayi4.Text = rnd1.Next(0, 1000000).ToString();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            txttoplama.ResetText();
            txtcikarma.ResetText();
            txtcarpma.ResetText();
            txtbolme.ResetText();
            decimal sayi1 = 0;
            decimal sayi2 = 0;
            decimal sayi3 = 0;
            decimal sayi4 = 0;
            decimal topsonuc = 0;
            decimal ciksonuc = 0;
            decimal carpsonuc = 0;
            decimal bolsonuc = 0;
            if (checksayi1.Checked == true)
            {
                sayi1 = Convert.ToDecimal(checksayi1.Text);
            }
            if (checksayi2.Checked == true)
            {
                sayi2 = Convert.ToDecimal(checksayi2.Text);
            }
            if (checksayi3.Checked == true)
            {
                sayi3 = Convert.ToDecimal(checksayi3.Text);
            }
            if (checksayi4.Checked == true)
            {
                sayi4 = Convert.ToDecimal(checksayi4.Text);
            }
            decimal[] sayidizi = new decimal[4];
            int diziboy = sayidizi.Length;
            decimal gecici = 0;
            sayidizi[0] = sayi1;
            sayidizi[1] = sayi2;
            sayidizi[2] = sayi3;
            sayidizi[3] = sayi4;
            for (int i = 0; i < diziboy; i++)
            {
                for (int t = 0; t < diziboy; t++)
                {
                    if (sayidizi[i] > sayidizi[t])
                    {
                        gecici = sayidizi[i];
                        sayidizi[i] = sayidizi[t];
                        sayidizi[t] = gecici;
                    }
                }
            }
            sayi1 = sayidizi[0];
            sayi2 = sayidizi[1];
            sayi3 = sayidizi[2];
            sayi4 = sayidizi[3];
            topsonuc = sayi1 + sayi2 + sayi3 + sayi4;
            txttoplama.AppendText(topsonuc.ToString());
            ciksonuc = sayi1 - sayi2 - sayi3 - sayi4;
            txtcikarma.AppendText(ciksonuc.ToString());
            for (int i = 0; i < diziboy; i++)
            {
                if (sayidizi[i] == 0)
                {
                    sayidizi[i] = 1;
                }
            }
            sayi1 = sayidizi[0];
            sayi2 = sayidizi[1];
            sayi3 = sayidizi[2];
            sayi4 = sayidizi[3];
            carpsonuc = sayi1 * sayi2 * sayi3 * sayi4;
            txtcarpma.AppendText(carpsonuc.ToString());
            bolsonuc = sayi1 / sayi2 / sayi3 / sayi4;
            txtbolme.AppendText(bolsonuc.ToString());
        }
    }
}
