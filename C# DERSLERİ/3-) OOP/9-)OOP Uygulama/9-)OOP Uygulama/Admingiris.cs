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
    public partial class Admingiris : Form
    {
        public Admingiris()
        {
            InitializeComponent();
        }

        private void btnadmingyap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (txtadminkadi.Text.Trim() != string.Empty && txtadminprl.Text.Trim() != string.Empty)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("LÜTFEN GEREKLİ ALANLARI DOLDURUNUZ.");
            }
        }
    }
}
