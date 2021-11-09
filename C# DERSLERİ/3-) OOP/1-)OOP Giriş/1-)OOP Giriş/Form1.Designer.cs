namespace _1__OOP_Giriş
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
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.dtpdogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "İSİM: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "SOYİSİM: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "DOĞUM TARİHİ: ";
            // 
            // txtisim
            // 
            this.txtisim.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtisim.Location = new System.Drawing.Point(266, 6);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(228, 38);
            this.txtisim.TabIndex = 0;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtsoyisim.Location = new System.Drawing.Point(266, 50);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(228, 38);
            this.txtsoyisim.TabIndex = 1;
            // 
            // btnekle
            // 
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnekle.Location = new System.Drawing.Point(266, 135);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(228, 42);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dtpdogumtarihi
            // 
            this.dtpdogumtarihi.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold);
            this.dtpdogumtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdogumtarihi.Location = new System.Drawing.Point(266, 94);
            this.dtpdogumtarihi.Name = "dtpdogumtarihi";
            this.dtpdogumtarihi.Size = new System.Drawing.Size(228, 38);
            this.dtpdogumtarihi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 193);
            this.Controls.Add(this.dtpdogumtarihi);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DateTimePicker dtpdogumtarihi;
    }
}

