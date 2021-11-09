namespace WindowsFormsApplication35_sinamaotmsynben
{
    partial class SinemaSalonu
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbfilm = new System.Windows.Forms.ComboBox();
            this.cmbsalon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpsaat = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbboyut = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnode = new System.Windows.Forms.Button();
            this.btnonayla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pRINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(784, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOVIE THEATER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(784, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "MOVIE";
            // 
            // cmbfilm
            // 
            this.cmbfilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbfilm.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbfilm.Items.AddRange(new object[] {
            "Çılgın Hırsız 3",
            "Şansımı Seveyim",
            "Anabelle: Kötülüğün Doğuşu",
            "Şanslı Logan",
            "Cumali Ceber: Allah Seni Alsın",
            "Belalı Tanık",
            "Terminatör 2: Mahşer Günü",
            "Kara Kule",
            "Dangal",
            "Sevimli Emojiler",
            "Doraemon: Buz Devri Macerası",
            "Maymunlar Cehennemi: Savaş"});
            this.cmbfilm.Location = new System.Drawing.Point(791, 224);
            this.cmbfilm.Name = "cmbfilm";
            this.cmbfilm.Size = new System.Drawing.Size(280, 39);
            this.cmbfilm.TabIndex = 2;
            this.cmbfilm.SelectedIndexChanged += new System.EventHandler(this.cmbfilm_SelectedIndexChanged);
            // 
            // cmbsalon
            // 
            this.cmbsalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsalon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbsalon.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbsalon.FormattingEnabled = true;
            this.cmbsalon.Items.AddRange(new object[] {
            "MOVIE THEATER 1",
            "MOVIE THEATER 2",
            "MOVIE THEATER 3",
            "MOVIE THEATER 4",
            "MOVIE THEATER 5"});
            this.cmbsalon.Location = new System.Drawing.Point(791, 309);
            this.cmbsalon.Name = "cmbsalon";
            this.cmbsalon.Size = new System.Drawing.Size(280, 39);
            this.cmbsalon.TabIndex = 2;
            this.cmbsalon.SelectedIndexChanged += new System.EventHandler(this.cmbsalon_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(784, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "TIME : ";
            // 
            // dtpsaat
            // 
            this.dtpsaat.CustomFormat = "HH:mm";
            this.dtpsaat.Font = new System.Drawing.Font("Sitka Small", 15.75F);
            this.dtpsaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpsaat.Location = new System.Drawing.Point(905, 354);
            this.dtpsaat.Name = "dtpsaat";
            this.dtpsaat.Size = new System.Drawing.Size(166, 34);
            this.dtpsaat.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(784, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "DIMENSIONAL : ";
            // 
            // cmbboyut
            // 
            this.cmbboyut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboyut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbboyut.Font = new System.Drawing.Font("Sitka Small", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbboyut.FormattingEnabled = true;
            this.cmbboyut.Items.AddRange(new object[] {
            "2-D",
            "3-D",
            "4-D",
            "5-D"});
            this.cmbboyut.Location = new System.Drawing.Point(1014, 395);
            this.cmbboyut.Name = "cmbboyut";
            this.cmbboyut.Size = new System.Drawing.Size(57, 37);
            this.cmbboyut.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(1077, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(826, 878);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NAME AND SURNAME";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PHONE";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TICKET";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MOVIE";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MOVIE THEATER";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TIME";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "DIM";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "PRICE";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 80;
            // 
            // btnode
            // 
            this.btnode.BackColor = System.Drawing.Color.Silver;
            this.btnode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnode.Font = new System.Drawing.Font("Sitka Small", 20.25F);
            this.btnode.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnode.Location = new System.Drawing.Point(853, 434);
            this.btnode.Name = "btnode";
            this.btnode.Size = new System.Drawing.Size(107, 53);
            this.btnode.TabIndex = 5;
            this.btnode.Text = "PAY";
            this.btnode.UseVisualStyleBackColor = false;
            this.btnode.Click += new System.EventHandler(this.btnode_Click);
            // 
            // btnonayla
            // 
            this.btnonayla.BackColor = System.Drawing.Color.Silver;
            this.btnonayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnonayla.Font = new System.Drawing.Font("Sitka Small", 20.25F);
            this.btnonayla.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnonayla.Location = new System.Drawing.Point(964, 434);
            this.btnonayla.Name = "btnonayla";
            this.btnonayla.Size = new System.Drawing.Size(107, 53);
            this.btnonayla.TabIndex = 5;
            this.btnonayla.Text = "OKAY";
            this.btnonayla.UseVisualStyleBackColor = false;
            this.btnonayla.Click += new System.EventHandler(this.btnonayla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(791, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRINTToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // pRINTToolStripMenuItem
            // 
            this.pRINTToolStripMenuItem.Name = "pRINTToolStripMenuItem";
            this.pRINTToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pRINTToolStripMenuItem.Text = "PRINT";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SinemaSalonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnonayla);
            this.Controls.Add(this.btnode);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dtpsaat);
            this.Controls.Add(this.cmbboyut);
            this.Controls.Add(this.cmbsalon);
            this.Controls.Add(this.cmbfilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "SinemaSalonu";
            this.Text = "SinemaSalonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SinemaSalonu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbfilm;
        private System.Windows.Forms.ComboBox cmbsalon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpsaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbboyut;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnode;
        private System.Windows.Forms.Button btnonayla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}