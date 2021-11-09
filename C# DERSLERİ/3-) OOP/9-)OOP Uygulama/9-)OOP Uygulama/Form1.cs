using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9__OOP_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Urunler[] urn = new Urunler[100];
        int si = 0;

        private void btnadmingiris_Click(object sender, EventArgs e)
        {
            Admingiris admn = new Admingiris();
            DialogResult dadmn = admn.ShowDialog();
            if (dadmn != DialogResult.OK)
            {
                return;
            }
            Admin cadmin = new Admin();
            if (cadmin.adminkadi != null)
            {
                Urunekle uekle = new Urunekle();
                DialogResult duekle = uekle.ShowDialog();
                Urunler urnler = new Urunler();
                if (duekle == DialogResult.OK)
                {
                    if (uekle.lbrenkler.Items.Count > 0 && uekle.lbmodeller.Items.Count > 0 && uekle.lbhitaplar.Items.Count > 0 && uekle.txtfiyatekle.Text.Trim() != string.Empty && uekle.txtkdvekle.Text.Trim() != string.Empty)
                    {
                        urnler.urun = uekle.txturun.Text;
                        for (int i = 0; i < uekle.lbmodeller.Items.Count; i++)
                        {
                            urnler.urunmodeller[i] = uekle.lbmodeller.Items[i].ToString();
                        }

                        for (int i = 0; i < uekle.lbrenkler.Items.Count; i++)
                        {
                            urnler.urunrenkler[i] = uekle.lbrenkler.Items[i].ToString();
                        }

                        for (int i = 0; i < uekle.lbhitaplar.Items.Count; i++)
                        {
                            urnler.urunhitaplar[i] = uekle.lbhitaplar.Items[i].ToString();
                        }
                        urnler.urunfiyat = int.Parse(uekle.txtfiyatekle.Text);
                        urnler.urunkdv = int.Parse(uekle.txtkdvekle.Text);
                        urn[si] = urnler;
                        si++;
                    }
                }
            }
        }
    }
}
