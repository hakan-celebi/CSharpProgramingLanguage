namespace _6__Windows_Form_a_Giriş
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
            this.btnTikla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtilksayi = new System.Windows.Forms.TextBox();
            this.txtikincisayi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTikla
            // 
            this.btnTikla.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTikla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTikla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTikla.ForeColor = System.Drawing.Color.Maroon;
            this.btnTikla.Location = new System.Drawing.Point(97, 177);
            this.btnTikla.Name = "btnTikla";
            this.btnTikla.Size = new System.Drawing.Size(86, 30);
            this.btnTikla.TabIndex = 2;
            this.btnTikla.Text = "HESAPLA";
            this.btnTikla.UseVisualStyleBackColor = false;
            this.btnTikla.Click += new System.EventHandler(this.btnTikla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İKİNCİ SAYI: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "İLK SAYI: ";
            // 
            // txtilksayi
            // 
            this.txtilksayi.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtilksayi.Location = new System.Drawing.Point(97, 79);
            this.txtilksayi.Name = "txtilksayi";
            this.txtilksayi.Size = new System.Drawing.Size(100, 25);
            this.txtilksayi.TabIndex = 0;
            // 
            // txtikincisayi
            // 
            this.txtikincisayi.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtikincisayi.Location = new System.Drawing.Point(97, 131);
            this.txtikincisayi.Name = "txtikincisayi";
            this.txtikincisayi.Size = new System.Drawing.Size(100, 25);
            this.txtikincisayi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "TOPLAMA HESAP MAKİNESİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(31, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "SONUÇ: ";
            // 
            // txtsonuc
            // 
            this.txtsonuc.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtsonuc.Location = new System.Drawing.Point(97, 233);
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(100, 25);
            this.txtsonuc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTikla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 295);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsonuc);
            this.Controls.Add(this.txtikincisayi);
            this.Controls.Add(this.txtilksayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTikla);
            this.Name = "Form1";
            this.Text = "HESAP MAKİNESİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTikla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtilksayi;
        private System.Windows.Forms.TextBox txtikincisayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsonuc;
    }
}

