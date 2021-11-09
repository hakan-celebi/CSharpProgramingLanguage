using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication27_dialogwindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            //Bütün dialog pencerelerinin 'Show' veya 'ShowDialog' isminde metodları bulunur. Bu metodlar dialog pencerelerini açmayı sağlar.
            //Tüm dialog pencereleri geriye 'DialogResault' tipinde değer gönderir.
            //MessageBox.Show : Bir dialog penceresidir.
            //FontDialog.Font özelliği içerisinde fontdialog penceresinden seçilen font değerleri tutulur.
            //InitialDiractor özelliği varsayılan dosya konumunu açmayı sağlar.
            //SafeFileName : Sadece dosya adı ve uzantısını verir.
            //FolderBrowserDialog.FolderPath : Uzantı ismini almaya yarıyor.
            //ForeColor yazı rengini değiştirmeye yarar.
            DialogResult fontsecilen = fontDialog1.ShowDialog();
            if (fontsecilen == DialogResult.OK)
            {
                lbldenemetahtasi.Font = fontDialog1.Font;
            }
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpeg)|*.jpeg|Jpg Dosyası (*.jpg)|*.jpg";
            openFileDialog1.Title = "BİR RESİM EKLEYİNİZ";
            openFileDialog1.InitialDirectory = @"C:\Users\duzeybilisim2\Desktop\";
            DialogResult dosyasecilen = openFileDialog1.ShowDialog();
            if (dosyasecilen == DialogResult.OK)
            {
                lbldenemetahtasi.Text = openFileDialog1.FileName;
                lbldenemetahtasi2.Text = openFileDialog1.SafeFileName;
            }
        }

        private void btnsavefile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "KAYDEDİLECEK YERİ SEÇİNİZ...";
            DialogResult kaydetsecilen = saveFileDialog1.ShowDialog();
            if (kaydetsecilen == DialogResult.OK)
            {
                lbldenemetahtasi.Text = saveFileDialog1.FileName;
            }
        }

        private void btnfolder_Click(object sender, EventArgs e)
        {
            DialogResult foldersecilen = folderBrowserDialog1.ShowDialog();
            if (foldersecilen == DialogResult.OK)
            {
                lbldenemetahtasi2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            DialogResult renksecenek = colorDialog1.ShowDialog();
            if (renksecenek == DialogResult.OK)
            {
                lbldenemetahtasi.ForeColor = colorDialog1.Color;
            }
        }
    }
}
