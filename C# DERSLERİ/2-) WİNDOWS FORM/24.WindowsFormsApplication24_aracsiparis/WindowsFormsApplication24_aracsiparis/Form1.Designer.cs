namespace WindowsFormsApplication24_aracsiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbmarka = new System.Windows.Forms.ComboBox();
            this.cmbmodel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbkasa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbenzin = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbvites = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnrenk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpmodel = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnekle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbmotortipi = new System.Windows.Forms.ComboBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Arabic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(207, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARAÇ SiPARiŞ UYGULAMASI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(31, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "ARAÇ MARKASI";
            // 
            // cmbmarka
            // 
            this.cmbmarka.BackColor = System.Drawing.SystemColors.Window;
            this.cmbmarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmarka.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbmarka.FormattingEnabled = true;
            this.cmbmarka.Items.AddRange(new object[] {
            "Pambly Cartin",
            "Alfa Romeo",
            "Aston Martin",
            "Audi",
            "Bentley",
            "BMW",
            "Bugatti",
            "Buick",
            "Chevrolet",
            "Citroen",
            "Ferrari",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Volvo",
            "Volkswagen",
            "Porsche",
            "Toyota",
            "Renault",
            "Nissan",
            "Opel",
            "Peugeot",
            "Mercedes Benz",
            "Maserati"});
            this.cmbmarka.Location = new System.Drawing.Point(13, 151);
            this.cmbmarka.Name = "cmbmarka";
            this.cmbmarka.Size = new System.Drawing.Size(220, 36);
            this.cmbmarka.TabIndex = 1;
            this.cmbmarka.SelectedIndexChanged += new System.EventHandler(this.cmbmarka_SelectedIndexChanged);
            // 
            // cmbmodel
            // 
            this.cmbmodel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmodel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbmodel.FormattingEnabled = true;
            this.cmbmodel.Location = new System.Drawing.Point(259, 151);
            this.cmbmodel.Name = "cmbmodel";
            this.cmbmodel.Size = new System.Drawing.Size(220, 36);
            this.cmbmodel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(318, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "MODEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(786, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "KASA TİPİ";
            // 
            // cmbkasa
            // 
            this.cmbkasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkasa.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbkasa.FormattingEnabled = true;
            this.cmbkasa.Items.AddRange(new object[] {
            "Sedan",
            "Vagon",
            "Hatcback",
            "Suv"});
            this.cmbkasa.Location = new System.Drawing.Point(738, 151);
            this.cmbkasa.Name = "cmbkasa";
            this.cmbkasa.Size = new System.Drawing.Size(220, 36);
            this.cmbkasa.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(46, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "BENZİN TİPİ";
            // 
            // cmbbenzin
            // 
            this.cmbbenzin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbenzin.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbbenzin.FormattingEnabled = true;
            this.cmbbenzin.Items.AddRange(new object[] {
            "Lpg",
            "Dizel",
            "Benzin"});
            this.cmbbenzin.Location = new System.Drawing.Point(13, 246);
            this.cmbbenzin.Name = "cmbbenzin";
            this.cmbbenzin.Size = new System.Drawing.Size(220, 36);
            this.cmbbenzin.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(543, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "VİTES TİPİ";
            // 
            // cmbvites
            // 
            this.cmbvites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvites.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbvites.FormattingEnabled = true;
            this.cmbvites.Items.AddRange(new object[] {
            "Otomatik",
            "Manuel",
            "Triptonik"});
            this.cmbvites.Location = new System.Drawing.Point(501, 151);
            this.cmbvites.Name = "cmbvites";
            this.cmbvites.Size = new System.Drawing.Size(220, 36);
            this.cmbvites.TabIndex = 2;
            // 
            // btnrenk
            // 
            this.btnrenk.BackColor = System.Drawing.SystemColors.Window;
            this.btnrenk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrenk.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnrenk.Location = new System.Drawing.Point(262, 246);
            this.btnrenk.Name = "btnrenk";
            this.btnrenk.Size = new System.Drawing.Size(217, 35);
            this.btnrenk.TabIndex = 3;
            this.btnrenk.UseVisualStyleBackColor = false;
            this.btnrenk.Click += new System.EventHandler(this.btnrenk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(338, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "RENK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Location = new System.Drawing.Point(763, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "MODEL TARİH";
            // 
            // dtpmodel
            // 
            this.dtpmodel.CustomFormat = "yyyy";
            this.dtpmodel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.dtpmodel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpmodel.Location = new System.Drawing.Point(738, 246);
            this.dtpmodel.MaxDate = new System.DateTime(9998, 8, 9, 0, 0, 0, 0);
            this.dtpmodel.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpmodel.Name = "dtpmodel";
            this.dtpmodel.Size = new System.Drawing.Size(106, 36);
            this.dtpmodel.TabIndex = 4;
            this.dtpmodel.Value = new System.DateTime(2017, 8, 9, 0, 0, 0, 0);
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
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 311);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(945, 400);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MARKA";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MODEL";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "VİTES TİP.";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "KASA TİP.";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "BENZİN TİP.";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "RENK";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "MOTOR TİP.";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "MODEL TAR.";
            this.columnHeader8.Width = 85;
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnekle.Image = ((System.Drawing.Image)(resources.GetObject("btnekle.Image")));
            this.btnekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnekle.Location = new System.Drawing.Point(850, 246);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(108, 36);
            this.btnekle.TabIndex = 6;
            this.btnekle.Text = "EKLE";
            this.btnekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Cornsilk;
            this.label9.Location = new System.Drawing.Point(530, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "MOTOR TİPİ";
            // 
            // cmbmotortipi
            // 
            this.cmbmotortipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmotortipi.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbmotortipi.FormattingEnabled = true;
            this.cmbmotortipi.Items.AddRange(new object[] {
            "1.2",
            "1.3",
            "1.4",
            "1.5",
            "1.6",
            "1.8",
            "2.0",
            "2.2",
            "2.4",
            "2.6",
            "2.8",
            "3.0",
            "3.5",
            "3.7",
            "4.0",
            "4.5",
            "4.7",
            "5.0"});
            this.cmbmotortipi.Location = new System.Drawing.Point(501, 246);
            this.cmbmotortipi.Name = "cmbmotortipi";
            this.cmbmotortipi.Size = new System.Drawing.Size(220, 36);
            this.cmbmotortipi.TabIndex = 2;
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnsil.Location = new System.Drawing.Point(964, 245);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(108, 36);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnduzenle.Location = new System.Drawing.Point(1078, 245);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(108, 35);
            this.btnduzenle.TabIndex = 8;
            this.btnduzenle.Text = "DÜZENLE";
            this.btnduzenle.UseVisualStyleBackColor = true;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.SpringGreen;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkaydet.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(964, 195);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(108, 44);
            this.btnkaydet.TabIndex = 9;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.Crimson;
            this.btniptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btniptal.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.btniptal.Location = new System.Drawing.Point(1078, 195);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(108, 44);
            this.btniptal.TabIndex = 10;
            this.btniptal.Text = "İPTAL";
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1220, 733);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnduzenle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dtpmodel);
            this.Controls.Add(this.btnrenk);
            this.Controls.Add(this.cmbvites);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbmotortipi);
            this.Controls.Add(this.cmbbenzin);
            this.Controls.Add(this.cmbkasa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbmodel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbmarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbmarka;
        private System.Windows.Forms.ComboBox cmbmodel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbkasa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbenzin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbvites;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnrenk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpmodel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbmotortipi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnduzenle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}

