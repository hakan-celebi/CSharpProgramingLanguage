namespace _19__Otobüs_Otomasyon_Sistemi
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbotobus = new System.Windows.Forms.ComboBox();
            this.cmbnerden = new System.Windows.Forms.ComboBox();
            this.cmbnereye = new System.Windows.Forms.ComboBox();
            this.dtpgidistarihi = new System.Windows.Forms.DateTimePicker();
            this.nudfiyat = new System.Windows.Forms.NumericUpDown();
            this.btnonaylaa = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsreserveet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiptalet = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Location = new System.Drawing.Point(643, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1180, 824);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İSİM";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SOYİSİM";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "YAŞ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "T.C.";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TELEFON";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CİNSİYET";
            this.columnHeader6.Width = 85;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "OTOBÜS";
            this.columnHeader7.Width = 105;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "NERDEN-NEREYE";
            this.columnHeader8.Width = 140;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "NE ZAMAN";
            this.columnHeader9.Width = 115;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "FİYAT";
            this.columnHeader10.Width = 75;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "KOLTUK NUMARASI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(447, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "OTOBÜS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(444, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "NERDEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(444, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "NEREYE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(455, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "TARİH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(455, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "FİYAT";
            // 
            // cmbotobus
            // 
            this.cmbotobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbotobus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbotobus.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbotobus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbotobus.FormattingEnabled = true;
            this.cmbotobus.Items.AddRange(new object[] {
            "TREVEGO",
            "NEOPLAN",
            "SETRA"});
            this.cmbotobus.Location = new System.Drawing.Point(408, 49);
            this.cmbotobus.Name = "cmbotobus";
            this.cmbotobus.Size = new System.Drawing.Size(168, 34);
            this.cmbotobus.TabIndex = 0;
            this.cmbotobus.SelectedIndexChanged += new System.EventHandler(this.cmbotobus_SelectedIndexChanged);
            // 
            // cmbnerden
            // 
            this.cmbnerden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnerden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbnerden.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbnerden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbnerden.FormattingEnabled = true;
            this.cmbnerden.Items.AddRange(new object[] {
            "İSTANBUL",
            "ANKARA",
            "KONYA",
            "NEVŞEHİR",
            "DÜZCE",
            "İZMİT",
            "ISPARTA",
            "BURDUR",
            "KÜTAHYA",
            "KARAMAN",
            "MUĞLA",
            "MANİSA",
            "MERSİN",
            "ADANA"});
            this.cmbnerden.Location = new System.Drawing.Point(408, 114);
            this.cmbnerden.Name = "cmbnerden";
            this.cmbnerden.Size = new System.Drawing.Size(168, 34);
            this.cmbnerden.TabIndex = 1;
            // 
            // cmbnereye
            // 
            this.cmbnereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnereye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbnereye.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbnereye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbnereye.FormattingEnabled = true;
            this.cmbnereye.Items.AddRange(new object[] {
            "İSTANBUL",
            "ANKARA",
            "KONYA",
            "NEVŞEHİR",
            "DÜZCE",
            "İZMİT",
            "ISPARTA",
            "BURDUR",
            "KÜTAHYA",
            "KARAMAN",
            "MUĞLA",
            "MANİSA",
            "MERSİN",
            "ADANA"});
            this.cmbnereye.Location = new System.Drawing.Point(408, 173);
            this.cmbnereye.Name = "cmbnereye";
            this.cmbnereye.Size = new System.Drawing.Size(168, 34);
            this.cmbnereye.TabIndex = 2;
            // 
            // dtpgidistarihi
            // 
            this.dtpgidistarihi.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtpgidistarihi.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpgidistarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpgidistarihi.Location = new System.Drawing.Point(408, 239);
            this.dtpgidistarihi.Name = "dtpgidistarihi";
            this.dtpgidistarihi.Size = new System.Drawing.Size(168, 33);
            this.dtpgidistarihi.TabIndex = 3;
            // 
            // nudfiyat
            // 
            this.nudfiyat.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.nudfiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nudfiyat.Location = new System.Drawing.Point(408, 304);
            this.nudfiyat.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudfiyat.Name = "nudfiyat";
            this.nudfiyat.Size = new System.Drawing.Size(168, 31);
            this.nudfiyat.TabIndex = 4;
            this.nudfiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnonaylaa
            // 
            this.btnonaylaa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnonaylaa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnonaylaa.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnonaylaa.ForeColor = System.Drawing.Color.Purple;
            this.btnonaylaa.Location = new System.Drawing.Point(408, 354);
            this.btnonaylaa.Name = "btnonaylaa";
            this.btnonaylaa.Size = new System.Drawing.Size(168, 54);
            this.btnonaylaa.TabIndex = 5;
            this.btnonaylaa.Text = "ONAYLA";
            this.btnonaylaa.UseVisualStyleBackColor = false;
            this.btnonaylaa.Click += new System.EventHandler(this.btnonaylaa_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsreserveet,
            this.cmsiptalet});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
            // 
            // cmsreserveet
            // 
            this.cmsreserveet.Name = "cmsreserveet";
            this.cmsreserveet.Size = new System.Drawing.Size(135, 22);
            this.cmsreserveet.Text = "RESERVE ET";
            this.cmsreserveet.Click += new System.EventHandler(this.cmsreserveet_Click);
            // 
            // cmsiptalet
            // 
            this.cmsiptalet.Name = "cmsiptalet";
            this.cmsiptalet.Size = new System.Drawing.Size(135, 22);
            this.cmsiptalet.Text = "İPTAL ET";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1828, 848);
            this.Controls.Add(this.btnonaylaa);
            this.Controls.Add(this.nudfiyat);
            this.Controls.Add(this.dtpgidistarihi);
            this.Controls.Add(this.cmbnereye);
            this.Controls.Add(this.cmbnerden);
            this.Controls.Add(this.cmbotobus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "PAMBLY OTOBÜS";
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbotobus;
        private System.Windows.Forms.ComboBox cmbnerden;
        private System.Windows.Forms.ComboBox cmbnereye;
        private System.Windows.Forms.DateTimePicker dtpgidistarihi;
        private System.Windows.Forms.NumericUpDown nudfiyat;
        private System.Windows.Forms.Button btnonaylaa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsreserveet;
        private System.Windows.Forms.ToolStripMenuItem cmsiptalet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

