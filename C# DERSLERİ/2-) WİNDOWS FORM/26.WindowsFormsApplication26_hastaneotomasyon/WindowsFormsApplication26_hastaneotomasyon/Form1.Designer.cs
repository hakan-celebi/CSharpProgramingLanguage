namespace WindowsFormsApplication26_hastaneotomasyon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbklinik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbsehir = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.mtxttckn = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnsaat1 = new System.Windows.Forms.Button();
            this.btnsaat2 = new System.Windows.Forms.Button();
            this.btnsaat3 = new System.Windows.Forms.Button();
            this.btnsaat4 = new System.Windows.Forms.Button();
            this.btnsaat5 = new System.Windows.Forms.Button();
            this.btnsaat6 = new System.Windows.Forms.Button();
            this.btnsaat7 = new System.Windows.Forms.Button();
            this.btnsaat8 = new System.Windows.Forms.Button();
            this.btnsaat9 = new System.Windows.Forms.Button();
            this.btnsaat10 = new System.Windows.Forms.Button();
            this.btnsaat11 = new System.Windows.Forms.Button();
            this.btnsaat12 = new System.Windows.Forms.Button();
            this.btnsaat13 = new System.Windows.Forms.Button();
            this.btnsaat14 = new System.Windows.Forms.Button();
            this.btnsaat15 = new System.Windows.Forms.Button();
            this.btnsaat16 = new System.Windows.Forms.Button();
            this.lbltarih = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtalinanisim = new System.Windows.Forms.TextBox();
            this.txtalinansaat = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "KLİNİK";
            // 
            // cmbklinik
            // 
            this.cmbklinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.cmbklinik.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbklinik.FormattingEnabled = true;
            this.cmbklinik.Location = new System.Drawing.Point(456, 265);
            this.cmbklinik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbklinik.Name = "cmbklinik";
            this.cmbklinik.Size = new System.Drawing.Size(333, 44);
            this.cmbklinik.TabIndex = 3;
            this.cmbklinik.SelectedValueChanged += new System.EventHandler(this.cmbklinik_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "ŞEHİR";
            // 
            // cmbsehir
            // 
            this.cmbsehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.cmbsehir.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbsehir.FormattingEnabled = true;
            this.cmbsehir.Items.AddRange(new object[] {
            "KONYA",
            "İSTANBUL",
            "ANKARA",
            "SİVAS",
            "ERZURUM",
            "YOZGAT"});
            this.cmbsehir.Location = new System.Drawing.Point(65, 265);
            this.cmbsehir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbsehir.Name = "cmbsehir";
            this.cmbsehir.Size = new System.Drawing.Size(333, 44);
            this.cmbsehir.TabIndex = 2;
            this.cmbsehir.SelectedValueChanged += new System.EventHandler(this.cmbsehir_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(951, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "DOKTOR";
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.cmbdoktor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(848, 265);
            this.cmbdoktor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(333, 44);
            this.cmbdoktor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(859, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "TCKN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "İSİM SOYİSİM : ";
            // 
            // txtisim
            // 
            this.txtisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.txtisim.Location = new System.Drawing.Point(281, 74);
            this.txtisim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(329, 41);
            this.txtisim.TabIndex = 0;
            this.txtisim.TextChanged += new System.EventHandler(this.txtisim_TextChanged);
            // 
            // mtxttckn
            // 
            this.mtxttckn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.mtxttckn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.mtxttckn.Location = new System.Drawing.Point(1007, 78);
            this.mtxttckn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxttckn.Mask = "00000000000";
            this.mtxttckn.Name = "mtxttckn";
            this.mtxttckn.Size = new System.Drawing.Size(192, 41);
            this.mtxttckn.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 588);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "RANDEVU SAATİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 352);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "RANDEVU TARİHİ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(483, 404);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 37);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnsaat1
            // 
            this.btnsaat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat1.Location = new System.Drawing.Point(101, 662);
            this.btnsaat1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat1.Name = "btnsaat1";
            this.btnsaat1.Size = new System.Drawing.Size(127, 76);
            this.btnsaat1.TabIndex = 6;
            this.btnsaat1.Text = "08:30";
            this.btnsaat1.UseVisualStyleBackColor = true;
            this.btnsaat1.Click += new System.EventHandler(this.btnsaat1_Click);
            // 
            // btnsaat2
            // 
            this.btnsaat2.BackColor = System.Drawing.Color.Red;
            this.btnsaat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat2.Location = new System.Drawing.Point(236, 662);
            this.btnsaat2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat2.Name = "btnsaat2";
            this.btnsaat2.Size = new System.Drawing.Size(127, 76);
            this.btnsaat2.TabIndex = 7;
            this.btnsaat2.Text = "09:00";
            this.btnsaat2.UseVisualStyleBackColor = false;
            this.btnsaat2.Click += new System.EventHandler(this.btnsaat2_Click);
            // 
            // btnsaat3
            // 
            this.btnsaat3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat3.Location = new System.Drawing.Point(371, 662);
            this.btnsaat3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat3.Name = "btnsaat3";
            this.btnsaat3.Size = new System.Drawing.Size(127, 76);
            this.btnsaat3.TabIndex = 8;
            this.btnsaat3.Text = "09:30";
            this.btnsaat3.UseVisualStyleBackColor = true;
            this.btnsaat3.Click += new System.EventHandler(this.btnsaat3_Click);
            // 
            // btnsaat4
            // 
            this.btnsaat4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat4.Location = new System.Drawing.Point(505, 662);
            this.btnsaat4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat4.Name = "btnsaat4";
            this.btnsaat4.Size = new System.Drawing.Size(127, 76);
            this.btnsaat4.TabIndex = 9;
            this.btnsaat4.Text = "10:00";
            this.btnsaat4.UseVisualStyleBackColor = true;
            this.btnsaat4.Click += new System.EventHandler(this.btnsaat4_Click);
            // 
            // btnsaat5
            // 
            this.btnsaat5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat5.Location = new System.Drawing.Point(640, 662);
            this.btnsaat5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat5.Name = "btnsaat5";
            this.btnsaat5.Size = new System.Drawing.Size(127, 76);
            this.btnsaat5.TabIndex = 10;
            this.btnsaat5.Text = "00:18";
            this.btnsaat5.UseVisualStyleBackColor = true;
            this.btnsaat5.Click += new System.EventHandler(this.btnsaat5_Click);
            // 
            // btnsaat6
            // 
            this.btnsaat6.BackColor = System.Drawing.Color.Red;
            this.btnsaat6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat6.Location = new System.Drawing.Point(775, 662);
            this.btnsaat6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat6.Name = "btnsaat6";
            this.btnsaat6.Size = new System.Drawing.Size(127, 76);
            this.btnsaat6.TabIndex = 11;
            this.btnsaat6.Text = "11:00";
            this.btnsaat6.UseVisualStyleBackColor = false;
            this.btnsaat6.Click += new System.EventHandler(this.btnsaat6_Click);
            // 
            // btnsaat7
            // 
            this.btnsaat7.BackColor = System.Drawing.Color.Red;
            this.btnsaat7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat7.Location = new System.Drawing.Point(909, 662);
            this.btnsaat7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat7.Name = "btnsaat7";
            this.btnsaat7.Size = new System.Drawing.Size(127, 76);
            this.btnsaat7.TabIndex = 12;
            this.btnsaat7.Text = "11:30";
            this.btnsaat7.UseVisualStyleBackColor = false;
            this.btnsaat7.Click += new System.EventHandler(this.btnsaat7_Click);
            // 
            // btnsaat8
            // 
            this.btnsaat8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat8.Location = new System.Drawing.Point(1044, 662);
            this.btnsaat8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat8.Name = "btnsaat8";
            this.btnsaat8.Size = new System.Drawing.Size(127, 76);
            this.btnsaat8.TabIndex = 13;
            this.btnsaat8.Text = "12:00";
            this.btnsaat8.UseVisualStyleBackColor = true;
            this.btnsaat8.Click += new System.EventHandler(this.btnsaat8_Click);
            // 
            // btnsaat9
            // 
            this.btnsaat9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat9.Location = new System.Drawing.Point(101, 746);
            this.btnsaat9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat9.Name = "btnsaat9";
            this.btnsaat9.Size = new System.Drawing.Size(127, 76);
            this.btnsaat9.TabIndex = 14;
            this.btnsaat9.Text = "13:30";
            this.btnsaat9.UseVisualStyleBackColor = true;
            this.btnsaat9.Click += new System.EventHandler(this.btnsaat9_Click);
            // 
            // btnsaat10
            // 
            this.btnsaat10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat10.Location = new System.Drawing.Point(236, 746);
            this.btnsaat10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat10.Name = "btnsaat10";
            this.btnsaat10.Size = new System.Drawing.Size(127, 76);
            this.btnsaat10.TabIndex = 15;
            this.btnsaat10.Text = "14:00";
            this.btnsaat10.UseVisualStyleBackColor = true;
            this.btnsaat10.Click += new System.EventHandler(this.btnsaat10_Click);
            // 
            // btnsaat11
            // 
            this.btnsaat11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat11.Location = new System.Drawing.Point(371, 746);
            this.btnsaat11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat11.Name = "btnsaat11";
            this.btnsaat11.Size = new System.Drawing.Size(127, 76);
            this.btnsaat11.TabIndex = 16;
            this.btnsaat11.Text = "14:30";
            this.btnsaat11.UseVisualStyleBackColor = true;
            this.btnsaat11.Click += new System.EventHandler(this.btnsaat11_Click);
            // 
            // btnsaat12
            // 
            this.btnsaat12.BackColor = System.Drawing.Color.Red;
            this.btnsaat12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat12.Location = new System.Drawing.Point(505, 746);
            this.btnsaat12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat12.Name = "btnsaat12";
            this.btnsaat12.Size = new System.Drawing.Size(127, 76);
            this.btnsaat12.TabIndex = 17;
            this.btnsaat12.Text = "15:00";
            this.btnsaat12.UseVisualStyleBackColor = false;
            this.btnsaat12.Click += new System.EventHandler(this.btnsaat12_Click);
            // 
            // btnsaat13
            // 
            this.btnsaat13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat13.Location = new System.Drawing.Point(640, 746);
            this.btnsaat13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat13.Name = "btnsaat13";
            this.btnsaat13.Size = new System.Drawing.Size(127, 76);
            this.btnsaat13.TabIndex = 18;
            this.btnsaat13.Text = "21:35";
            this.btnsaat13.UseVisualStyleBackColor = true;
            this.btnsaat13.Click += new System.EventHandler(this.btnsaat13_Click);
            // 
            // btnsaat14
            // 
            this.btnsaat14.BackColor = System.Drawing.Color.Red;
            this.btnsaat14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat14.Location = new System.Drawing.Point(775, 746);
            this.btnsaat14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat14.Name = "btnsaat14";
            this.btnsaat14.Size = new System.Drawing.Size(127, 76);
            this.btnsaat14.TabIndex = 19;
            this.btnsaat14.Text = "16:00";
            this.btnsaat14.UseVisualStyleBackColor = false;
            this.btnsaat14.Click += new System.EventHandler(this.btnsaat14_Click);
            // 
            // btnsaat15
            // 
            this.btnsaat15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat15.Location = new System.Drawing.Point(909, 746);
            this.btnsaat15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat15.Name = "btnsaat15";
            this.btnsaat15.Size = new System.Drawing.Size(127, 76);
            this.btnsaat15.TabIndex = 20;
            this.btnsaat15.Text = "16:30";
            this.btnsaat15.UseVisualStyleBackColor = true;
            this.btnsaat15.Click += new System.EventHandler(this.btnsaat15_Click);
            // 
            // btnsaat16
            // 
            this.btnsaat16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaat16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaat16.Location = new System.Drawing.Point(1044, 746);
            this.btnsaat16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsaat16.Name = "btnsaat16";
            this.btnsaat16.Size = new System.Drawing.Size(127, 76);
            this.btnsaat16.TabIndex = 21;
            this.btnsaat16.Text = "17:00";
            this.btnsaat16.UseVisualStyleBackColor = true;
            this.btnsaat16.Click += new System.EventHandler(this.btnsaat16_Click);
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltarih.Location = new System.Drawing.Point(1171, 11);
            this.lbltarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(0, 29);
            this.lbltarih.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(865, 481);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 70);
            this.button1.TabIndex = 22;
            this.button1.Text = "RANDEVU AL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtalinanisim
            // 
            this.txtalinanisim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtalinanisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.txtalinanisim.Location = new System.Drawing.Point(327, 490);
            this.txtalinanisim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtalinanisim.Name = "txtalinanisim";
            this.txtalinanisim.ReadOnly = true;
            this.txtalinanisim.Size = new System.Drawing.Size(329, 41);
            this.txtalinanisim.TabIndex = 6;
            // 
            // txtalinansaat
            // 
            this.txtalinansaat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtalinansaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.txtalinansaat.Location = new System.Drawing.Point(692, 490);
            this.txtalinansaat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtalinansaat.Name = "txtalinansaat";
            this.txtalinansaat.ReadOnly = true;
            this.txtalinansaat.Size = new System.Drawing.Size(119, 41);
            this.txtalinansaat.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "İSİM SOYİSİM : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 927);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.btnsaat16);
            this.Controls.Add(this.btnsaat15);
            this.Controls.Add(this.btnsaat8);
            this.Controls.Add(this.btnsaat14);
            this.Controls.Add(this.btnsaat7);
            this.Controls.Add(this.btnsaat13);
            this.Controls.Add(this.btnsaat6);
            this.Controls.Add(this.btnsaat12);
            this.Controls.Add(this.btnsaat5);
            this.Controls.Add(this.btnsaat11);
            this.Controls.Add(this.btnsaat4);
            this.Controls.Add(this.btnsaat10);
            this.Controls.Add(this.btnsaat3);
            this.Controls.Add(this.btnsaat9);
            this.Controls.Add(this.btnsaat2);
            this.Controls.Add(this.btnsaat1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.mtxttckn);
            this.Controls.Add(this.txtalinanisim);
            this.Controls.Add(this.txtalinansaat);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.cmbdoktor);
            this.Controls.Add(this.cmbsehir);
            this.Controls.Add(this.cmbklinik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "HASTANE RANDEVU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbklinik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbsehir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.MaskedTextBox mtxttckn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnsaat1;
        private System.Windows.Forms.Button btnsaat2;
        private System.Windows.Forms.Button btnsaat3;
        private System.Windows.Forms.Button btnsaat4;
        private System.Windows.Forms.Button btnsaat5;
        private System.Windows.Forms.Button btnsaat6;
        private System.Windows.Forms.Button btnsaat7;
        private System.Windows.Forms.Button btnsaat8;
        private System.Windows.Forms.Button btnsaat9;
        private System.Windows.Forms.Button btnsaat10;
        private System.Windows.Forms.Button btnsaat11;
        private System.Windows.Forms.Button btnsaat12;
        private System.Windows.Forms.Button btnsaat13;
        private System.Windows.Forms.Button btnsaat14;
        private System.Windows.Forms.Button btnsaat15;
        private System.Windows.Forms.Button btnsaat16;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtalinanisim;
        private System.Windows.Forms.TextBox txtalinansaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label8;
    }
}

