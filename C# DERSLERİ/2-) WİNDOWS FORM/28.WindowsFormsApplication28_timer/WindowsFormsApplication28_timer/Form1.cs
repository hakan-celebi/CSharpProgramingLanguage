using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication28_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double salise = 0;
        double saniye = 0;
        double dakika = 0;
        string ksalise;
        string ksaniye;
        string kdakika;
        private void btnkstart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnkpause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnkrestart_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblkronometre.ResetText();
            lblkronometre.Text = "00:00:00";
            salise = 0;
            saniye = 0;
            dakika = 0;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            if (salise == 65)
            {
                saniye++;
                salise = 0;
            }
            if (saniye == 60)
            {
                dakika++;
                saniye = 0;
            }
            if (salise < 10)
            {
                ksalise = "0" + salise;
            }
            else
            {
                ksalise = salise.ToString();
            }
            if (saniye < 10)
            {
                ksaniye = "0" + saniye + ":";
            }
            else
            {
                ksaniye = saniye.ToString() + ":";
            }
            if (dakika < 10)
            {
                kdakika = "0" + dakika + ":";
            }
            else
            {
                kdakika = dakika.ToString() + ":";
            }
            lblkronometre.Text = kdakika + ksaniye + ksalise;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int geridakika = Convert.ToInt32(txtgeridakika.Text);
            int gerisaniye = Convert.ToInt32(txtgerisaniye.Text);
            int gerisalise = Convert.ToInt32(txtgerisalise.Text);
            string geridakikas;
            string gerisaniyes;
            string gerisalises = "00";
            
            if (geridakika > 0 && gerisaniye == 0 && gerisalise == 0)
            {
                gerisaniye = 59;
                txtgerisaniye.Text = "59";
                gerisalise = 65;
                txtgerisalise.Text = "65";
            }
            else if (gerisaniye > 0 && gerisalise == 0)
            {
                gerisalise = 65;
                gerisalise--;
            }
            if (gerisalise == 0 && gerisaniye > 0)
            {
                gerisaniye--;
                gerisalise = 65;
            }
            if (gerisaniye == 0 && geridakika > 0)
            {
                geridakika--;
                gerisaniye = 60;
            }
            if (geridakika == 0)
            {
                geridakikas = "00:";
            }
            if (gerisaniye == 0)
            {
                gerisaniyes = "00:";
            }
            if (gerisalise == 0)
            {
                gerisalises = "00";
            }
            if (geridakika < 10 && geridakika > 0)
            {
                geridakikas = "0" + geridakika + ":";
            }
            else
            {
                geridakikas = geridakika + ":";
            }
            if (gerisaniye < 10 && gerisaniye > 0)
            {
                gerisaniyes = "0" + gerisaniye + ":";
            }
            else
            {
                gerisaniyes = gerisaniye + ":";
            }
            if (gerisalise < 10 && gerisalise > 0)
            {
                gerisalises = "0" + gerisalise;
            }
            else
            {
                gerisalises = gerisalise.ToString();
            }
            gerisalise--;
            lblgerisayim.Text = geridakikas + gerisaniyes + gerisalises;
        }

        private void btngstart_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btngpause_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
    }
}
