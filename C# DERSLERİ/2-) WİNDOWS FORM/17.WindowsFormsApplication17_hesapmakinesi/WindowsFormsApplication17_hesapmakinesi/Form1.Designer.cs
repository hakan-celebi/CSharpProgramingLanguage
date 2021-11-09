namespace WindowsFormsApplication17_hesapmakinesi
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
            this.btnTkla = new System.Windows.Forms.Button();
            this.sayi1 = new System.Windows.Forms.Label();
            this.sayi2 = new System.Windows.Forms.Label();
            this.textsayi1 = new System.Windows.Forms.TextBox();
            this.textsayi2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTkla
            // 
            this.btnTkla.Location = new System.Drawing.Point(84, 229);
            this.btnTkla.Name = "btnTkla";
            this.btnTkla.Size = new System.Drawing.Size(119, 39);
            this.btnTkla.TabIndex = 2;
            this.btnTkla.Text = "HESAPLA";
            this.btnTkla.UseVisualStyleBackColor = true;
            this.btnTkla.Click += new System.EventHandler(this.btnTkla_Click);
            // 
            // sayi1
            // 
            this.sayi1.AutoSize = true;
            this.sayi1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayi1.Location = new System.Drawing.Point(57, 36);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(80, 18);
            this.sayi1.TabIndex = 1;
            this.sayi1.Text = "1.SAYI : ";
            // 
            // sayi2
            // 
            this.sayi2.AutoSize = true;
            this.sayi2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayi2.Location = new System.Drawing.Point(57, 76);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(80, 18);
            this.sayi2.TabIndex = 2;
            this.sayi2.Text = "2.SAYI : ";
            // 
            // textsayi1
            // 
            this.textsayi1.Location = new System.Drawing.Point(127, 36);
            this.textsayi1.Name = "textsayi1";
            this.textsayi1.Size = new System.Drawing.Size(100, 20);
            this.textsayi1.TabIndex = 0;
            this.textsayi1.Text = "Sayı Giriniz...";
            this.textsayi1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textsayi1_MouseClick);
            // 
            // textsayi2
            // 
            this.textsayi2.Location = new System.Drawing.Point(127, 76);
            this.textsayi2.Name = "textsayi2";
            this.textsayi2.Size = new System.Drawing.Size(100, 20);
            this.textsayi2.TabIndex = 1;
            this.textsayi2.Text = "Sayı Giriniz...";
            this.textsayi2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textsayi2_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(60, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "SONUÇ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTkla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(274, 332);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textsayi2);
            this.Controls.Add(this.textsayi1);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sayi1);
            this.Controls.Add(this.btnTkla);
            this.Name = "Form1";
            this.Text = "   ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTkla;
        private System.Windows.Forms.Label sayi1;
        private System.Windows.Forms.Label sayi2;
        private System.Windows.Forms.TextBox textsayi1;
        private System.Windows.Forms.TextBox textsayi2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

