namespace WindowsFormsApp23_listview
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.mtxttckn = new System.Windows.Forms.MaskedTextBox();
            this.mtxtdt = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbt = new System.Windows.Forms.MaskedTextBox();
            this.mtxttel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbalan = new System.Windows.Forms.ComboBox();
            this.cbkabul = new System.Windows.Forms.CheckBox();
            this.btnonayla = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "AD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(470, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(676, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "PAMBLY ÇALIŞAN EKLEME FORMU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "SOYAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "DOĞUM TARİHİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "TCKN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "İŞ BAŞLANGIÇ TARİHİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "TELEFON NUMARASI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 605);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "ALANI";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtad.Location = new System.Drawing.Point(17, 99);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(279, 32);
            this.txtad.TabIndex = 0;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtsoyad.Location = new System.Drawing.Point(17, 177);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(279, 32);
            this.txtsoyad.TabIndex = 1;
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtmail.Location = new System.Drawing.Point(17, 554);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(279, 32);
            this.txtmail.TabIndex = 6;
            // 
            // mtxttckn
            // 
            this.mtxttckn.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.mtxttckn.Location = new System.Drawing.Point(17, 250);
            this.mtxttckn.Mask = "00000000000";
            this.mtxttckn.Name = "mtxttckn";
            this.mtxttckn.Size = new System.Drawing.Size(279, 32);
            this.mtxttckn.TabIndex = 2;
            // 
            // mtxtdt
            // 
            this.mtxtdt.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.mtxtdt.Location = new System.Drawing.Point(17, 323);
            this.mtxtdt.Mask = "00/00/0000";
            this.mtxtdt.Name = "mtxtdt";
            this.mtxtdt.Size = new System.Drawing.Size(279, 32);
            this.mtxtdt.TabIndex = 3;
            this.mtxtdt.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtbt
            // 
            this.mtxtbt.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.mtxtbt.Location = new System.Drawing.Point(17, 481);
            this.mtxtbt.Mask = "00/00/0000";
            this.mtxtbt.Name = "mtxtbt";
            this.mtxtbt.Size = new System.Drawing.Size(279, 32);
            this.mtxtbt.TabIndex = 5;
            this.mtxtbt.ValidatingType = typeof(System.DateTime);
            // 
            // mtxttel
            // 
            this.mtxttel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.mtxttel.Location = new System.Drawing.Point(17, 402);
            this.mtxttel.Mask = "(+99) 000-000-0000";
            this.mtxttel.Name = "mtxttel";
            this.mtxttel.Size = new System.Drawing.Size(279, 32);
            this.mtxttel.TabIndex = 4;
            this.mtxttel.Text = "90";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "E-MAİL";
            // 
            // cbalan
            // 
            this.cbalan.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbalan.FormattingEnabled = true;
            this.cbalan.Items.AddRange(new object[] {
            "YAZILIM MÜHENDİSİ",
            "GRAFİK TASARIM UZMANI",
            "WEB TASARIM UZMANI",
            "ELEKTRİK ELEKTRONİK MÜHENDİSİ",
            "MAKİNE MÜHENDİSİ",
            "DONANIM UZMANI",
            "YAZILIM GELİŞTİRME UZMANI",
            "WEB TASARIM - HTML/CSS/JS",
            "WEB TASARIM - ASP.NET/SQL",
            "VERİ TABANI UZMANI",
            "PAZARLAMA",
            "SOSYAL MEDYA REKLAM UZMANI",
            "REKLAM UZMANI",
            "SEKRETERLİK",
            "SATIN ALMA",
            "AŞÇI",
            "TEMİZLİKÇİ",
            "MUHASEBE UZMANI",
            "DİĞER..."});
            this.cbalan.Location = new System.Drawing.Point(17, 633);
            this.cbalan.Name = "cbalan";
            this.cbalan.Size = new System.Drawing.Size(279, 31);
            this.cbalan.TabIndex = 7;
            // 
            // cbkabul
            // 
            this.cbkabul.AutoSize = true;
            this.cbkabul.Location = new System.Drawing.Point(17, 691);
            this.cbkabul.Name = "cbkabul";
            this.cbkabul.Size = new System.Drawing.Size(445, 17);
            this.cbkabul.TabIndex = 8;
            this.cbkabul.Text = "PAMBLY COMPANY İŞ BAŞVURUSU ŞARTLARINI OKUDUM VE KABUL EDİYORUM.";
            this.cbkabul.UseVisualStyleBackColor = true;
            // 
            // btnonayla
            // 
            this.btnonayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnonayla.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnonayla.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnonayla.Location = new System.Drawing.Point(198, 731);
            this.btnonayla.Name = "btnonayla";
            this.btnonayla.Size = new System.Drawing.Size(98, 39);
            this.btnonayla.TabIndex = 9;
            this.btnonayla.Text = "ONAYLA";
            this.btnonayla.UseVisualStyleBackColor = true;
            this.btnonayla.Click += new System.EventHandler(this.btnonayla_Click);
            // 
            // btniptal
            // 
            this.btniptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniptal.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniptal.ForeColor = System.Drawing.Color.DarkBlue;
            this.btniptal.Location = new System.Drawing.Point(17, 731);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(98, 39);
            this.btniptal.TabIndex = 10;
            this.btniptal.Text = "İPTAL";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(302, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "(ZORUNLU)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(302, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "(ZORUNLU)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(302, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "(ZORUNLU)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(302, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 18);
            this.label13.TabIndex = 7;
            this.label13.Text = "(ZORUNLU)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(302, 642);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 18);
            this.label14.TabIndex = 7;
            this.label14.Text = "(ZORUNLU)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Crimson;
            this.label15.Location = new System.Drawing.Point(302, 490);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 18);
            this.label15.TabIndex = 7;
            this.label15.Text = "(ZORUNLU)";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.Location = new System.Drawing.Point(479, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1144, 671);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AD";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SOYAD";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TCKN";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DOĞUM TARİHİ";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TELEFON NUMARASI";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "BAŞTAR.";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "E-MAİL";
            this.columnHeader7.Width = 210;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ALAN";
            this.columnHeader8.Width = 222;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnonayla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1648, 782);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnonayla);
            this.Controls.Add(this.cbkabul);
            this.Controls.Add(this.cbalan);
            this.Controls.Add(this.mtxttel);
            this.Controls.Add(this.mtxtbt);
            this.Controls.Add(this.mtxtdt);
            this.Controls.Add(this.mtxttckn);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.MaskedTextBox mtxttckn;
        private System.Windows.Forms.MaskedTextBox mtxtdt;
        private System.Windows.Forms.MaskedTextBox mtxtbt;
        private System.Windows.Forms.MaskedTextBox mtxttel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbalan;
        private System.Windows.Forms.CheckBox cbkabul;
        private System.Windows.Forms.Button btnonayla;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

