namespace WindowsFormsApplication29_atyarisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.YAĞIZ = new System.Windows.Forms.PictureBox();
            this.RÜZGAR = new System.Windows.Forms.PictureBox();
            this.btnbaslat = new System.Windows.Forms.Button();
            this.POYRAZ = new System.Windows.Forms.PictureBox();
            this.GÖLGE = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblyagiz = new System.Windows.Forms.Label();
            this.lblpoyraz = new System.Windows.Forms.Label();
            this.lblruzgar = new System.Windows.Forms.Label();
            this.lblgolge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.YAĞIZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RÜZGAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POYRAZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GÖLGE)).BeginInit();
            this.SuspendLayout();
            // 
            // YAĞIZ
            // 
            this.YAĞIZ.Image = ((System.Drawing.Image)(resources.GetObject("YAĞIZ.Image")));
            this.YAĞIZ.Location = new System.Drawing.Point(12, 87);
            this.YAĞIZ.Name = "YAĞIZ";
            this.YAĞIZ.Size = new System.Drawing.Size(283, 212);
            this.YAĞIZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YAĞIZ.TabIndex = 0;
            this.YAĞIZ.TabStop = false;
            // 
            // RÜZGAR
            // 
            this.RÜZGAR.Image = ((System.Drawing.Image)(resources.GetObject("RÜZGAR.Image")));
            this.RÜZGAR.Location = new System.Drawing.Point(12, 558);
            this.RÜZGAR.Name = "RÜZGAR";
            this.RÜZGAR.Size = new System.Drawing.Size(283, 212);
            this.RÜZGAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RÜZGAR.TabIndex = 0;
            this.RÜZGAR.TabStop = false;
            // 
            // btnbaslat
            // 
            this.btnbaslat.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnbaslat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbaslat.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaslat.ForeColor = System.Drawing.Color.Crimson;
            this.btnbaslat.Location = new System.Drawing.Point(12, 12);
            this.btnbaslat.Name = "btnbaslat";
            this.btnbaslat.Size = new System.Drawing.Size(231, 49);
            this.btnbaslat.TabIndex = 1;
            this.btnbaslat.Text = "START RACE";
            this.btnbaslat.UseVisualStyleBackColor = false;
            this.btnbaslat.Click += new System.EventHandler(this.btnbaslat_Click);
            // 
            // POYRAZ
            // 
            this.POYRAZ.Image = ((System.Drawing.Image)(resources.GetObject("POYRAZ.Image")));
            this.POYRAZ.Location = new System.Drawing.Point(12, 325);
            this.POYRAZ.Name = "POYRAZ";
            this.POYRAZ.Size = new System.Drawing.Size(283, 212);
            this.POYRAZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.POYRAZ.TabIndex = 0;
            this.POYRAZ.TabStop = false;
            // 
            // GÖLGE
            // 
            this.GÖLGE.Image = ((System.Drawing.Image)(resources.GetObject("GÖLGE.Image")));
            this.GÖLGE.Location = new System.Drawing.Point(12, 787);
            this.GÖLGE.Name = "GÖLGE";
            this.GÖLGE.Size = new System.Drawing.Size(283, 212);
            this.GÖLGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GÖLGE.TabIndex = 0;
            this.GÖLGE.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(3804, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 1050);
            this.label1.TabIndex = 2;
            this.label1.Text = "FINISH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblyagiz
            // 
            this.lblyagiz.AutoSize = true;
            this.lblyagiz.BackColor = System.Drawing.Color.Transparent;
            this.lblyagiz.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyagiz.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblyagiz.Location = new System.Drawing.Point(190, 87);
            this.lblyagiz.Name = "lblyagiz";
            this.lblyagiz.Size = new System.Drawing.Size(105, 14);
            this.lblyagiz.TabIndex = 3;
            this.lblyagiz.Text = "1 NUMARA YAĞIZ";
            // 
            // lblpoyraz
            // 
            this.lblpoyraz.AutoSize = true;
            this.lblpoyraz.BackColor = System.Drawing.Color.Transparent;
            this.lblpoyraz.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.lblpoyraz.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblpoyraz.Location = new System.Drawing.Point(178, 325);
            this.lblpoyraz.Name = "lblpoyraz";
            this.lblpoyraz.Size = new System.Drawing.Size(116, 14);
            this.lblpoyraz.TabIndex = 3;
            this.lblpoyraz.Text = "2 NUMARA POYRAZ";
            // 
            // lblruzgar
            // 
            this.lblruzgar.AutoSize = true;
            this.lblruzgar.BackColor = System.Drawing.Color.Transparent;
            this.lblruzgar.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.lblruzgar.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblruzgar.Location = new System.Drawing.Point(178, 558);
            this.lblruzgar.Name = "lblruzgar";
            this.lblruzgar.Size = new System.Drawing.Size(117, 14);
            this.lblruzgar.TabIndex = 3;
            this.lblruzgar.Text = "3 NUMARA RÜZGAR";
            // 
            // lblgolge
            // 
            this.lblgolge.AutoSize = true;
            this.lblgolge.BackColor = System.Drawing.Color.Transparent;
            this.lblgolge.Font = new System.Drawing.Font("Lucida Bright", 8.25F);
            this.lblgolge.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblgolge.Location = new System.Drawing.Point(188, 787);
            this.lblgolge.Name = "lblgolge";
            this.lblgolge.Size = new System.Drawing.Size(107, 14);
            this.lblgolge.TabIndex = 3;
            this.lblgolge.Text = "4 NUMARA GÖLGE";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnbaslat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(3836, 1041);
            this.Controls.Add(this.lblgolge);
            this.Controls.Add(this.lblruzgar);
            this.Controls.Add(this.lblpoyraz);
            this.Controls.Add(this.lblyagiz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbaslat);
            this.Controls.Add(this.RÜZGAR);
            this.Controls.Add(this.GÖLGE);
            this.Controls.Add(this.POYRAZ);
            this.Controls.Add(this.YAĞIZ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YAĞIZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RÜZGAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POYRAZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GÖLGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox YAĞIZ;
        private System.Windows.Forms.PictureBox RÜZGAR;
        private System.Windows.Forms.Button btnbaslat;
        private System.Windows.Forms.PictureBox POYRAZ;
        private System.Windows.Forms.PictureBox GÖLGE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblyagiz;
        private System.Windows.Forms.Label lblpoyraz;
        private System.Windows.Forms.Label lblruzgar;
        private System.Windows.Forms.Label lblgolge;
    }
}

