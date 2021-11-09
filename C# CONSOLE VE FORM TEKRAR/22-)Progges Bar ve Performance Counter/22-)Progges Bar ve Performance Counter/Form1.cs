using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _22__Progges_Bar_ve_Performance_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbislemci.Value = 100 - (int)performanceCounter1.NextValue();
            pbbellek.Value = (int)performanceCounter2.NextValue();
        }
    }
}
