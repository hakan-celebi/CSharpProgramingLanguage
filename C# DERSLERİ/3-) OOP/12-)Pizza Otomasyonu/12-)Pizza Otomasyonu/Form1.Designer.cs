namespace _12__Pizza_Otomasyonu
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
            this.lbltutar = new System.Windows.Forms.Label();
            this.lbltoplamtutar = new System.Windows.Forms.Label();
            this.cmbebatlar = new System.Windows.Forms.ComboBox();
            this.cmbpizzalar = new System.Windows.Forms.ComboBox();
            this.txtadet = new System.Windows.Forms.TextBox();
            this.rbtnincekenar = new System.Windows.Forms.RadioButton();
            this.rbtnkalinkenar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cktpeynir = new System.Windows.Forms.CheckBox();
            this.cktzeytin = new System.Windows.Forms.CheckBox();
            this.ckttonbaligi = new System.Windows.Forms.CheckBox();
            this.cktancuez = new System.Windows.Forms.CheckBox();
            this.cktmantar = new System.Windows.Forms.CheckBox();
            this.cktmisir = new System.Windows.Forms.CheckBox();
            this.cktsucuk = new System.Windows.Forms.CheckBox();
            this.cktsosis = new System.Windows.Forms.CheckBox();
            this.cktsalam = new System.Windows.Forms.CheckBox();
            this.cktdanajabon = new System.Windows.Forms.CheckBox();
            this.lbsepet = new System.Windows.Forms.ListBox();
            this.btnsepetekle = new System.Windows.Forms.Button();
            this.btnsiparisionayla = new System.Windows.Forms.Button();
            this.btnveriekle = new System.Windows.Forms.Button();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "EBATLAR: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADET:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "PİZZALAR:";
            // 
            // lbltutar
            // 
            this.lbltutar.AutoSize = true;
            this.lbltutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltutar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltutar.Location = new System.Drawing.Point(229, 397);
            this.lbltutar.Name = "lbltutar";
            this.lbltutar.Size = new System.Drawing.Size(109, 23);
            this.lbltutar.TabIndex = 0;
            this.lbltutar.Text = "TUTAR: 0 TL";
            // 
            // lbltoplamtutar
            // 
            this.lbltoplamtutar.AutoSize = true;
            this.lbltoplamtutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltoplamtutar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplamtutar.Location = new System.Drawing.Point(472, 333);
            this.lbltoplamtutar.Name = "lbltoplamtutar";
            this.lbltoplamtutar.Size = new System.Drawing.Size(184, 23);
            this.lbltoplamtutar.TabIndex = 0;
            this.lbltoplamtutar.Text = "TOPLAM TUTAR: 0 TL";
            // 
            // cmbebatlar
            // 
            this.cmbebatlar.BackColor = System.Drawing.Color.LightGray;
            this.cmbebatlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbebatlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbebatlar.Font = new System.Drawing.Font("Candara", 14.25F);
            this.cmbebatlar.FormattingEnabled = true;
            this.cmbebatlar.Location = new System.Drawing.Point(103, 38);
            this.cmbebatlar.Name = "cmbebatlar";
            this.cmbebatlar.Size = new System.Drawing.Size(180, 31);
            this.cmbebatlar.TabIndex = 0;
            // 
            // cmbpizzalar
            // 
            this.cmbpizzalar.BackColor = System.Drawing.Color.LightGray;
            this.cmbpizzalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpizzalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbpizzalar.Font = new System.Drawing.Font("Candara", 14.25F);
            this.cmbpizzalar.FormattingEnabled = true;
            this.cmbpizzalar.Location = new System.Drawing.Point(103, 80);
            this.cmbpizzalar.Name = "cmbpizzalar";
            this.cmbpizzalar.Size = new System.Drawing.Size(180, 31);
            this.cmbpizzalar.TabIndex = 1;
            // 
            // txtadet
            // 
            this.txtadet.Font = new System.Drawing.Font("Candara", 14.25F);
            this.txtadet.Location = new System.Drawing.Point(67, 394);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(55, 31);
            this.txtadet.TabIndex = 2;
            // 
            // rbtnincekenar
            // 
            this.rbtnincekenar.AutoSize = true;
            this.rbtnincekenar.Checked = true;
            this.rbtnincekenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnincekenar.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnincekenar.Location = new System.Drawing.Point(66, 147);
            this.rbtnincekenar.Name = "rbtnincekenar";
            this.rbtnincekenar.Size = new System.Drawing.Size(82, 17);
            this.rbtnincekenar.TabIndex = 3;
            this.rbtnincekenar.TabStop = true;
            this.rbtnincekenar.Text = "İNCE KENAR";
            this.rbtnincekenar.UseVisualStyleBackColor = true;
            // 
            // rbtnkalinkenar
            // 
            this.rbtnkalinkenar.AutoSize = true;
            this.rbtnkalinkenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnkalinkenar.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnkalinkenar.Location = new System.Drawing.Point(194, 147);
            this.rbtnkalinkenar.Name = "rbtnkalinkenar";
            this.rbtnkalinkenar.Size = new System.Drawing.Size(89, 17);
            this.rbtnkalinkenar.TabIndex = 3;
            this.rbtnkalinkenar.Text = "KALIN KENAR";
            this.rbtnkalinkenar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cktpeynir);
            this.groupBox1.Controls.Add(this.cktzeytin);
            this.groupBox1.Controls.Add(this.ckttonbaligi);
            this.groupBox1.Controls.Add(this.cktancuez);
            this.groupBox1.Controls.Add(this.cktmantar);
            this.groupBox1.Controls.Add(this.cktmisir);
            this.groupBox1.Controls.Add(this.cktsucuk);
            this.groupBox1.Controls.Add(this.cktsosis);
            this.groupBox1.Controls.Add(this.cktsalam);
            this.groupBox1.Controls.Add(this.cktdanajabon);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(66, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MALZEMELER";
            // 
            // cktpeynir
            // 
            this.cktpeynir.AutoSize = true;
            this.cktpeynir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cktpeynir.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cktpeynir.Location = new System.Drawing.Point(128, 122);
            this.cktpeynir.Name = "cktpeynir";
            this.cktpeynir.Size = new System.Drawing.Size(65, 19);
            this.cktpeynir.TabIndex = 0;
            this.cktpeynir.Text = "PEYNİR";
            this.cktpeynir.UseVisualStyleBackColor = true;
            // 
            // cktzeytin
            // 
            this.cktzeytin.AutoSize = true;
            this.cktzeytin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cktzeytin.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cktzeytin.Location = new System.Drawing.Point(6, 122);
            this.cktzeytin.Name = "cktzeytin";
            this.cktzeytin.Size = new System.Drawing.Size(64, 19);
            this.cktzeytin.TabIndex = 0;
            this.cktzeytin.Text = "ZEYTİN";
            this.cktzeytin.UseVisualStyleBackColor = true;
            // 
            // ckttonbaligi
            // 
            this.ckttonbaligi.AutoSize = true;
            this.ckttonbaligi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckttonbaligi.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ckttonbaligi.Location = new System.Drawing.Point(128, 97);
            this.ckttonbaligi.Name = "ckttonbaligi";
            this.ckttonbaligi.Size = new System.Drawing.Size(89, 19);
            this.ckttonbaligi.TabIndex = 0;
            this.ckttonbaligi.Text = "TON BALIĞI";
            this.ckttonbaligi.UseVisualStyleBackColor = true;
            // 
            // cktancuez
            // 
            this.cktancuez.AutoSize = true;
            this.cktancuez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cktancuez.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cktancuez.Location = new System.Drawing.Point(6, 97);
            this.cktancuez.Name = "cktancuez";
            this.cktancuez.Size = new System.Drawing.Size(70, 19);
            this.cktancuez.TabIndex = 0;
            this.cktancuez.Text = "ANÇUEZ";
            this.cktancuez.UseVisualStyleBackColor = true;
            // 
            // cktmantar
            // 
            this.cktmantar.AutoSize = true;
            this.cktmantar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cktmantar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cktmantar.Location = new System.Drawing.Point(128, 72);
            this.cktmantar.Name = "cktmantar";
            this.cktmantar.Size = new System.Drawing.Size(74, 19);
            this.cktmantar.TabIndex = 0;
            this.cktmantar.Text = "MANTAR";
            this.cktmantar.UseVisualStyleBackColor = true;
            // 
            // cktmisir
            // 
            this.cktmisir.AutoSize = true;
            this.cktmisir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cktmisir.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cktmisir.Location = new System.Drawing.Point(6, 72);
            this.cktmisir.Name = "cktmisir";
            this.cktmisir.Size = new System.Drawing.Size(57, 19);
            this.cktmisir.TabIndex = 0;
            this.cktmisir.Text = "MISIR";
            this.cktmisir.UseVisualStyleBackColor = true;
            // 
            // cktsucuk
            // 
            this.cktsucuk.AutoSize = true;
            this.cktsucuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cktsucuk.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cktsucuk.Location = new System.Drawing.Point(128, 47);
            this.cktsucuk.Name = "cktsucuk";
            this.cktsucuk.Size = new System.Drawing.Size(63, 19);
            this.cktsucuk.TabIndex = 0;
            this.cktsucuk.Text = "SUCUK";
            this.cktsucuk.UseVisualStyleBackColor = true;
            // 
            // cktsosis
            // 
            this.cktsosis.AutoSize = true;
            this.cktsosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cktsosis.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cktsosis.Location = new System.Drawing.Point(6, 47);
            this.cktsosis.Name = "cktsosis";
            this.cktsosis.Size = new System.Drawing.Size(57, 19);
            this.cktsosis.TabIndex = 0;
            this.cktsosis.Text = "SOSİS";
            this.cktsosis.UseVisualStyleBackColor = true;
            // 
            // cktsalam
            // 
            this.cktsalam.AutoSize = true;
            this.cktsalam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cktsalam.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cktsalam.Location = new System.Drawing.Point(128, 22);
            this.cktsalam.Name = "cktsalam";
            this.cktsalam.Size = new System.Drawing.Size(63, 19);
            this.cktsalam.TabIndex = 0;
            this.cktsalam.Text = "SALAM";
            this.cktsalam.UseVisualStyleBackColor = true;
            // 
            // cktdanajabon
            // 
            this.cktdanajabon.AutoSize = true;
            this.cktdanajabon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cktdanajabon.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cktdanajabon.Location = new System.Drawing.Point(6, 22);
            this.cktdanajabon.Name = "cktdanajabon";
            this.cktdanajabon.Size = new System.Drawing.Size(107, 19);
            this.cktdanajabon.TabIndex = 0;
            this.cktdanajabon.Text = "DANA JANBON";
            this.cktdanajabon.UseVisualStyleBackColor = true;
            // 
            // lbsepet
            // 
            this.lbsepet.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsepet.FormattingEnabled = true;
            this.lbsepet.ItemHeight = 15;
            this.lbsepet.Location = new System.Drawing.Point(330, 26);
            this.lbsepet.Name = "lbsepet";
            this.lbsepet.Size = new System.Drawing.Size(458, 304);
            this.lbsepet.TabIndex = 5;
            // 
            // btnsepetekle
            // 
            this.btnsepetekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsepetekle.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsepetekle.Location = new System.Drawing.Point(372, 397);
            this.btnsepetekle.Name = "btnsepetekle";
            this.btnsepetekle.Size = new System.Drawing.Size(126, 23);
            this.btnsepetekle.TabIndex = 2;
            this.btnsepetekle.Text = "SEPETE EKLE";
            this.btnsepetekle.UseVisualStyleBackColor = true;
            this.btnsepetekle.Click += new System.EventHandler(this.btnsepetekle_Click);
            // 
            // btnsiparisionayla
            // 
            this.btnsiparisionayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiparisionayla.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsiparisionayla.Location = new System.Drawing.Point(515, 397);
            this.btnsiparisionayla.Name = "btnsiparisionayla";
            this.btnsiparisionayla.Size = new System.Drawing.Size(126, 23);
            this.btnsiparisionayla.TabIndex = 3;
            this.btnsiparisionayla.Text = "SİPARİŞİ ONAYLA";
            this.btnsiparisionayla.UseVisualStyleBackColor = true;
            this.btnsiparisionayla.Click += new System.EventHandler(this.btnsiparisionayla_Click);
            // 
            // btnveriekle
            // 
            this.btnveriekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnveriekle.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnveriekle.ForeColor = System.Drawing.Color.Red;
            this.btnveriekle.Location = new System.Drawing.Point(720, 378);
            this.btnveriekle.Name = "btnveriekle";
            this.btnveriekle.Size = new System.Drawing.Size(68, 60);
            this.btnveriekle.TabIndex = 6;
            this.btnveriekle.Text = "VERİ EKLE";
            this.btnveriekle.UseVisualStyleBackColor = true;
            // 
            // btnhesapla
            // 
            this.btnhesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhesapla.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Location = new System.Drawing.Point(128, 394);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(69, 31);
            this.btnhesapla.TabIndex = 2;
            this.btnhesapla.Text = "HESAPLA";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnveriekle);
            this.Controls.Add(this.btnsiparisionayla);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.btnsepetekle);
            this.Controls.Add(this.lbsepet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbtnkalinkenar);
            this.Controls.Add(this.rbtnincekenar);
            this.Controls.Add(this.txtadet);
            this.Controls.Add(this.cmbpizzalar);
            this.Controls.Add(this.cmbebatlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltutar);
            this.Controls.Add(this.lbltoplamtutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltutar;
        private System.Windows.Forms.Label lbltoplamtutar;
        private System.Windows.Forms.ComboBox cmbebatlar;
        private System.Windows.Forms.ComboBox cmbpizzalar;
        private System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.RadioButton rbtnincekenar;
        private System.Windows.Forms.RadioButton rbtnkalinkenar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cktpeynir;
        private System.Windows.Forms.CheckBox cktzeytin;
        private System.Windows.Forms.CheckBox ckttonbaligi;
        private System.Windows.Forms.CheckBox cktancuez;
        private System.Windows.Forms.CheckBox cktmantar;
        private System.Windows.Forms.CheckBox cktmisir;
        private System.Windows.Forms.CheckBox cktsucuk;
        private System.Windows.Forms.CheckBox cktsosis;
        private System.Windows.Forms.CheckBox cktsalam;
        private System.Windows.Forms.CheckBox cktdanajabon;
        private System.Windows.Forms.ListBox lbsepet;
        private System.Windows.Forms.Button btnsepetekle;
        private System.Windows.Forms.Button btnsiparisionayla;
        private System.Windows.Forms.Button btnveriekle;
        private System.Windows.Forms.Button btnhesapla;
    }
}

