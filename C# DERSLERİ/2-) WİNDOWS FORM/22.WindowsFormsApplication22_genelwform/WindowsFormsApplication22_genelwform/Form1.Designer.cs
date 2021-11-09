namespace WindowsFormsApplication22_genelwform
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
            this.mtbtc = new System.Windows.Forms.MaskedTextBox();
            this.btngonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC KİMLİK : ";
            // 
            // mtbtc
            // 
            this.mtbtc.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold);
            this.mtbtc.Location = new System.Drawing.Point(144, 28);
            this.mtbtc.Mask = "00000000000";
            this.mtbtc.Name = "mtbtc";
            this.mtbtc.Size = new System.Drawing.Size(199, 32);
            this.mtbtc.TabIndex = 0;
            // 
            // btngonder
            // 
            this.btngonder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btngonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngonder.Location = new System.Drawing.Point(268, 80);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(75, 32);
            this.btngonder.TabIndex = 1;
            this.btngonder.Text = "GÖNDER";
            this.btngonder.UseVisualStyleBackColor = false;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btngonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 143);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.mtbtc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbtc;
        private System.Windows.Forms.Button btngonder;
    }
}

