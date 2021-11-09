namespace _9__OOP_Uygulama
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
            this.cmbturu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbmodel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbkimicin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbrenk = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnadmingiris = new System.Windows.Forms.Button();
            this.btnuyegiris = new System.Windows.Forms.Button();
            this.btnsepetekle = new System.Windows.Forms.Button();
            this.btnsonlandır = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kALDIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(147, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN TÜRÜ";
            // 
            // cmbturu
            // 
            this.cmbturu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbturu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbturu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbturu.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.cmbturu.FormattingEnabled = true;
            this.cmbturu.Location = new System.Drawing.Point(119, 95);
            this.cmbturu.Name = "cmbturu";
            this.cmbturu.Size = new System.Drawing.Size(179, 34);
            this.cmbturu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(323, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "ÜRÜN MODELİ";
            // 
            // cmbmodel
            // 
            this.cmbmodel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbmodel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmodel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbmodel.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.cmbmodel.FormattingEnabled = true;
            this.cmbmodel.Location = new System.Drawing.Point(304, 95);
            this.cmbmodel.Name = "cmbmodel";
            this.cmbmodel.Size = new System.Drawing.Size(179, 34);
            this.cmbmodel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(530, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "KİM İÇİN";
            // 
            // cmbkimicin
            // 
            this.cmbkimicin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbkimicin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkimicin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbkimicin.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.cmbkimicin.FormattingEnabled = true;
            this.cmbkimicin.Items.AddRange(new object[] {
            "ERKEK - YETİŞKİN",
            "KADIN - YETİŞKİN",
            "ERKEK - ÇOCUK",
            "KIZ - ÇOCUK",
            "ERKEK - BEBEK",
            "KIZ - BEBEK"});
            this.cmbkimicin.Location = new System.Drawing.Point(489, 95);
            this.cmbkimicin.Name = "cmbkimicin";
            this.cmbkimicin.Size = new System.Drawing.Size(179, 34);
            this.cmbkimicin.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(696, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "ÜRÜN RENGİ";
            // 
            // cmbrenk
            // 
            this.cmbrenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbrenk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrenk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbrenk.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.cmbrenk.FormattingEnabled = true;
            this.cmbrenk.Location = new System.Drawing.Point(674, 95);
            this.cmbrenk.Name = "cmbrenk";
            this.cmbrenk.Size = new System.Drawing.Size(179, 34);
            this.cmbrenk.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(366, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "PAMBLY CLOTCHES";
            // 
            // btnadmingiris
            // 
            this.btnadmingiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmingiris.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold);
            this.btnadmingiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnadmingiris.Location = new System.Drawing.Point(21, 4);
            this.btnadmingiris.Name = "btnadmingiris";
            this.btnadmingiris.Size = new System.Drawing.Size(242, 46);
            this.btnadmingiris.TabIndex = 2;
            this.btnadmingiris.Text = "ADMİN GİRİŞİ";
            this.btnadmingiris.UseVisualStyleBackColor = true;
            this.btnadmingiris.Click += new System.EventHandler(this.btnadmingiris_Click);
            // 
            // btnuyegiris
            // 
            this.btnuyegiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuyegiris.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold);
            this.btnuyegiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnuyegiris.Location = new System.Drawing.Point(748, 4);
            this.btnuyegiris.Name = "btnuyegiris";
            this.btnuyegiris.Size = new System.Drawing.Size(242, 46);
            this.btnuyegiris.TabIndex = 2;
            this.btnuyegiris.Text = "ÜYE GİRİŞİ";
            this.btnuyegiris.UseVisualStyleBackColor = true;
            // 
            // btnsepetekle
            // 
            this.btnsepetekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsepetekle.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold);
            this.btnsepetekle.ForeColor = System.Drawing.Color.Purple;
            this.btnsepetekle.Location = new System.Drawing.Point(92, 181);
            this.btnsepetekle.Name = "btnsepetekle";
            this.btnsepetekle.Size = new System.Drawing.Size(242, 46);
            this.btnsepetekle.TabIndex = 2;
            this.btnsepetekle.Text = "SEPETE EKLE";
            this.btnsepetekle.UseVisualStyleBackColor = true;
            // 
            // btnsonlandır
            // 
            this.btnsonlandır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsonlandır.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold);
            this.btnsonlandır.ForeColor = System.Drawing.Color.Red;
            this.btnsonlandır.Location = new System.Drawing.Point(7, 233);
            this.btnsonlandır.Name = "btnsonlandır";
            this.btnsonlandır.Size = new System.Drawing.Size(403, 46);
            this.btnsonlandır.TabIndex = 2;
            this.btnsonlandır.Text = "ALIŞVERİŞİ SONLANDIR";
            this.btnsonlandır.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(21, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "TOPLAM FİYAT: 0TL";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Location = new System.Drawing.Point(416, 148);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(574, 294);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ÜRÜN";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "KİM İÇİN";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RENK";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "FİYAT";
            this.columnHeader4.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kALDIRToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // kALDIRToolStripMenuItem
            // 
            this.kALDIRToolStripMenuItem.Name = "kALDIRToolStripMenuItem";
            this.kALDIRToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.kALDIRToolStripMenuItem.Text = "KALDIR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(115, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "ÜYE ADI: USER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 466);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnuyegiris);
            this.Controls.Add(this.btnsonlandır);
            this.Controls.Add(this.btnsepetekle);
            this.Controls.Add(this.btnadmingiris);
            this.Controls.Add(this.cmbrenk);
            this.Controls.Add(this.cmbkimicin);
            this.Controls.Add(this.cmbmodel);
            this.Controls.Add(this.cmbturu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbturu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbmodel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbkimicin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbrenk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnadmingiris;
        private System.Windows.Forms.Button btnuyegiris;
        private System.Windows.Forms.Button btnsepetekle;
        private System.Windows.Forms.Button btnsonlandır;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kALDIRToolStripMenuItem;
        private System.Windows.Forms.Label label7;
    }
}

