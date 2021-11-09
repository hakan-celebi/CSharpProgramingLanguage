using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication18_listeleyicilerlistbox
{
    public partial class Form1 : Form
    {
        /* Trim() : Boşlukları silmeye yarar.
         * e.KeyCode == Keys.Delete : Basılan tuşu okumaya yarıyor.
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtisim.Text.Trim() != "")
            {
                string girsim = txtisim.Text;
                string yazicak = string.Format("{0}-{1}", isimliste.Items.Count + 1,txtisim.Text);
                isimliste.Items.Add(yazicak);
                //int len = girsim.Length;
                //int len2 = girsim.Length;
                txtisim.ResetText();
                /*char[] nesne = new char[len];
                for (int i = 0; i < len; i++)
                {
                    char alinan1 = girsim[i];
                    for (int t = len2-1; t >= 0; t--)
                    {
                        nesne[t] = alinan1;
                    }
                    len2--;
                }
                string yeni = "";
                for (int i = 0; i < len; i++)
                {
                    yeni += nesne[i];
                }
                isimliste.Items.Add(yeni);*/
                txtisim.Focus();
            }
            else
            {
                MessageBox.Show("LÜTFEN İSİM GİRİNİZ !");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] silinme = new string[isimliste.SelectedItems.Count];
            for (int i = 0; i < isimliste.SelectedItems.Count; i++)
            {
                silinme[i] = (string)isimliste.SelectedItems[i];
            }
            foreach (var item in silinme)
            {
                isimliste.Items.Remove(item);
            }
        }

        private void isimliste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string[] silinme = new string[isimliste.SelectedItems.Count];
                for (int i = 0; i < isimliste.SelectedItems.Count; i++)
                {
                    silinme[i] = (string)isimliste.SelectedItems[i];
                }
                foreach (var item in silinme)
                {
                    isimliste.Items.Remove(item);
                }
            }
        }
    }
}
