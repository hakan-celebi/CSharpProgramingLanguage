using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication30_runtimecontrols
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void btnolustur_Click(object sender, EventArgs e)
        {
            //Runtime anında üretilen bir kontrol'e event atama yöntemi += ile olur. += yazılır daha sonra iki kez tab tuşuna basılır.
            Button btn = new Button();
            this.Controls.Add(btn);
            Random btnyeri = new Random();
            btn.Width = 225;
            btn.Height = 50;
            btn.ForeColor = Color.Orange;
            int x = btnyeri.Next(0, this.ClientSize.Width - btn.Width);
            int y = btnyeri.Next(0, this.ClientSize.Height - btn.Height);
            btn.Left = x;
            btn.Top = y;
            sayac++;
            btn.Text = "BUTTON IS BUILDED THING YOU NEED A NEW BUTTON ? OKAY OKAY THIS BUTTON'S NUMBER IS " + sayac;
            btn.Click += Btn_Click;
        }
        //Object sender içerisinde btn_Click metodunu çalıştıran kontrol bulunur.
        //BringToFront(); : Tıklanan butonu en üste getirir. SentToBack ise en arkaya gönderir.
        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            string tiklananisim = tiklanan.Text;
            tiklanan.BringToFront();
            MessageBox.Show(string.Format("CLICK TO THE BUTTON AGAIN IDIOT !!! IT IS ONLY JOKE DONT WORRY THIS BUTTON NAME IS " + tiklananisim));
        }
    }
}
