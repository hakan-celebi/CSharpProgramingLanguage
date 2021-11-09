namespace _5__Polymorphism__Çok_Biçimlilik__
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
            this.btnankara = new System.Windows.Forms.Button();
            this.btnvan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnankara
            // 
            this.btnankara.Location = new System.Drawing.Point(12, 12);
            this.btnankara.Name = "btnankara";
            this.btnankara.Size = new System.Drawing.Size(101, 38);
            this.btnankara.TabIndex = 0;
            this.btnankara.Text = "ANKARA KEDİSİ";
            this.btnankara.UseVisualStyleBackColor = true;
            this.btnankara.Click += new System.EventHandler(this.btnankara_Click);
            // 
            // btnvan
            // 
            this.btnvan.Location = new System.Drawing.Point(119, 12);
            this.btnvan.Name = "btnvan";
            this.btnvan.Size = new System.Drawing.Size(101, 38);
            this.btnvan.TabIndex = 0;
            this.btnvan.Text = "VAN KEDİSİ";
            this.btnvan.UseVisualStyleBackColor = true;
            this.btnvan.Click += new System.EventHandler(this.btnvan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 60);
            this.Controls.Add(this.btnvan);
            this.Controls.Add(this.btnankara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnankara;
        private System.Windows.Forms.Button btnvan;
    }
}

