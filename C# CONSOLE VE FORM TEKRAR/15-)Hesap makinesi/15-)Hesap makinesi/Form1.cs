using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15__Hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblalt.Text = string.Empty;
        }

        bool topkont = false;
        bool cikkont = false;
        bool carpkont = false;
        bool bolkont = false;
        private void btntopla_Click(object sender, EventArgs e)
        {
            string yedek;
            if (txtislem.Text.Trim() != string.Empty)
            {
                yedek = txtislem.Text;
                lblalt.Text = yedek;
                topkont = true;
                txtislem.Clear();
            }
        }

        private void btncikar_Click(object sender, EventArgs e)
        {
            string yedek;
            if (txtislem.Text.Trim() != string.Empty)
            {
                yedek = txtislem.Text;
                lblalt.Text = yedek;
                cikkont = true;
                txtislem.Clear();
            }
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            string yedek;
            if (txtislem.Text.Trim() != string.Empty)
            {
                yedek = txtislem.Text;
                lblalt.Text = yedek;
                carpkont = true;
                txtislem.Clear();
            }
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            string yedek;
            if (txtislem.Text.Trim() != string.Empty)
            {
                yedek = txtislem.Text;
                lblalt.Text = yedek;
                bolkont = true;
                txtislem.Clear();
            }
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            if (topkont == true && txtislem.Text.Trim() != string.Empty)
            {
                int sonuc = int.Parse(lblalt.Text) + int.Parse(txtislem.Text);
                txtislem.Text = sonuc.ToString();
            }
            else if (cikkont == true && txtislem.Text.Trim() != string.Empty)
            {
                int sonuc = int.Parse(lblalt.Text) - int.Parse(txtislem.Text);
                txtislem.Text = sonuc.ToString();
            }
            else if (carpkont == true && txtislem.Text.Trim() != string.Empty)
            {
                int sonuc = int.Parse(lblalt.Text) * int.Parse(txtislem.Text);
                txtislem.Text = sonuc.ToString();
            }
            else if (bolkont == true && txtislem.Text.Trim() != string.Empty)
            {
                int sonuc = int.Parse(lblalt.Text) / int.Parse(txtislem.Text);
                txtislem.Text = sonuc.ToString();
            }
        }
    }
}
