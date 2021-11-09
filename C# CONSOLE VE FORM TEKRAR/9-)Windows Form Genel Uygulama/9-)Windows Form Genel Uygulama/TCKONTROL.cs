using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9__Windows_Form_Genel_Uygulama
{
    public partial class TCKONTROL : Form
    {
        public TCKONTROL()
        {
            InitializeComponent();
        }

        private void btnsorgula_Click(object sender, EventArgs e)
        {
            if (!mtxttc.MaskFull)
            {
                MessageBox.Show("T.C. KİMLİK NUMARASI 11 HANELİ OLMAK ZORUNDADIR.");
            }
            else
            {
                string girilentc = mtxttc.Text;
                char[] ikincikural1 = new char[5];
                char[] ikincikural2 = new char[4];
                int x = 0;
                for (int i = 0; i < 9; i += 2)
                {
                    char hane = girilentc[i];
                    ikincikural1[x] = hane;
                    x++;
                }
                x = 0;
                for (int i = 1; i < 8; i += 2)
                {
                    char hane = girilentc[i];
                    ikincikural2[x] = hane;
                    x++;
                }
                string a;
                int kuralhesap1 = 0;
                int kuralhesap2 = 0;
                int anahesap = 0;
                foreach (char item in ikincikural1)
                {
                    a = Convert.ToString(item);
                    kuralhesap1 += int.Parse(a);
                }
                kuralhesap1 *= 7;
                foreach (char item in ikincikural2)
                {
                    a = Convert.ToString(item);
                    kuralhesap2 += int.Parse(a);
                }
                anahesap = kuralhesap1 - kuralhesap2;
                int ikincianahesap = 0;
                foreach (char item in girilentc)
                {
                    a = Convert.ToString(item);
                    ikincianahesap += int.Parse(a);
                }
                a = girilentc[10].ToString();
                string b = girilentc[9].ToString();
                ikincianahesap -= int.Parse(a);
                if (girilentc[0] != 0 && anahesap % 10 == int.Parse(b) && ikincianahesap % 10 == int.Parse(a) && int.Parse(a) % 2 == 0)
                {
                    MessageBox.Show(string.Format("{0} T.C. KİMLİK NUMARASI GEÇERLİDİR.", girilentc));
                }
                else
                {
                    MessageBox.Show(string.Format("{0} T.C. KİMLİK NUMARASI GEÇERLİDEĞİLDİR.", girilentc));
                }
            }
        }
    }
}
