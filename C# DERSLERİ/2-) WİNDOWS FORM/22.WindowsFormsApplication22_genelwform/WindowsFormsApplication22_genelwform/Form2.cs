using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication22_genelwform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string isim = "";
        int no = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtisim.Text.Trim()) && !string.IsNullOrEmpty(txtno.Text.Trim())) 
            {
                    isim = txtisim.Text.ToUpper().Trim();
                    no = Convert.ToInt32(txtno.Text);
                    listeklenen.Items.Add(string.Format("{0}", isim));
                    txtisim.ResetText();
                    txtno.ResetText();
                    txtisim.Focus();
            }
            else
            {
                    MessageBox.Show("LÜTFEN BİR İSİM GİRİNİZ...");
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            txtasonuc.ResetText();
            string aranan = txtara.Text.ToUpper().Trim();
            if (!string.IsNullOrEmpty(txtara.Text.Trim()))
            {
                if (listeklenen.Items.Contains(aranan))
                {
                    txtasonuc.AppendText(aranan);
                }
                else
                {
                    MessageBox.Show("ARANAN İSİM LİSTEDE BULUNMAMAKTADIR...");
                }
            }
            txtara.Focus();
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtara.Text.ToUpper().Trim();
            ArrayList arananlar = new ArrayList();
            for (int i = 0; i < listeklenen.Items.Count; i++)
            {
                arananlar.Add(listeklenen.Items[i].ToString());
            }
            foreach (string item in arananlar)
            {
                if (!item.Contains(aranan))
                {
                    listeklenen.Items.Remove(item);
                }
            } 
        }
    }
}
