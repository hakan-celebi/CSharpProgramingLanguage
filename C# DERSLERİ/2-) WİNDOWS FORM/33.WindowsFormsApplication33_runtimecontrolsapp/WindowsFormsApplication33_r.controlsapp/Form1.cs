using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication33_r.controlsapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void olusturma(int adet, Control tip)
        {
            flowLayoutPanel1.Controls.Add(tip);
        }
        int sayi = 0;
        private void btnolustur_Click(object sender, EventArgs e)
        {
            int kated = Convert.ToInt32(nudadet.Value);
            for (int i = 0; i < kated; i++)
            {
                if (cmbtip.Text == "Button")
                {
                    sayi++;
                    Button btn = new Button();
                    olusturma(kated, btn);
                    btn.Text = string.Format("{0}.Button",sayi);
                    btn.Width = 100;
                    btn.Height = 50;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.White;
                    btn.Font = new Font("Tahoma", 12);
                    btn.ForeColor = Color.Gray;
                    btn.Margin = new Padding(5, 5, 0, 0);
                    if (btn.Bottom > flowLayoutPanel1.Height)
                    {
                        flowLayoutPanel1.Height = btn.Bottom + 50;
                        this.Height = flowLayoutPanel1.Height + 130;
                    }
                    if (btn.Bottom > 1080)
                    {
                        flowLayoutPanel1.Width = 1575;
                        this.Width = 1575;
                        flowLayoutPanel1.Height = 1080;
                        this.Height = 1080;
                    }
                    btn.MouseHover += Btn_MouseHover;
                    btn.MouseLeave += Btn_MouseLeave;
                    btn.Click += Btn_Click;
                }
                else if (cmbtip.Text == "TextBox")
                {
                    TextBox txt = new TextBox();
                    olusturma(kated, txt);
                }
                else if (cmbtip.Text == "ComboBox")
                {
                    ComboBox cmb = new ComboBox();
                    olusturma(kated, cmb);
                }
                else if (cmbtip.Text == "PictureBox")
                {
                    PictureBox pcb = new PictureBox();
                    olusturma(kated, pcb);
                }
                else if (cmbtip.Text == "ListBox")
                {
                    ListBox ltb = new ListBox();
                    olusturma(kated, ltb);
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            Button gelinenbtn = sender as Button;
            gelinenbtn.BackColor = Color.OrangeRed;
            gelinenbtn.ForeColor = Color.White;
            MessageBox.Show(string.Format("Tıklanan Buton = {0}", gelinenbtn.Text));
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button gelinenbtn = sender as Button;
            gelinenbtn.BackColor = Color.White;
            gelinenbtn.ForeColor = Color.Gray;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Button gelinenbtn = sender as Button;
            gelinenbtn.BackColor = Color.Gray;
            gelinenbtn.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbtip.SelectedIndex = 0;
        }
    }
}
