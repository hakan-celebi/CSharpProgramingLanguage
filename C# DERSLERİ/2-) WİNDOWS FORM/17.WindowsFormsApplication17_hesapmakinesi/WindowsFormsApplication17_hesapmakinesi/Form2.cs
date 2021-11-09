using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17_hesapmakinesi
{
    public partial class Form2 : Form
    {
        /* SelectedIndex : Bir Combobox gibi birden çok item alabilen toolbox itemlerinin göstermek istenen değerini seçiyor.(combobox.SelectedIndex = 0;)
         * Break : Switch Case de bir komutun sonlanmasına yarıyor.
         */
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbislem.SelectedIndex = 0;
        }

        private void buttonsonuc_Click(object sender, EventArgs e)
        {
            decimal s1 = sayi1.Value;
            decimal s2 = sayi2.Value;
            decimal toplam = 0;
            switch (cmbislem.Text)
            {
                case "+": toplam = s1 + s2; break;
                case "-": toplam = s1 - s2; break;
                case "X": toplam = s1 * s2; break;
                case "/": toplam = s1 / s2; break;
                case "%": toplam = s1 % s2; break;
                default: break;
            }
            snchesap.Text = toplam.ToString();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            sayi1.ResetText();
            sayi2.ResetText();
        }
    }
}
