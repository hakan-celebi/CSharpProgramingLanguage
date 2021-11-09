namespace WindowsFormsApplication34_busotomation
{
    partial class KayitFormu
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
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbtelefon = new System.Windows.Forms.MaskedTextBox();
            this.rbtnbay = new System.Windows.Forms.RadioButton();
            this.rbtnbayan = new System.Windows.Forms.RadioButton();
            this.btntamam = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // txtisim
            // 
            this.txtisim.BackColor = System.Drawing.SystemColors.Window;
            this.txtisim.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.txtisim.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtisim.Location = new System.Drawing.Point(28, 56);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(276, 33);
            this.txtisim.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.label2.Location = new System.Drawing.Point(23, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "LAST NAME";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.BackColor = System.Drawing.SystemColors.Window;
            this.txtsoyisim.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.txtsoyisim.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtsoyisim.Location = new System.Drawing.Point(28, 133);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(276, 33);
            this.txtsoyisim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.label3.Location = new System.Drawing.Point(24, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "PHONE NUMBER";
            // 
            // mtbtelefon
            // 
            this.mtbtelefon.BackColor = System.Drawing.SystemColors.Window;
            this.mtbtelefon.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.mtbtelefon.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.mtbtelefon.Location = new System.Drawing.Point(29, 214);
            this.mtbtelefon.Mask = "(+99) (999) 000 0000";
            this.mtbtelefon.Name = "mtbtelefon";
            this.mtbtelefon.PromptChar = '-';
            this.mtbtelefon.Size = new System.Drawing.Size(275, 33);
            this.mtbtelefon.TabIndex = 2;
            this.mtbtelefon.Text = "90";
            // 
            // rbtnbay
            // 
            this.rbtnbay.AutoSize = true;
            this.rbtnbay.Checked = true;
            this.rbtnbay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnbay.Font = new System.Drawing.Font("Orator Std", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnbay.Location = new System.Drawing.Point(28, 263);
            this.rbtnbay.Name = "rbtnbay";
            this.rbtnbay.Size = new System.Drawing.Size(74, 36);
            this.rbtnbay.TabIndex = 3;
            this.rbtnbay.TabStop = true;
            this.rbtnbay.Text = "MAN";
            this.rbtnbay.UseVisualStyleBackColor = true;
            // 
            // rbtnbayan
            // 
            this.rbtnbayan.AutoSize = true;
            this.rbtnbayan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnbayan.Font = new System.Drawing.Font("Orator Std", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnbayan.Location = new System.Drawing.Point(187, 263);
            this.rbtnbayan.Name = "rbtnbayan";
            this.rbtnbayan.Size = new System.Drawing.Size(88, 36);
            this.rbtnbayan.TabIndex = 4;
            this.rbtnbayan.Text = "LADY";
            this.rbtnbayan.UseVisualStyleBackColor = true;
            // 
            // btntamam
            // 
            this.btntamam.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btntamam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntamam.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.btntamam.ForeColor = System.Drawing.Color.White;
            this.btntamam.Location = new System.Drawing.Point(172, 313);
            this.btntamam.Name = "btntamam";
            this.btntamam.Size = new System.Drawing.Size(132, 42);
            this.btntamam.TabIndex = 5;
            this.btntamam.Text = "OKAY";
            this.btntamam.UseVisualStyleBackColor = false;
            this.btntamam.Click += new System.EventHandler(this.btntamam_Click);
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btniptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniptal.Font = new System.Drawing.Font("Orator Std", 15.75F);
            this.btniptal.ForeColor = System.Drawing.Color.White;
            this.btniptal.Location = new System.Drawing.Point(28, 313);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(133, 42);
            this.btniptal.TabIndex = 6;
            this.btniptal.Text = "CANCEL";
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // KayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(331, 388);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btntamam);
            this.Controls.Add(this.rbtnbayan);
            this.Controls.Add(this.rbtnbay);
            this.Controls.Add(this.mtbtelefon);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KayitFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntamam;
        private System.Windows.Forms.Button btniptal;
        public System.Windows.Forms.TextBox txtisim;
        public System.Windows.Forms.TextBox txtsoyisim;
        public System.Windows.Forms.MaskedTextBox mtbtelefon;
        public System.Windows.Forms.RadioButton rbtnbay;
        public System.Windows.Forms.RadioButton rbtnbayan;
    }
}