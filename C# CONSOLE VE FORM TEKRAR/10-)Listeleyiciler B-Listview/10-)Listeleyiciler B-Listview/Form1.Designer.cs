namespace _10__Listeleyiciler_B_Listview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxttel = new System.Windows.Forms.MaskedTextBox();
            this.mtxttc = new System.Windows.Forms.MaskedTextBox();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.nudyas = new System.Windows.Forms.NumericUpDown();
            this.nudmaas = new System.Windows.Forms.NumericUpDown();
            this.cbmeslek = new System.Windows.Forms.ComboBox();
            this.lvliste = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudyas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmaas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(181, -79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 206);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAMBLY COMPANY ÇALIŞAN EKLEME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "İSİM - SOYİSİM :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(374, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "TELEFON :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(712, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "T.C. KİMLİK NO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(113, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "YAŞ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(384, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "MESLEK :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(809, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "MAAŞ :";
            // 
            // mtxttel
            // 
            this.mtxttel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.mtxttel.Location = new System.Drawing.Point(491, 62);
            this.mtxttel.Mask = "(999) 000-0000";
            this.mtxttel.Name = "mtxttel";
            this.mtxttel.Size = new System.Drawing.Size(196, 32);
            this.mtxttel.TabIndex = 1;
            // 
            // mtxttc
            // 
            this.mtxttc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.mtxttc.Location = new System.Drawing.Point(887, 62);
            this.mtxttc.Mask = "00000000000";
            this.mtxttc.Name = "mtxttc";
            this.mtxttc.Size = new System.Drawing.Size(196, 32);
            this.mtxttc.TabIndex = 2;
            // 
            // txtisim
            // 
            this.txtisim.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtisim.Location = new System.Drawing.Point(170, 62);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(198, 32);
            this.txtisim.TabIndex = 0;
            // 
            // nudyas
            // 
            this.nudyas.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.nudyas.Location = new System.Drawing.Point(170, 113);
            this.nudyas.Name = "nudyas";
            this.nudyas.Size = new System.Drawing.Size(61, 32);
            this.nudyas.TabIndex = 3;
            this.nudyas.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // nudmaas
            // 
            this.nudmaas.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.nudmaas.Location = new System.Drawing.Point(887, 113);
            this.nudmaas.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudmaas.Name = "nudmaas";
            this.nudmaas.Size = new System.Drawing.Size(93, 32);
            this.nudmaas.TabIndex = 5;
            this.nudmaas.Value = new decimal(new int[] {
            1740,
            0,
            0,
            0});
            // 
            // cbmeslek
            // 
            this.cbmeslek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmeslek.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbmeslek.FormattingEnabled = true;
            this.cbmeslek.Items.AddRange(new object[] {
            "YAZILIM",
            "GRAFİKER",
            "AŞÇI",
            "ÇAYCI",
            "TEMİZLİKÇİ",
            "ŞOFÖR",
            "MAKİNE MÜHENDİSİ",
            "MEKATRONİK MÜHENDİSİ",
            "ELEKTRİK ELEKTRONİK MÜHENDİSİ",
            "ALIŞVERİŞÇİ",
            "MUHASEBECİ",
            "PAZARLAMACI"});
            this.cbmeslek.Location = new System.Drawing.Point(491, 112);
            this.cbmeslek.Name = "cbmeslek";
            this.cbmeslek.Size = new System.Drawing.Size(196, 32);
            this.cbmeslek.TabIndex = 4;
            // 
            // lvliste
            // 
            this.lvliste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvliste.GridLines = true;
            this.lvliste.Location = new System.Drawing.Point(27, 156);
            this.lvliste.Name = "lvliste";
            this.lvliste.Size = new System.Drawing.Size(1069, 463);
            this.lvliste.TabIndex = 6;
            this.lvliste.UseCompatibleStateImageBehavior = false;
            this.lvliste.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İSİM-SOYİSİM";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TELEFON";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "T.C. KİMLİK NO";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "YAŞ";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MESLEK";
            this.columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MAAŞ";
            this.columnHeader6.Width = 157;
            // 
            // btnekle
            // 
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnekle.Location = new System.Drawing.Point(999, 111);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(97, 33);
            this.btnekle.TabIndex = 6;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 631);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lvliste);
            this.Controls.Add(this.cbmeslek);
            this.Controls.Add(this.nudmaas);
            this.Controls.Add(this.nudyas);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.mtxttc);
            this.Controls.Add(this.mtxttel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAMBLY COMPANY";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudyas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmaas)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox mtxttel;
        private System.Windows.Forms.MaskedTextBox mtxttc;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.NumericUpDown nudyas;
        private System.Windows.Forms.NumericUpDown nudmaas;
        private System.Windows.Forms.ComboBox cbmeslek;
        private System.Windows.Forms.ListView lvliste;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnekle;
    }
}

