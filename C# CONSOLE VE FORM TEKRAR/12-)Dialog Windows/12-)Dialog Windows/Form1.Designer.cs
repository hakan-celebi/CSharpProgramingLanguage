namespace _12__Dialog_Windows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnfont = new System.Windows.Forms.Button();
            this.btnrenk = new System.Windows.Forms.Button();
            this.btndosyaac = new System.Windows.Forms.Button();
            this.btngezin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnfont
            // 
            this.btnfont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfont.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfont.ForeColor = System.Drawing.Color.Maroon;
            this.btnfont.Location = new System.Drawing.Point(58, 12);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(164, 38);
            this.btnfont.TabIndex = 0;
            this.btnfont.Text = "Font Değiştir";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // btnrenk
            // 
            this.btnrenk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrenk.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrenk.ForeColor = System.Drawing.Color.Maroon;
            this.btnrenk.Location = new System.Drawing.Point(228, 12);
            this.btnrenk.Name = "btnrenk";
            this.btnrenk.Size = new System.Drawing.Size(164, 38);
            this.btnrenk.TabIndex = 0;
            this.btnrenk.Text = "Renk Değiştir";
            this.btnrenk.UseVisualStyleBackColor = true;
            this.btnrenk.Click += new System.EventHandler(this.btnrenk_Click);
            // 
            // btndosyaac
            // 
            this.btndosyaac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndosyaac.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndosyaac.ForeColor = System.Drawing.Color.Maroon;
            this.btndosyaac.Location = new System.Drawing.Point(398, 12);
            this.btndosyaac.Name = "btndosyaac";
            this.btndosyaac.Size = new System.Drawing.Size(164, 38);
            this.btndosyaac.TabIndex = 0;
            this.btndosyaac.Text = "Dosya Aç";
            this.btndosyaac.UseVisualStyleBackColor = true;
            this.btndosyaac.Click += new System.EventHandler(this.btndosyaac_Click);
            // 
            // btngezin
            // 
            this.btngezin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngezin.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngezin.ForeColor = System.Drawing.Color.Maroon;
            this.btngezin.Location = new System.Drawing.Point(568, 12);
            this.btngezin.Name = "btngezin";
            this.btngezin.Size = new System.Drawing.Size(164, 38);
            this.btngezin.TabIndex = 0;
            this.btngezin.Text = "Dosya Seç";
            this.btngezin.UseVisualStyleBackColor = true;
            this.btngezin.Click += new System.EventHandler(this.btngezin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 104);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "Masaüstü";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngezin);
            this.Controls.Add(this.btndosyaac);
            this.Controls.Add(this.btnrenk);
            this.Controls.Add(this.btnfont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.Button btnrenk;
        private System.Windows.Forms.Button btndosyaac;
        private System.Windows.Forms.Button btngezin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

