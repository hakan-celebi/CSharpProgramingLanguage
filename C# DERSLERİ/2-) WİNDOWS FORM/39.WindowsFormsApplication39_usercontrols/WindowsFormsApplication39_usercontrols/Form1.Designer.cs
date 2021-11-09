namespace WindowsFormsApplication39_usercontrols
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ctrlisim = new WindowsFormsApplication39_usercontrols.UserControl1();
            this.ctrlsoyisim = new WindowsFormsApplication39_usercontrols.UserControl1();
            this.ctrladres = new WindowsFormsApplication39_usercontrols.UserControl1();
            this.ctrltelefon = new WindowsFormsApplication39_usercontrols.UserControl1();
            this.btniseal = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 187);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1161, 394);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ctrlisim
            // 
            this.ctrlisim.BackColor = System.Drawing.Color.Transparent;
            this.ctrlisim.Location = new System.Drawing.Point(12, 12);
            this.ctrlisim.Name = "ctrlisim";
            this.ctrlisim.Size = new System.Drawing.Size(428, 72);
            this.ctrlisim.TabIndex = 1;
            // 
            // ctrlsoyisim
            // 
            this.ctrlsoyisim.BackColor = System.Drawing.Color.Transparent;
            this.ctrlsoyisim.Location = new System.Drawing.Point(12, 90);
            this.ctrlsoyisim.Name = "ctrlsoyisim";
            this.ctrlsoyisim.Size = new System.Drawing.Size(428, 72);
            this.ctrlsoyisim.TabIndex = 2;
            // 
            // ctrladres
            // 
            this.ctrladres.BackColor = System.Drawing.Color.Transparent;
            this.ctrladres.Location = new System.Drawing.Point(551, 12);
            this.ctrladres.Name = "ctrladres";
            this.ctrladres.Size = new System.Drawing.Size(420, 72);
            this.ctrladres.TabIndex = 3;
            // 
            // ctrltelefon
            // 
            this.ctrltelefon.BackColor = System.Drawing.Color.Transparent;
            this.ctrltelefon.Location = new System.Drawing.Point(551, 90);
            this.ctrltelefon.Name = "ctrltelefon";
            this.ctrltelefon.Size = new System.Drawing.Size(420, 72);
            this.ctrltelefon.TabIndex = 4;
            // 
            // btniseal
            // 
            this.btniseal.BackColor = System.Drawing.Color.Gainsboro;
            this.btniseal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniseal.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, System.Drawing.FontStyle.Bold);
            this.btniseal.ForeColor = System.Drawing.Color.Crimson;
            this.btniseal.Location = new System.Drawing.Point(1006, 68);
            this.btniseal.Name = "btniseal";
            this.btniseal.Size = new System.Drawing.Size(113, 43);
            this.btniseal.TabIndex = 5;
            this.btniseal.Text = "İŞE AL";
            this.btniseal.UseVisualStyleBackColor = false;
            this.btniseal.Click += new System.EventHandler(this.btniseal_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İSİM";
            this.columnHeader1.Width = 416;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SOYİSMİ";
            this.columnHeader2.Width = 307;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ADRES";
            this.columnHeader3.Width = 307;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TELEFON";
            this.columnHeader4.Width = 118;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 593);
            this.Controls.Add(this.btniseal);
            this.Controls.Add(this.ctrltelefon);
            this.Controls.Add(this.ctrladres);
            this.Controls.Add(this.ctrlsoyisim);
            this.Controls.Add(this.ctrlisim);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btniseal;
        public UserControl1 ctrlisim;
        public UserControl1 ctrlsoyisim;
        public UserControl1 ctrladres;
        public UserControl1 ctrltelefon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

