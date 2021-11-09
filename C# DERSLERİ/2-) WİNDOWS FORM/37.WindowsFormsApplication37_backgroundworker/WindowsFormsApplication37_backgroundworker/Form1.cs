using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication37_backgroundworker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //İşlem parçacıklarının birbirine karışmasını engellemek için kullanılır.
            CheckForIllegalCrossThreadCalls = false;
        }
        int sayac1 = 0, sayac2 = 0;
        int deger1 = 0, deger2 = 0;

        private void btndurdur1_Click(object sender, EventArgs e)
        {
            //BackGroundWorker in iptal etme özelliğini true yapar.
            backgroundWorker2.WorkerSupportsCancellation = true;
            //BackGroundWorker i iptal eder ama yeterli kalmaz.
            backgroundWorker2.CancelAsync();
        }

        private void btnbaslat2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (sayac2 < 100000)
            {
                sayac2++;
                deger2++;
                label2.Text = sayac2.ToString();
                //BackGroundWorker while'ın içine giremediği için cancel geldiyse DoWorkEventArgs özelliğini cancel yapar.
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (sayac1 < 100000)
            {
                sayac1++;
                deger1++;
                label1.Text = sayac1.ToString();
                if (backgroundWorker2.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void btndurdur2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.CancelAsync();
        }

        private void btnbaslat1_Click(object sender, EventArgs e)
        {
            if (backgroundWorker2.IsBusy == false)
            {
                backgroundWorker2.RunWorkerAsync();
            }
        }
    }
}
