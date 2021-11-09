namespace WindowsFormsApplication21_ornekprogram3
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgun = new System.Windows.Forms.TextBox();
            this.txtsaat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.listsonuc = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsaatucret = new System.Windows.Forms.TextBox();
            this.btnodendi = new System.Windows.Forms.Button();
            this.btnaysonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KAÇ GÜN ÇALIŞTI : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(2, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "MESAİ VARSA KAÇ SAAT : ";
            // 
            // txtgun
            // 
            this.txtgun.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgun.Location = new System.Drawing.Point(329, 434);
            this.txtgun.Name = "txtgun";
            this.txtgun.Size = new System.Drawing.Size(211, 35);
            this.txtgun.TabIndex = 3;
            // 
            // txtsaat
            // 
            this.txtsaat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsaat.Location = new System.Drawing.Point(329, 501);
            this.txtsaat.Name = "txtsaat";
            this.txtsaat.Size = new System.Drawing.Size(211, 35);
            this.txtsaat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "(MESAİ YOK İSE BOŞ BIRAKINIZ...)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(546, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "(1 GÜN 8 SAAT ÜCRETTEN HESAPLANIR)";
            // 
            // btnhesapla
            // 
            this.btnhesapla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnhesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhesapla.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Location = new System.Drawing.Point(329, 592);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(211, 53);
            this.btnhesapla.TabIndex = 5;
            this.btnhesapla.Text = "HESAPLA";
            this.btnhesapla.UseVisualStyleBackColor = false;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(21, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "ÇALIŞANIN İSMİ SOYİSMİ :";
            // 
            // txtisim
            // 
            this.txtisim.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.txtisim.Location = new System.Drawing.Point(347, 30);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(234, 33);
            this.txtisim.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(587, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "NO : ";
            // 
            // txtno
            // 
            this.txtno.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.txtno.Location = new System.Drawing.Point(645, 30);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(156, 33);
            this.txtno.TabIndex = 1;
            // 
            // listsonuc
            // 
            this.listsonuc.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listsonuc.FormattingEnabled = true;
            this.listsonuc.ItemHeight = 21;
            this.listsonuc.Location = new System.Drawing.Point(433, 200);
            this.listsonuc.Name = "listsonuc";
            this.listsonuc.Size = new System.Drawing.Size(368, 172);
            this.listsonuc.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(61, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "ÇALIŞANIN ALDIĞI ÜCRET";
            // 
            // txtsonuc
            // 
            this.txtsonuc.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.txtsonuc.Location = new System.Drawing.Point(121, 279);
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.ReadOnly = true;
            this.txtsonuc.Size = new System.Drawing.Size(218, 33);
            this.txtsonuc.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(133, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "1 SAAT\'TE ALDIĞI ÜCRET :";
            // 
            // txtsaatucret
            // 
            this.txtsaatucret.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.txtsaatucret.Location = new System.Drawing.Point(481, 105);
            this.txtsaatucret.Name = "txtsaatucret";
            this.txtsaatucret.Size = new System.Drawing.Size(246, 33);
            this.txtsaatucret.TabIndex = 2;
            // 
            // btnodendi
            // 
            this.btnodendi.BackColor = System.Drawing.Color.Silver;
            this.btnodendi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnodendi.Location = new System.Drawing.Point(726, 171);
            this.btnodendi.Name = "btnodendi";
            this.btnodendi.Size = new System.Drawing.Size(75, 23);
            this.btnodendi.TabIndex = 14;
            this.btnodendi.Text = "ÖDENDİ";
            this.btnodendi.UseVisualStyleBackColor = false;
            this.btnodendi.Click += new System.EventHandler(this.btnodendi_Click);
            // 
            // btnaysonu
            // 
            this.btnaysonu.BackColor = System.Drawing.Color.Silver;
            this.btnaysonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaysonu.Location = new System.Drawing.Point(433, 171);
            this.btnaysonu.Name = "btnaysonu";
            this.btnaysonu.Size = new System.Drawing.Size(75, 23);
            this.btnaysonu.TabIndex = 15;
            this.btnaysonu.Text = "AY SONU";
            this.btnaysonu.UseVisualStyleBackColor = false;
            this.btnaysonu.Click += new System.EventHandler(this.btnaysonu_Click);
            // 
            // Form5
            // 
            this.AcceptButton = this.btnhesapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 694);
            this.Controls.Add(this.btnaysonu);
            this.Controls.Add(this.btnodendi);
            this.Controls.Add(this.txtsaatucret);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsonuc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listsonuc);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsaat);
            this.Controls.Add(this.txtgun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MUHASEBE MAAŞ HESAPLAMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgun;
        private System.Windows.Forms.TextBox txtsaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.ListBox listsonuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsaatucret;
        private System.Windows.Forms.Button btnodendi;
        private System.Windows.Forms.Button btnaysonu;
    }
}