namespace _7__Hesap_Makinesi_Uygulaması
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.cbislem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "HESAP MAKİNESİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "SAYI GİRİNİZ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "SAYI GİRİNİZ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-4, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "İŞLEM SEÇİNİZ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(62, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "SONUÇ: ";
            // 
            // btnhesapla
            // 
            this.btnhesapla.BackColor = System.Drawing.Color.White;
            this.btnhesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhesapla.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.ForeColor = System.Drawing.Color.Red;
            this.btnhesapla.Location = new System.Drawing.Point(17, 292);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(383, 67);
            this.btnhesapla.TabIndex = 3;
            this.btnhesapla.Text = "HESAPLA";
            this.btnhesapla.UseVisualStyleBackColor = false;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // txtsayi1
            // 
            this.txtsayi1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsayi1.Location = new System.Drawing.Point(134, 120);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(168, 31);
            this.txtsayi1.TabIndex = 0;
            // 
            // txtsayi2
            // 
            this.txtsayi2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsayi2.Location = new System.Drawing.Point(134, 228);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(168, 31);
            this.txtsayi2.TabIndex = 2;
            // 
            // txtsonuc
            // 
            this.txtsonuc.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsonuc.Location = new System.Drawing.Point(134, 383);
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.ReadOnly = true;
            this.txtsonuc.Size = new System.Drawing.Size(168, 31);
            this.txtsonuc.TabIndex = 4;
            // 
            // cbislem
            // 
            this.cbislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbislem.Font = new System.Drawing.Font("Impact", 14.25F);
            this.cbislem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbislem.FormattingEnabled = true;
            this.cbislem.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbislem.Location = new System.Drawing.Point(134, 178);
            this.cbislem.Name = "cbislem";
            this.cbislem.Size = new System.Drawing.Size(168, 31);
            this.cbislem.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnhesapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.cbislem);
            this.Controls.Add(this.txtsonuc);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HESAP MAKİNESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.ComboBox cbislem;
    }
}

