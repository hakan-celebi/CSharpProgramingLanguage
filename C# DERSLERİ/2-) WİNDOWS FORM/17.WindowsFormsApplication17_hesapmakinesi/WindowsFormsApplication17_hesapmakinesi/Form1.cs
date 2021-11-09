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
    public partial class Form1 : Form
    {
        /* AppendText : Textboxa veya bir yazı içeren toolbox item'ına bir string değer eklemeye yarıyor.(textbox1.AppendText(string object);)
         * ResetText : Bir Textboxın veya bir yazı içeren toolbox item'ının string değerini silmeye yarıyor.(textbox1.ResetText();)
         * 
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTkla_Click(object sender, EventArgs e)
        {
            decimal sayi1 = Convert.ToDecimal(textsayi1.Text);
            decimal sayi2 = Convert.ToDecimal(textsayi2.Text);
            decimal toplam = sayi1 + sayi2;
            textBox1.ResetText();
            textBox1.AppendText(Convert.ToString(toplam));
        }

        private void textsayi2_MouseClick(object sender, MouseEventArgs e)
        {
            textsayi2.ResetText();
        }

        private void textsayi1_MouseClick(object sender, MouseEventArgs e)
        {
            textsayi1.ResetText();
        }
    }
}
