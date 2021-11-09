using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12__Dialog_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            DialogResult secim = fontDialog1.ShowDialog();
            if (secim == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }

        private void btnrenk_Click(object sender, EventArgs e)
        {
            DialogResult secim = colorDialog1.ShowDialog();
            if (secim == DialogResult.OK)
            {
                label1.ForeColor = colorDialog1.Color;
            }
        }

        private void btndosyaac_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpeg)|*.jpeg";
            DialogResult secim = openFileDialog1.ShowDialog();
            if (secim == DialogResult.OK)
            {
                label1.Text = string.Format("Dosya Adı: {0}, Dosya Uzantısı {1}", openFileDialog1.SafeFileName,openFileDialog1.FileName);
            }
        }

        private void btngezin_Click(object sender, EventArgs e)
        {
            DialogResult secim = folderBrowserDialog1.ShowDialog();
            if (secim == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
