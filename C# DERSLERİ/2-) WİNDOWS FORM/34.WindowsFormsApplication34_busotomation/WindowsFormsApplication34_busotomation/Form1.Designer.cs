namespace WindowsFormsApplication34_busotomation
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbotobus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbnerden = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbnereye = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudfiyat = new System.Windows.Forms.NumericUpDown();
            this.btnal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rESERVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.columnHeader8});
            this.listView1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(816, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(919, 674);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CUSTOMER";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PHONE";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SEX";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "FROM WHERE";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TO WHERE";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SEAT";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "DATE";
            this.columnHeader7.Width = 170;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "PRICA";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // cmbotobus
            // 
            this.cmbotobus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbotobus.DisplayMember = "1";
            this.cmbotobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbotobus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbotobus.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.cmbotobus.ForeColor = System.Drawing.Color.White;
            this.cmbotobus.FormattingEnabled = true;
            this.cmbotobus.Items.AddRange(new object[] {
            "TRAVEGO",
            "NEOPLAN",
            "SETRA"});
            this.cmbotobus.Location = new System.Drawing.Point(556, 32);
            this.cmbotobus.Name = "cmbotobus";
            this.cmbotobus.Size = new System.Drawing.Size(236, 36);
            this.cmbotobus.TabIndex = 0;
            this.cmbotobus.SelectedIndexChanged += new System.EventHandler(this.cmbotobus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(553, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "WHERE GOING";
            // 
            // cmbnerden
            // 
            this.cmbnerden.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbnerden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnerden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbnerden.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.cmbnerden.ForeColor = System.Drawing.Color.White;
            this.cmbnerden.FormattingEnabled = true;
            this.cmbnerden.Items.AddRange(new object[] {
            "ISTANBUL",
            "KABUL",
            "TIRANE",
            "ALGIERS",
            "BUENOS AIRES",
            "BRASILIA",
            "SOFIA",
            "BEIJING",
            "BERLIN",
            "PARIS",
            "ROME",
            "OSLO",
            "LONDON",
            "WASHINGTON D.C."});
            this.cmbnerden.Location = new System.Drawing.Point(556, 124);
            this.cmbnerden.Name = "cmbnerden";
            this.cmbnerden.Size = new System.Drawing.Size(236, 36);
            this.cmbnerden.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(553, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "WHERE";
            // 
            // cmbnereye
            // 
            this.cmbnereye.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbnereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnereye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbnereye.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.cmbnereye.ForeColor = System.Drawing.Color.White;
            this.cmbnereye.FormattingEnabled = true;
            this.cmbnereye.Items.AddRange(new object[] {
            "ISTANBUL",
            "KABUL",
            "TIRANE",
            "ALGIERS",
            "BUENOS AIRES",
            "BRASILIA",
            "SOFIA",
            "BEIJING",
            "BERLIN",
            "PARIS",
            "ROME",
            "OSLO",
            "LONDON",
            "WASHINGTON D.C."});
            this.cmbnereye.Location = new System.Drawing.Point(556, 187);
            this.cmbnereye.Name = "cmbnereye";
            this.cmbnereye.Size = new System.Drawing.Size(236, 36);
            this.cmbnereye.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(551, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "SELECT BUS TIME";
            // 
            // dttarih
            // 
            this.dttarih.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dttarih.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dttarih.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.dttarih.Location = new System.Drawing.Point(556, 268);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(236, 33);
            this.dttarih.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(553, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "HOW MUCH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(553, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "SELECT BUS";
            // 
            // nudfiyat
            // 
            this.nudfiyat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nudfiyat.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.nudfiyat.ForeColor = System.Drawing.Color.White;
            this.nudfiyat.Location = new System.Drawing.Point(556, 329);
            this.nudfiyat.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudfiyat.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudfiyat.Name = "nudfiyat";
            this.nudfiyat.Size = new System.Drawing.Size(236, 33);
            this.nudfiyat.TabIndex = 4;
            this.nudfiyat.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnal
            // 
            this.btnal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnal.Font = new System.Drawing.Font("LeviBrush", 14.25F);
            this.btnal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnal.Location = new System.Drawing.Point(691, 368);
            this.btnal.Name = "btnal";
            this.btnal.Size = new System.Drawing.Size(101, 35);
            this.btnal.TabIndex = 5;
            this.btnal.Text = "BUY";
            this.btnal.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Orator Std", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(544, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 171);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DIRECTION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Letter Gothic Std", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(750, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "(USD)";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rESERVEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // rESERVEToolStripMenuItem
            // 
            this.rESERVEToolStripMenuItem.Name = "rESERVEToolStripMenuItem";
            this.rESERVEToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.rESERVEToolStripMenuItem.Text = "Reserve";
            this.rESERVEToolStripMenuItem.Click += new System.EventHandler(this.rESERVEToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnal);
            this.Controls.Add(this.nudfiyat);
            this.Controls.Add(this.dttarih);
            this.Controls.Add(this.cmbnereye);
            this.Controls.Add(this.cmbnerden);
            this.Controls.Add(this.cmbotobus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbotobus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbnerden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbnereye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudfiyat;
        private System.Windows.Forms.Button btnal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rESERVEToolStripMenuItem;
    }
}

