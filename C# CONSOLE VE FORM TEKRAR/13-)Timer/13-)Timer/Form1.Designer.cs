namespace _13__Timer
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
            this.components = new System.ComponentModel.Container();
            this.btnbasla = new System.Windows.Forms.Button();
            this.lblsaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbldakika = new System.Windows.Forms.Label();
            this.lblsaniye = new System.Windows.Forms.Label();
            this.btndurdur = new System.Windows.Forms.Button();
            this.btnsifirla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbasla
            // 
            this.btnbasla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbasla.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbasla.Location = new System.Drawing.Point(12, 90);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(153, 55);
            this.btnbasla.TabIndex = 0;
            this.btnbasla.Text = "BAŞLA";
            this.btnbasla.UseVisualStyleBackColor = true;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsaat.Font = new System.Drawing.Font("Segoe MDL2 Assets", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaat.ForeColor = System.Drawing.Color.DimGray;
            this.lblsaat.Location = new System.Drawing.Point(87, 178);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(117, 64);
            this.lblsaat.TabIndex = 1;
            this.lblsaat.Text = "00 :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbldakika
            // 
            this.lbldakika.AutoSize = true;
            this.lbldakika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldakika.Font = new System.Drawing.Font("Segoe MDL2 Assets", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldakika.ForeColor = System.Drawing.Color.DimGray;
            this.lbldakika.Location = new System.Drawing.Point(210, 178);
            this.lbldakika.Name = "lbldakika";
            this.lbldakika.Size = new System.Drawing.Size(117, 64);
            this.lbldakika.TabIndex = 1;
            this.lbldakika.Text = "00 :";
            // 
            // lblsaniye
            // 
            this.lblsaniye.AutoSize = true;
            this.lblsaniye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsaniye.Font = new System.Drawing.Font("Segoe MDL2 Assets", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaniye.ForeColor = System.Drawing.Color.DimGray;
            this.lblsaniye.Location = new System.Drawing.Point(333, 178);
            this.lblsaniye.Name = "lblsaniye";
            this.lblsaniye.Size = new System.Drawing.Size(84, 64);
            this.lblsaniye.TabIndex = 1;
            this.lblsaniye.Text = "00";
            // 
            // btndurdur
            // 
            this.btndurdur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndurdur.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndurdur.Location = new System.Drawing.Point(171, 90);
            this.btndurdur.Name = "btndurdur";
            this.btndurdur.Size = new System.Drawing.Size(153, 55);
            this.btndurdur.TabIndex = 0;
            this.btndurdur.Text = "DURDUR";
            this.btndurdur.UseVisualStyleBackColor = true;
            this.btndurdur.Click += new System.EventHandler(this.btndurdur_Click);
            // 
            // btnsifirla
            // 
            this.btnsifirla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsifirla.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsifirla.Location = new System.Drawing.Point(330, 90);
            this.btnsifirla.Name = "btnsifirla";
            this.btnsifirla.Size = new System.Drawing.Size(153, 55);
            this.btnsifirla.TabIndex = 0;
            this.btnsifirla.Text = "SIFIRLA";
            this.btnsifirla.UseVisualStyleBackColor = true;
            this.btnsifirla.Click += new System.EventHandler(this.btnsifirla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "KRONOMETRE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsaniye);
            this.Controls.Add(this.lbldakika);
            this.Controls.Add(this.lblsaat);
            this.Controls.Add(this.btnsifirla);
            this.Controls.Add(this.btndurdur);
            this.Controls.Add(this.btnbasla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbldakika;
        private System.Windows.Forms.Label lblsaniye;
        private System.Windows.Forms.Button btndurdur;
        private System.Windows.Forms.Button btnsifirla;
        private System.Windows.Forms.Label label1;
    }
}

