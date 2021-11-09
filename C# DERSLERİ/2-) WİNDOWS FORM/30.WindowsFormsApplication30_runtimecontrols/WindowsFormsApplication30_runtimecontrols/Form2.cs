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

namespace WindowsFormsApplication30_runtimecontrols
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void x20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //10 satır 20 kolonluk bir buton koleksiyonu oluşturacaz.
            //İlk döngü satır için işlem yapacak.
            //İkinci döngü sütun için işlem yapacak.
            //Thread.Sleep(); durdurma.
            butonolusturma(10);
        }

        void butonolusturma(int satirsayisi)
        {
            yavaslat:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Controls.Remove(ctrl);
                    goto yavaslat;
                }
            }
            for (int i = 0; i < satirsayisi; i++)
            {
                for (int t = 0; t < 20; t++)
                {
                    Button eklenecek = new Button();
                    eklenecek.Text = string.Format("{0}X{1}", i + 1, t + 1);
                    eklenecek.Width = 50;
                    eklenecek.Height = 25;
                    eklenecek.Left = t * 50;
                    eklenecek.Top = (i * 25) + 24;

                    this.Controls.Add(eklenecek);
                }
                this.Width = (20 * 50) + 15;
                this.Height = (satirsayisi * 30) + 25;
            }
        }

        private void x20ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            butonolusturma(20);
        }
    }
}
