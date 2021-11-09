using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication21_ornekprogram3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            string isim = txtisim.Text;
            int kilo = Convert.ToInt32(txtkilo.Text);
            if (kilo < 50)
            {
                lstzayif.Items.Add(isim);
            }
            else if (kilo >= 50 && kilo < 80)
            {
                lstorta.Items.Add(isim);
            }
            else if (kilo >= 80)
            {
                lstkilolu.Items.Add(isim);
            }
            txtisim.Focus();
        }
    }
}
