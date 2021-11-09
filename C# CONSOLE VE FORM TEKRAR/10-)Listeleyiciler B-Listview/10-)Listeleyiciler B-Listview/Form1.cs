using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10__Listeleyiciler_B_Listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string isimsoyisim = txtisim.Text;
            string telno = mtxttel.Text;
            string tcno = mtxttc.Text;
            string yas = nudyas.Value.ToString();
            string meslek = cbmeslek.Text;
            string maas = nudmaas.Value.ToString();
            ListViewItem lvi = new ListViewItem();
            lvi.Text = isimsoyisim;
            lvi.SubItems.Add(telno);
            lvi.SubItems.Add(tcno);
            lvi.SubItems.Add(yas);
            lvi.SubItems.Add(meslek);
            lvi.SubItems.Add(string.Format("{0} TL",maas));
            lvliste.Items.Add(lvi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string isimsoyisim = "Hakan ÇELEBİ";
            string telno = "(538) 017 8740";
            string tcno = "14501321120";
            string yas = "19";
            string meslek = "PATRON";
            string maas = "35000";
            ListViewItem lvi = new ListViewItem();
            lvi.Text = isimsoyisim;
            lvi.SubItems.Add(telno);
            lvi.SubItems.Add(tcno);
            lvi.SubItems.Add(yas);
            lvi.SubItems.Add(meslek);
            lvi.SubItems.Add(string.Format("{0} TL", maas));
            lvliste.Items.Add(lvi);

            string isimsoyisim1 = "Abdullah ALTUNKAYNAK";
            string telno1 = "(507) 798 9755";
            string tcno1 = "18971448530";
            string yas1 = "20";
            string meslek1 = "CEO";
            string maas1 = "35000";
            ListViewItem lvi1 = new ListViewItem();
            lvi1.Text = isimsoyisim1;
            lvi1.SubItems.Add(telno1);
            lvi1.SubItems.Add(tcno1);
            lvi1.SubItems.Add(yas1);
            lvi1.SubItems.Add(meslek1);
            lvi1.SubItems.Add(string.Format("{0} TL", maas1));
            lvliste.Items.Add(lvi1);

            string isimsoyisim2 = "Halil Emre BALABAN";
            string telno2 = "(541) 592 8329";
            string tcno2 = "54925132100";
            string yas2 = "18";
            string meslek2 = "CEO";
            string maas2 = "35000";
            ListViewItem lvi2 = new ListViewItem();
            lvi2.Text = isimsoyisim2;
            lvi2.SubItems.Add(telno2);
            lvi2.SubItems.Add(tcno2);
            lvi2.SubItems.Add(yas2);
            lvi2.SubItems.Add(meslek2);
            lvi2.SubItems.Add(string.Format("{0} TL", maas2));
            lvliste.Items.Add(lvi2);

            nudyas.ResetText();
            nudmaas.ResetText();
        }
    }
}
