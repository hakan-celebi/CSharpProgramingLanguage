namespace _8__Listeleyiciler_A_Listbox
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
            this.txtisim = new System.Windows.Forms.TextBox();
            this.lbogrenciler = new System.Windows.Forms.ListBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaristir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "ERBİL KORU ANADOLU LİSESİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÖĞRENCİ İSMİ: ";
            // 
            // txtisim
            // 
            this.txtisim.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.txtisim.Location = new System.Drawing.Point(164, 63);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(224, 33);
            this.txtisim.TabIndex = 2;
            // 
            // lbogrenciler
            // 
            this.lbogrenciler.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lbogrenciler.FormattingEnabled = true;
            this.lbogrenciler.ItemHeight = 25;
            this.lbogrenciler.Location = new System.Drawing.Point(17, 108);
            this.lbogrenciler.Name = "lbogrenciler";
            this.lbogrenciler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbogrenciler.Size = new System.Drawing.Size(371, 304);
            this.lbogrenciler.TabIndex = 3;
            this.lbogrenciler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbogrenciler_KeyDown);
            // 
            // btnekle
            // 
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.Orange;
            this.btnekle.Location = new System.Drawing.Point(403, 63);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(131, 33);
            this.btnekle.TabIndex = 4;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.Orange;
            this.btnsil.Location = new System.Drawing.Point(403, 108);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(131, 33);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaristir
            // 
            this.btnkaristir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaristir.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaristir.ForeColor = System.Drawing.Color.Orange;
            this.btnkaristir.Location = new System.Drawing.Point(403, 156);
            this.btnkaristir.Name = "btnkaristir";
            this.btnkaristir.Size = new System.Drawing.Size(131, 33);
            this.btnkaristir.TabIndex = 4;
            this.btnkaristir.Text = "KARIŞTIR";
            this.btnkaristir.UseVisualStyleBackColor = true;
            this.btnkaristir.Click += new System.EventHandler(this.btnkaristir_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.btnkaristir);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lbogrenciler);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.ListBox lbogrenciler;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaristir;
    }
}

