namespace _11__Araba_Otomasyonu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbmarka = new System.Windows.Forms.ComboBox();
            this.cbmodel = new System.Windows.Forms.ComboBox();
            this.cbyakit = new System.Windows.Forms.ComboBox();
            this.cbkasa = new System.Windows.Forms.ComboBox();
            this.cbvites = new System.Windows.Forms.ComboBox();
            this.cbmotor = new System.Windows.Forms.ComboBox();
            this.btnrenk = new System.Windows.Forms.Button();
            this.dtpyil = new System.Windows.Forms.DateTimePicker();
            this.btnsiparis = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.lvsiparis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cdrenk = new System.Windows.Forms.ColorDialog();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dÜZENLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAMBLY ARAÇ SİPARİŞ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(78, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "MARKA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(318, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "MODEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(515, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "YAKIT TİPİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(739, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "KASA TİPİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(50, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "VİTES TİPİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(289, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "MOTOR TİPİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(554, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "RENK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Goldenrod;
            this.label9.Location = new System.Drawing.Point(725, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "ÜRETİM YILI";
            // 
            // cbmarka
            // 
            this.cbmarka.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbmarka.FormattingEnabled = true;
            this.cbmarka.Items.AddRange(new object[] {
            "PAR",
            "BMW",
            "AUDİ",
            "MASERATİ",
            "SUBARRU",
            ""});
            this.cbmarka.Location = new System.Drawing.Point(27, 99);
            this.cbmarka.Name = "cbmarka";
            this.cbmarka.Size = new System.Drawing.Size(176, 31);
            this.cbmarka.TabIndex = 0;
            this.cbmarka.SelectedIndexChanged += new System.EventHandler(this.cbmarka_SelectedIndexChanged);
            // 
            // cbmodel
            // 
            this.cbmodel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbmodel.FormattingEnabled = true;
            this.cbmodel.Items.AddRange(new object[] {
            "PAMLOK",
            "TTOAR",
            "XERYAH",
            "SEDAN",
            "TOURİNG",
            "GRAN TURİSİMO",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "Q2",
            "Q3",
            "Q5",
            "Q7",
            "TT",
            "R8",
            "GHİBLİ",
            "LEVANTE",
            "QUATTROPORTE",
            "LEVORG",
            "FORESTER",
            "OUTBACK"});
            this.cbmodel.Location = new System.Drawing.Point(269, 99);
            this.cbmodel.Name = "cbmodel";
            this.cbmodel.Size = new System.Drawing.Size(176, 31);
            this.cbmodel.TabIndex = 1;
            // 
            // cbyakit
            // 
            this.cbyakit.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbyakit.FormattingEnabled = true;
            this.cbyakit.Items.AddRange(new object[] {
            "BENZİN",
            "DİZEL",
            "ELEKTRİK",
            "LPG"});
            this.cbyakit.Location = new System.Drawing.Point(493, 99);
            this.cbyakit.Name = "cbyakit";
            this.cbyakit.Size = new System.Drawing.Size(176, 31);
            this.cbyakit.TabIndex = 2;
            // 
            // cbkasa
            // 
            this.cbkasa.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbkasa.FormattingEnabled = true;
            this.cbkasa.Items.AddRange(new object[] {
            "COMPACT",
            "CONVERTIBLE",
            "COUPE",
            "CPO",
            "CROSSOVER",
            "SPORTS CARS",
            "SUV",
            "TRUCK",
            "VAN",
            "WAGON",
            "LUXURY",
            "SEDAN",
            "HATCHBACK"});
            this.cbkasa.Location = new System.Drawing.Point(711, 99);
            this.cbkasa.Name = "cbkasa";
            this.cbkasa.Size = new System.Drawing.Size(176, 31);
            this.cbkasa.TabIndex = 3;
            // 
            // cbvites
            // 
            this.cbvites.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbvites.FormattingEnabled = true;
            this.cbvites.Items.AddRange(new object[] {
            "OTOMATİK",
            "MANUEL"});
            this.cbvites.Location = new System.Drawing.Point(27, 176);
            this.cbvites.Name = "cbvites";
            this.cbvites.Size = new System.Drawing.Size(176, 31);
            this.cbvites.TabIndex = 4;
            // 
            // cbmotor
            // 
            this.cbmotor.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbmotor.FormattingEnabled = true;
            this.cbmotor.Items.AddRange(new object[] {
            "V1.2",
            "V1.3",
            "V1.4",
            "V1.5",
            "V1.6",
            "V1.7",
            "V1.8",
            "V1.9",
            "V2.0",
            "V2.1",
            "V2.2",
            "V2.4",
            "V2.6",
            "V2.8",
            "V3.0",
            "V3.4",
            "V3.8",
            "V4.2",
            "V4.6"});
            this.cbmotor.Location = new System.Drawing.Point(269, 176);
            this.cbmotor.Name = "cbmotor";
            this.cbmotor.Size = new System.Drawing.Size(176, 31);
            this.cbmotor.TabIndex = 5;
            // 
            // btnrenk
            // 
            this.btnrenk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrenk.Location = new System.Drawing.Point(493, 176);
            this.btnrenk.Name = "btnrenk";
            this.btnrenk.Size = new System.Drawing.Size(176, 31);
            this.btnrenk.TabIndex = 6;
            this.btnrenk.UseVisualStyleBackColor = true;
            this.btnrenk.Click += new System.EventHandler(this.btnrenk_Click);
            // 
            // dtpyil
            // 
            this.dtpyil.CustomFormat = "yyyy";
            this.dtpyil.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.dtpyil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpyil.Location = new System.Drawing.Point(711, 176);
            this.dtpyil.Name = "dtpyil";
            this.dtpyil.Size = new System.Drawing.Size(176, 31);
            this.dtpyil.TabIndex = 7;
            this.dtpyil.Value = new System.DateTime(2018, 8, 4, 0, 0, 0, 0);
            // 
            // btnsiparis
            // 
            this.btnsiparis.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnsiparis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsiparis.Location = new System.Drawing.Point(924, 84);
            this.btnsiparis.Name = "btnsiparis";
            this.btnsiparis.Size = new System.Drawing.Size(154, 37);
            this.btnsiparis.TabIndex = 8;
            this.btnsiparis.Text = "SİPARİŞ ET";
            this.btnsiparis.UseVisualStyleBackColor = true;
            this.btnsiparis.Click += new System.EventHandler(this.btnsiparis_Click);
            // 
            // btniptal
            // 
            this.btniptal.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.btniptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btniptal.Location = new System.Drawing.Point(924, 127);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(154, 37);
            this.btniptal.TabIndex = 9;
            this.btniptal.Text = "İPTAL ET";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnduzenle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnduzenle.Location = new System.Drawing.Point(924, 170);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(154, 37);
            this.btnduzenle.TabIndex = 10;
            this.btnduzenle.Text = "DÜZENLE";
            this.btnduzenle.UseVisualStyleBackColor = true;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // lvsiparis
            // 
            this.lvsiparis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvsiparis.ContextMenuStrip = this.cms1;
            this.lvsiparis.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvsiparis.FullRowSelect = true;
            this.lvsiparis.GridLines = true;
            this.lvsiparis.Location = new System.Drawing.Point(27, 224);
            this.lvsiparis.Name = "lvsiparis";
            this.lvsiparis.Size = new System.Drawing.Size(1051, 403);
            this.lvsiparis.TabIndex = 6;
            this.lvsiparis.UseCompatibleStateImageBehavior = false;
            this.lvsiparis.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MARKA";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MODEL";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "YAKIT TİPİ";
            this.columnHeader3.Width = 114;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "KASA TİPİ";
            this.columnHeader4.Width = 137;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "VİTES TİPİ";
            this.columnHeader5.Width = 133;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MOTOR TİPİ";
            this.columnHeader6.Width = 125;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "RENK";
            this.columnHeader7.Width = 126;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ÜRETİM YILI";
            this.columnHeader8.Width = 123;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnkaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnkaydet.Location = new System.Drawing.Point(924, 41);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(154, 37);
            this.btnkaydet.TabIndex = 8;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // cms1
            // 
            this.cms1.BackColor = System.Drawing.Color.White;
            this.cms1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sİLToolStripMenuItem,
            this.dÜZENLEToolStripMenuItem});
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(181, 82);
            // 
            // sİLToolStripMenuItem
            // 
            this.sİLToolStripMenuItem.Name = "sİLToolStripMenuItem";
            this.sİLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sİLToolStripMenuItem.Text = "SİL";
            this.sİLToolStripMenuItem.Click += new System.EventHandler(this.sİLToolStripMenuItem_Click);
            // 
            // dÜZENLEToolStripMenuItem
            // 
            this.dÜZENLEToolStripMenuItem.Name = "dÜZENLEToolStripMenuItem";
            this.dÜZENLEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dÜZENLEToolStripMenuItem.Text = "DÜZENLE";
            this.dÜZENLEToolStripMenuItem.Click += new System.EventHandler(this.dÜZENLEToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnsiparis;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 639);
            this.Controls.Add(this.lvsiparis);
            this.Controls.Add(this.btnduzenle);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnsiparis);
            this.Controls.Add(this.dtpyil);
            this.Controls.Add(this.btnrenk);
            this.Controls.Add(this.cbkasa);
            this.Controls.Add(this.cbyakit);
            this.Controls.Add(this.cbmotor);
            this.Controls.Add(this.cbmodel);
            this.Controls.Add(this.cbvites);
            this.Controls.Add(this.cbmarka);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cms1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbmarka;
        private System.Windows.Forms.ComboBox cbmodel;
        private System.Windows.Forms.ComboBox cbyakit;
        private System.Windows.Forms.ComboBox cbkasa;
        private System.Windows.Forms.ComboBox cbvites;
        private System.Windows.Forms.ComboBox cbmotor;
        private System.Windows.Forms.Button btnrenk;
        private System.Windows.Forms.DateTimePicker dtpyil;
        private System.Windows.Forms.Button btnsiparis;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnduzenle;
        private System.Windows.Forms.ListView lvsiparis;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColorDialog cdrenk;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem sİLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dÜZENLEToolStripMenuItem;
    }
}

