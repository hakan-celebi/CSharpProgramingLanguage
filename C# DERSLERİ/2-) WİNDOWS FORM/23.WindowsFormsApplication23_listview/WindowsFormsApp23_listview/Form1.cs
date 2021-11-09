using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23_listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnonayla_Click(object sender, EventArgs e)
        {
            /*  txtad.ResetText();
            txtsoyad.ResetText();
            txtmail.ResetText();
            mtxtbt.ResetText();
            mtxtdt.ResetText();
            mtxttckn.ResetText();
            mtxttel.ResetText();
            cbalan.ResetText();*/
            if (cbkabul.Checked)
            {
                ListViewItem lvi = new ListViewItem();
                if (!string.IsNullOrEmpty(txtad.Text) && !string.IsNullOrEmpty(txtsoyad.Text) && !string.IsNullOrEmpty(mtxttckn.Text) && !string.IsNullOrEmpty(mtxtdt.Text) && !string.IsNullOrEmpty(mtxttel.Text) && !string.IsNullOrEmpty(mtxtbt.Text) && !string.IsNullOrEmpty(cbalan.Text))
                {
                    lvi.Text = txtad.Text;
                    lvi.SubItems.Add(txtsoyad.Text);
                    lvi.SubItems.Add(mtxttckn.Text);
                    lvi.SubItems.Add(mtxtdt.Text);
                    lvi.SubItems.Add(mtxttel.Text);
                    lvi.SubItems.Add(mtxtbt.Text);
                    lvi.SubItems.Add(txtmail.Text);
                    lvi.SubItems.Add(cbalan.Text);
                    listView1.Items.Add(lvi);
                }
                else 
                {
                    MessageBox.Show("FORMU EKSİKSİZ DOLDURDUĞUNUZA EMİN OLUN...");
                } 
            }
            else
            {
                MessageBox.Show("BAŞVURU ŞARTLARINI KABUL ETMENİZ GEREKMEKTEDİR");
            }
            txtad.Focus();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            txtad.ResetText();
            txtsoyad.ResetText();
            txtmail.ResetText();
            mtxtbt.ResetText();
            mtxtdt.ResetText();
            mtxttckn.ResetText();
            mtxttel.ResetText();
            cbalan.ResetText();
        }
    }
}
