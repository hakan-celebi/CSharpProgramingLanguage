using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5__Polymorphism__Çok_Biçimlilik__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnankara_Click(object sender, EventArgs e)
        {
            Ankarakedisi ak = new Ankarakedisi();
            MessageBox.Show(ak.Gozrengi());
        }

        private void btnvan_Click(object sender, EventArgs e)
        {
            Vankedisi vk = new Vankedisi();
            MessageBox.Show(vk.Gozrengi());
        }
    }
}
