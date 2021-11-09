using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication39_usercontrols
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlisim.label1.Text = "İSİM : ";
            ctrlsoyisim.label1.Text = "SOYİSİM : ";
            ctrladres.label1.Text = "ADRES : ";
            ctrltelefon.label1.Text = "TELEFON : ";
        }

        private void btniseal_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = ctrlisim.textBox1.Text;
            lvi.SubItems.Add(ctrlsoyisim.textBox1.Text);
            lvi.SubItems.Add(ctrladres.textBox1.Text);
            lvi.SubItems.Add(ctrltelefon.textBox1.Text);
            listView1.Items.Add(lvi);
        }
    }
}
