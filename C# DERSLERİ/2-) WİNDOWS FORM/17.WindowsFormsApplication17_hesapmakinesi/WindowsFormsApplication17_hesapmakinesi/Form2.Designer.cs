namespace WindowsFormsApplication17_hesapmakinesi
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbislem = new System.Windows.Forms.ComboBox();
            this.sayi1 = new System.Windows.Forms.NumericUpDown();
            this.sayi2 = new System.Windows.Forms.NumericUpDown();
            this.buttonsonuc = new System.Windows.Forms.Button();
            this.sncyazi = new System.Windows.Forms.Label();
            this.snchesap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sayi2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.SAYI : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(39, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "İŞLEM : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(39, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "2.SAYI : ";
            // 
            // cmbislem
            // 
            this.cmbislem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbislem.ForeColor = System.Drawing.Color.Crimson;
            this.cmbislem.FormattingEnabled = true;
            this.cmbislem.Items.AddRange(new object[] {
            "+",
            "-",
            "X",
            "/",
            "%"});
            this.cmbislem.Location = new System.Drawing.Point(117, 105);
            this.cmbislem.Name = "cmbislem";
            this.cmbislem.Size = new System.Drawing.Size(120, 32);
            this.cmbislem.TabIndex = 1;
            // 
            // sayi1
            // 
            this.sayi1.BackColor = System.Drawing.Color.GhostWhite;
            this.sayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayi1.Location = new System.Drawing.Point(117, 45);
            this.sayi1.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.sayi1.Minimum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            -2147483648});
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(120, 29);
            this.sayi1.TabIndex = 0;
            // 
            // sayi2
            // 
            this.sayi2.BackColor = System.Drawing.Color.GhostWhite;
            this.sayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayi2.Location = new System.Drawing.Point(117, 165);
            this.sayi2.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.sayi2.Minimum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            -2147483648});
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(120, 29);
            this.sayi2.TabIndex = 2;
            // 
            // buttonsonuc
            // 
            this.buttonsonuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsonuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsonuc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonsonuc.Location = new System.Drawing.Point(75, 222);
            this.buttonsonuc.Name = "buttonsonuc";
            this.buttonsonuc.Size = new System.Drawing.Size(162, 58);
            this.buttonsonuc.TabIndex = 3;
            this.buttonsonuc.Text = "SONUÇ";
            this.buttonsonuc.UseVisualStyleBackColor = false;
            this.buttonsonuc.Click += new System.EventHandler(this.buttonsonuc_Click);
            // 
            // sncyazi
            // 
            this.sncyazi.AutoSize = true;
            this.sncyazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sncyazi.Location = new System.Drawing.Point(287, 107);
            this.sncyazi.Name = "sncyazi";
            this.sncyazi.Size = new System.Drawing.Size(113, 25);
            this.sncyazi.TabIndex = 10;
            this.sncyazi.Text = "SONUÇ : ";
            // 
            // snchesap
            // 
            this.snchesap.AutoSize = true;
            this.snchesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snchesap.Location = new System.Drawing.Point(447, 107);
            this.snchesap.Name = "snchesap";
            this.snchesap.Size = new System.Drawing.Size(33, 25);
            this.snchesap.TabIndex = 11;
            this.snchesap.Text = "...";
            // 
            // Form2
            // 
            this.AcceptButton = this.buttonsonuc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 323);
            this.Controls.Add(this.snchesap);
            this.Controls.Add(this.sncyazi);
            this.Controls.Add(this.buttonsonuc);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sayi1);
            this.Controls.Add(this.cmbislem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sayi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbislem;
        private System.Windows.Forms.NumericUpDown sayi1;
        private System.Windows.Forms.NumericUpDown sayi2;
        private System.Windows.Forms.Button buttonsonuc;
        private System.Windows.Forms.Label sncyazi;
        private System.Windows.Forms.Label snchesap;

    }
}