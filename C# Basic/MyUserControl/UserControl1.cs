using System;
using System.Windows.Forms;

namespace MyUserControl
{
    public partial class GettingInputWithUserControl : UserControl
    {
        public int CharLenght 
        {
            get
            {
                int charLenght = 0; int dotLenght; int spaceLenght;
                dotLenght = txtInput.Text.Split('.').Length - 1;
                spaceLenght = txtInput.Text.Split(' ').Length - 1;
                charLenght = txtInput.Text.Length - (dotLenght + spaceLenght);
                return charLenght;
            }
        }
        public GettingInputWithUserControl()
        {
            InitializeComponent();
        }
    }
}
