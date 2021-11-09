using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Ders_3_
{
    public partial class testForm : Form
    {
        public mainForm mForm;
        public testForm()
        {
            InitializeComponent();
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDisposeMainForm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnGoMainForm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
