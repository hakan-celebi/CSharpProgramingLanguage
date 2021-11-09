using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21__Background_Worker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        int a = 0;
        int b = 0;

        private void btnbasla1_Click(object sender, EventArgs e)
        {
            /*TİMER İLE
            timer1.Start();*/
            if (backgroundWorker1.IsBusy)
            {
                return;
            }
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnbasla2_Click(object sender, EventArgs e)
        {
            /*TİMER İLE
            timer2.Start();*/
            if (backgroundWorker2.IsBusy)
            {
                return;
            }
            backgroundWorker2.RunWorkerAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*TİMER İLE
            a++;
            lblsn1.Text = a.ToString();*/
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*b++;
            lblsn2.Text = b.ToString();*/
        }

        private void btndurdur1_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            //kont2 = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.CancelAsync();
        }

        private void btndurdur2_Click(object sender, EventArgs e)
        {
            //timer2.Stop();
            //kont2 = true;
            backgroundWorker2.WorkerSupportsCancellation = true;
            backgroundWorker2.CancelAsync();
        }

        private void btnsifirla1_Click(object sender, EventArgs e)
        {
            /*a = 0;
            lblsn1.Text = "0";
            timer1.Stop();*/
            kont = true;
            if (kont2 == true)
            {
                lblsn1.Text = "0";
                kont = false;
            }
            kont2 = false;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.CancelAsync();
            sayac = 0;
        }

        private void btnsifirla2_Click(object sender, EventArgs e)
        {
            /*b = 0;
            lblsn2.Text = "0";
            timer2.Stop();*/
            kont = true;
            if (kont2 == true)
            {
                lblsn2.Text = "0";
                kont = false;
            }
            kont2 = false;
            backgroundWorker2.WorkerSupportsCancellation = true;
            backgroundWorker2.CancelAsync();
            sayac1 = 0;
        }

        int sayac = 0;
        int sayac1 = 0;
        bool kont = false;
        bool kont2 = false;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (sayac < 100000)
            {
                sayac++;
                lblsn1.Text = sayac.ToString();
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    if (kont == true)
                    {
                        lblsn1.Text = "0";
                    }
                    kont = false;
                    kont2 = true;
                    return;
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (sayac1 < 100000)
            {
                sayac1++;
                lblsn2.Text = sayac1.ToString();
                if (backgroundWorker2.CancellationPending)
                {
                    e.Cancel = true;
                    if (kont == true)
                    {
                        lblsn2.Text = "0";
                    }
                    kont2 = true;
                    kont = false;
                    return;
                }
            }
        }
    }
}
