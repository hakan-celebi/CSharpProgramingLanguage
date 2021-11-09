namespace WindowsFormsApplication27_dialogwindows
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbldenemetahtasi = new System.Windows.Forms.Label();
            this.btnfont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnopen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbldenemetahtasi2 = new System.Windows.Forms.Label();
            this.btnsavefile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnfolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btncolor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lbldenemetahtasi
            // 
            this.lbldenemetahtasi.AutoSize = true;
            this.lbldenemetahtasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldenemetahtasi.Location = new System.Drawing.Point(7, 161);
            this.lbldenemetahtasi.Name = "lbldenemetahtasi";
            this.lbldenemetahtasi.Size = new System.Drawing.Size(226, 25);
            this.lbldenemetahtasi.TabIndex = 0;
            this.lbldenemetahtasi.Text = "PAMBLY COMPANY";
            // 
            // btnfont
            // 
            this.btnfont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfont.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfont.ForeColor = System.Drawing.Color.Coral;
            this.btnfont.Location = new System.Drawing.Point(12, 12);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(119, 43);
            this.btnfont.TabIndex = 1;
            this.btnfont.Text = "FONT";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // btnopen
            // 
            this.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.btnopen.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnopen.Location = new System.Drawing.Point(137, 12);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(112, 43);
            this.btnopen.TabIndex = 2;
            this.btnopen.Text = "OPEN FİLE";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\duzeybilisim2\\Desktop\\";
            // 
            // lbldenemetahtasi2
            // 
            this.lbldenemetahtasi2.AutoSize = true;
            this.lbldenemetahtasi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldenemetahtasi2.Location = new System.Drawing.Point(7, 270);
            this.lbldenemetahtasi2.Name = "lbldenemetahtasi2";
            this.lbldenemetahtasi2.Size = new System.Drawing.Size(226, 25);
            this.lbldenemetahtasi2.TabIndex = 0;
            this.lbldenemetahtasi2.Text = "PAMBLY COMPANY";
            // 
            // btnsavefile
            // 
            this.btnsavefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsavefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.btnsavefile.ForeColor = System.Drawing.Color.Crimson;
            this.btnsavefile.Location = new System.Drawing.Point(255, 12);
            this.btnsavefile.Name = "btnsavefile";
            this.btnsavefile.Size = new System.Drawing.Size(118, 43);
            this.btnsavefile.TabIndex = 2;
            this.btnsavefile.Text = "SAVE FİLE";
            this.btnsavefile.UseVisualStyleBackColor = true;
            this.btnsavefile.Click += new System.EventHandler(this.btnsavefile_Click);
            // 
            // btnfolder
            // 
            this.btnfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.btnfolder.ForeColor = System.Drawing.Color.Cyan;
            this.btnfolder.Location = new System.Drawing.Point(379, 12);
            this.btnfolder.Name = "btnfolder";
            this.btnfolder.Size = new System.Drawing.Size(145, 43);
            this.btnfolder.TabIndex = 2;
            this.btnfolder.Text = "FOLDER BROWSER";
            this.btnfolder.UseVisualStyleBackColor = true;
            this.btnfolder.Click += new System.EventHandler(this.btnfolder_Click);
            // 
            // btncolor
            // 
            this.btncolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.btncolor.ForeColor = System.Drawing.Color.DarkGray;
            this.btncolor.Location = new System.Drawing.Point(530, 12);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(140, 43);
            this.btncolor.TabIndex = 2;
            this.btncolor.Text = "COLOR DİALOG";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(921, 473);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.btnfolder);
            this.Controls.Add(this.btnsavefile);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.lbldenemetahtasi2);
            this.Controls.Add(this.lbldenemetahtasi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldenemetahtasi;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbldenemetahtasi2;
        private System.Windows.Forms.Button btnsavefile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnfolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

