namespace _21__Background_Worker
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
            this.lblsn1 = new System.Windows.Forms.Label();
            this.lblsn2 = new System.Windows.Forms.Label();
            this.btnbasla1 = new System.Windows.Forms.Button();
            this.btndurdur1 = new System.Windows.Forms.Button();
            this.btnsifirla1 = new System.Windows.Forms.Button();
            this.btnbasla2 = new System.Windows.Forms.Button();
            this.btndurdur2 = new System.Windows.Forms.Button();
            this.btnsifirla2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblsn1
            // 
            this.lblsn1.AutoSize = true;
            this.lblsn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsn1.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsn1.Location = new System.Drawing.Point(71, 9);
            this.lblsn1.Name = "lblsn1";
            this.lblsn1.Size = new System.Drawing.Size(36, 43);
            this.lblsn1.TabIndex = 0;
            this.lblsn1.Text = "0";
            // 
            // lblsn2
            // 
            this.lblsn2.AutoSize = true;
            this.lblsn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsn2.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsn2.Location = new System.Drawing.Point(289, 9);
            this.lblsn2.Name = "lblsn2";
            this.lblsn2.Size = new System.Drawing.Size(36, 43);
            this.lblsn2.TabIndex = 0;
            this.lblsn2.Text = "0";
            // 
            // btnbasla1
            // 
            this.btnbasla1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbasla1.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnbasla1.Location = new System.Drawing.Point(12, 55);
            this.btnbasla1.Name = "btnbasla1";
            this.btnbasla1.Size = new System.Drawing.Size(155, 51);
            this.btnbasla1.TabIndex = 1;
            this.btnbasla1.Text = "BAŞLA";
            this.btnbasla1.UseVisualStyleBackColor = true;
            this.btnbasla1.Click += new System.EventHandler(this.btnbasla1_Click);
            // 
            // btndurdur1
            // 
            this.btndurdur1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndurdur1.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btndurdur1.Location = new System.Drawing.Point(12, 112);
            this.btndurdur1.Name = "btndurdur1";
            this.btndurdur1.Size = new System.Drawing.Size(155, 51);
            this.btndurdur1.TabIndex = 1;
            this.btndurdur1.Text = "DURDUR";
            this.btndurdur1.UseVisualStyleBackColor = true;
            this.btndurdur1.Click += new System.EventHandler(this.btndurdur1_Click);
            // 
            // btnsifirla1
            // 
            this.btnsifirla1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsifirla1.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnsifirla1.Location = new System.Drawing.Point(12, 169);
            this.btnsifirla1.Name = "btnsifirla1";
            this.btnsifirla1.Size = new System.Drawing.Size(155, 51);
            this.btnsifirla1.TabIndex = 1;
            this.btnsifirla1.Text = "SIFIRLA";
            this.btnsifirla1.UseVisualStyleBackColor = true;
            this.btnsifirla1.Click += new System.EventHandler(this.btnsifirla1_Click);
            // 
            // btnbasla2
            // 
            this.btnbasla2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbasla2.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnbasla2.Location = new System.Drawing.Point(225, 55);
            this.btnbasla2.Name = "btnbasla2";
            this.btnbasla2.Size = new System.Drawing.Size(155, 51);
            this.btnbasla2.TabIndex = 1;
            this.btnbasla2.Text = "BAŞLA";
            this.btnbasla2.UseVisualStyleBackColor = true;
            this.btnbasla2.Click += new System.EventHandler(this.btnbasla2_Click);
            // 
            // btndurdur2
            // 
            this.btndurdur2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndurdur2.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btndurdur2.Location = new System.Drawing.Point(225, 112);
            this.btndurdur2.Name = "btndurdur2";
            this.btndurdur2.Size = new System.Drawing.Size(155, 51);
            this.btndurdur2.TabIndex = 1;
            this.btndurdur2.Text = "DURDUR";
            this.btndurdur2.UseVisualStyleBackColor = true;
            this.btndurdur2.Click += new System.EventHandler(this.btndurdur2_Click);
            // 
            // btnsifirla2
            // 
            this.btnsifirla2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsifirla2.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnsifirla2.Location = new System.Drawing.Point(225, 169);
            this.btnsifirla2.Name = "btnsifirla2";
            this.btnsifirla2.Size = new System.Drawing.Size(155, 51);
            this.btnsifirla2.TabIndex = 1;
            this.btnsifirla2.Text = "SIFIRLA";
            this.btnsifirla2.UseVisualStyleBackColor = true;
            this.btnsifirla2.Click += new System.EventHandler(this.btnsifirla2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 250);
            this.Controls.Add(this.btnsifirla2);
            this.Controls.Add(this.btnsifirla1);
            this.Controls.Add(this.btndurdur2);
            this.Controls.Add(this.btndurdur1);
            this.Controls.Add(this.btnbasla2);
            this.Controls.Add(this.btnbasla1);
            this.Controls.Add(this.lblsn2);
            this.Controls.Add(this.lblsn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsn1;
        private System.Windows.Forms.Label lblsn2;
        private System.Windows.Forms.Button btnbasla1;
        private System.Windows.Forms.Button btndurdur1;
        private System.Windows.Forms.Button btnsifirla1;
        private System.Windows.Forms.Button btnbasla2;
        private System.Windows.Forms.Button btndurdur2;
        private System.Windows.Forms.Button btnsifirla2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

