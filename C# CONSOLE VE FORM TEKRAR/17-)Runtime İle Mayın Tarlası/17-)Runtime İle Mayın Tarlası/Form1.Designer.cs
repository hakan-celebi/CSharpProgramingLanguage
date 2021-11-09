namespace _17__Runtime_İle_Mayın_Tarlası
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
            this.btnkolay = new System.Windows.Forms.Button();
            this.btnorta = new System.Windows.Forms.Button();
            this.btnzor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msyeni = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAYIN TARLASI";
            // 
            // btnkolay
            // 
            this.btnkolay.BackColor = System.Drawing.Color.Lime;
            this.btnkolay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkolay.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnkolay.Location = new System.Drawing.Point(30, 83);
            this.btnkolay.Name = "btnkolay";
            this.btnkolay.Size = new System.Drawing.Size(244, 51);
            this.btnkolay.TabIndex = 1;
            this.btnkolay.Text = "KOLAY";
            this.btnkolay.UseVisualStyleBackColor = false;
            this.btnkolay.Click += new System.EventHandler(this.btnkolay_Click);
            // 
            // btnorta
            // 
            this.btnorta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnorta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorta.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnorta.Location = new System.Drawing.Point(30, 151);
            this.btnorta.Name = "btnorta";
            this.btnorta.Size = new System.Drawing.Size(244, 51);
            this.btnorta.TabIndex = 1;
            this.btnorta.Text = "ORTA";
            this.btnorta.UseVisualStyleBackColor = false;
            this.btnorta.Click += new System.EventHandler(this.btnorta_Click);
            // 
            // btnzor
            // 
            this.btnzor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnzor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnzor.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnzor.Location = new System.Drawing.Point(30, 218);
            this.btnzor.Name = "btnzor";
            this.btnzor.Size = new System.Drawing.Size(244, 51);
            this.btnzor.TabIndex = 1;
            this.btnzor.Text = "ZOR";
            this.btnzor.UseVisualStyleBackColor = false;
            this.btnzor.Click += new System.EventHandler(this.btnzor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msyeni});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(303, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msyeni
            // 
            this.msyeni.Name = "msyeni";
            this.msyeni.Size = new System.Drawing.Size(83, 23);
            this.msyeni.Text = "YENİ OYUN";
            this.msyeni.Click += new System.EventHandler(this.msyeni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(303, 289);
            this.Controls.Add(this.btnzor);
            this.Controls.Add(this.btnorta);
            this.Controls.Add(this.btnkolay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkolay;
        private System.Windows.Forms.Button btnorta;
        private System.Windows.Forms.Button btnzor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msyeni;
    }
}

