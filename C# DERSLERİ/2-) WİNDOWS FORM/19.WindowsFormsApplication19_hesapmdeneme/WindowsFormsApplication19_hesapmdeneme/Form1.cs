using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication19_hesapmdeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal sayi = 0;
        decimal sayi2 = 0;
        decimal sonuc = 0;
        decimal onceki = 0;
        string islem = "";
        int sayac = 0;
        decimal[] sayis = new decimal[0];
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            Button btn = sender as Button;
            sayi = Convert.ToDecimal(btn.Text);
            Array.Resize(ref sayis, sayac);
        }


        private void buttonarti_Click(object sender, EventArgs e)
        {
            Button btnislem = sender as Button;
            islem = Convert.ToString(btnislem.Text);
            for (int i = 0; i < sayac; i++)
            {
                sayis[i] = sayi;
            }
            textBox1.AppendText(sayi.ToString());
            txtyazilan.AppendText(sayi.ToString());
            if (islem == "+")
            {
                textBox1.Show();
                textBox1.AppendText("+");
                for (int i = 0; i < sayac; i++)
                {
                    sonuc += sayis[i];
                    i++;
                }
                txtyazilan.ResetText();
                txtyazilan.AppendText(sonuc.ToString());
            }
            
        }

        private void buttonesit_Click(object sender, EventArgs e)
        {
            txtyazilan.ResetText();
            txtyazilan.AppendText(sonuc.ToString());
        }

    }
}
