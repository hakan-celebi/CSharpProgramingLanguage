namespace WindowsFormsApplication21_ornekprogram3
{
    partial class Form4
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
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.btngonder = new System.Windows.Forms.Button();
            this.numsayi = new System.Windows.Forms.NumericUpDown();
            this.lstisim = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numsayi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Neo Sans Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Neo Sans Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(2, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYADI : ";
            // 
            // txtisim
            // 
            this.txtisim.Font = new System.Drawing.Font("Neo Sans Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtisim.Location = new System.Drawing.Point(85, 15);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(187, 31);
            this.txtisim.TabIndex = 0;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Font = new System.Drawing.Font("Neo Sans Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtsoyisim.Location = new System.Drawing.Point(85, 56);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(187, 31);
            this.txtsoyisim.TabIndex = 1;
            // 
            // btngonder
            // 
            this.btngonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngonder.ForeColor = System.Drawing.Color.Crimson;
            this.btngonder.Location = new System.Drawing.Point(197, 101);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(75, 38);
            this.btngonder.TabIndex = 3;
            this.btngonder.Text = "GÖNDER";
            this.btngonder.UseVisualStyleBackColor = true;
            this.btngonder.Click += new System.EventHandler(this.button1_Click);
            // 
            // numsayi
            // 
            this.numsayi.Font = new System.Drawing.Font("Neo Sans Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.numsayi.Location = new System.Drawing.Point(56, 103);
            this.numsayi.Name = "numsayi";
            this.numsayi.Size = new System.Drawing.Size(39, 31);
            this.numsayi.TabIndex = 2;
            // 
            // lstisim
            // 
            this.lstisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstisim.FormattingEnabled = true;
            this.lstisim.ItemHeight = 24;
            this.lstisim.Location = new System.Drawing.Point(301, 15);
            this.lstisim.Name = "lstisim";
            this.lstisim.Size = new System.Drawing.Size(461, 124);
            this.lstisim.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(116, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form4
            // 
            this.AcceptButton = this.btngonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(775, 146);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstisim);
            this.Controls.Add(this.numsayi);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.numsayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Button btngonder;
        private System.Windows.Forms.NumericUpDown numsayi;
        private System.Windows.Forms.ListBox lstisim;
        private System.Windows.Forms.Button button1;
    }
}