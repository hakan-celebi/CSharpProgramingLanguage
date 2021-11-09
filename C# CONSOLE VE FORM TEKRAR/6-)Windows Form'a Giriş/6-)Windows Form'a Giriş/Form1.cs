using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6__Windows_Form_a_Giriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            this.Text = "HESAPLANDI";
            int ilk = int.Parse(txtilksayi.Text);
            int iki = int.Parse(txtikincisayi.Text);
            int sonuc = ilk + iki;
            txtsonuc.Text = Convert.ToString(sonuc);
            MessageBox.Show(string.Format("Sonucunuz Hesaplandı SONUÇ: {0} ",sonuc));
        }
    }
}
