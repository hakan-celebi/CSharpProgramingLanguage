using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication40_mdiforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]

        static extern IntPtr SetParent(IntPtr child, IntPtr newParent);

        [DllImport("user32.dll")]

        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]

        [return: MarshalAs(UnmanagedType.Bool)]

        private static extern bool IsWindowVisible(IntPtr hWnd);

        private const int WM_SYSCOMMAND = 274;

        private const int SC_MAXIMIZE = 61488;

        private void pERSONELLERToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            smipersonel.ForeColor = Color.OrangeRed;
        }

        private void mÜŞTERİLERToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            smimüsteri.ForeColor = Color.OrangeRed;
        }

        private void tEDARİKÇİLERToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            smitedarikci.ForeColor = Color.OrangeRed;
        }

        private void yÖNETİMToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            smiyonetim.ForeColor = Color.OrangeRed;
        }

        private void rAPORLARToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            smirapor.ForeColor = Color.OrangeRed;
        }

        private void smipersonel_MouseLeave(object sender, EventArgs e)
        {
            smipersonel.ForeColor = Color.Cornsilk;
        }

        private void smimüsteri_MouseLeave(object sender, EventArgs e)
        {
            smimüsteri.ForeColor = Color.Cornsilk;
        }

        private void smiyonetim_MouseLeave(object sender, EventArgs e)
        {
            smiyonetim.ForeColor = Color.Cornsilk;
        }

        private void smirapor_MouseLeave(object sender, EventArgs e)
        {
            smirapor.ForeColor = Color.Cornsilk;
        }

        private void smitedarikci_MouseLeave(object sender, EventArgs e)
        {
            smitedarikci.ForeColor = Color.Cornsilk;
        }

        private void smipersonel_Click(object sender, EventArgs e)
        {
            //Eğer herhangi bir formu mdi form olarak açmak istiyorsak show metodu ile açmalıyız ve showdialog kullanamayız.
            PersonelForm pf = new PersonelForm();
            pf.MdiParent = this;
            pf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        MusteriForm mf = new MusteriForm();
        private void smimüsteri_Click(object sender, EventArgs e)
        {
            mf.MdiParent = this;
            if (!mf.IsDisposed)
            {
                mf.Show();
                string exeyolu = @"C:\Program Files\Adobe\Adobe Photoshop CC (64 Bit)\Photoshop.exe";

                Process calistir = Process.Start(exeyolu);

                while (calistir.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(calistir.MainWindowHandle))

                {

                    System.Threading.Thread.Sleep(10);

                    calistir.Refresh();
                }
                calistir.WaitForInputIdle();
                SetParent(calistir.MainWindowHandle, this.mf.Handle);
                SendMessage(calistir.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
            }
        }
    }
}
