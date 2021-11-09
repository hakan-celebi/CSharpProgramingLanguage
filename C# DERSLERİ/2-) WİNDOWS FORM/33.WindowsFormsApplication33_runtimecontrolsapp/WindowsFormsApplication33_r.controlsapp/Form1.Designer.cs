namespace WindowsFormsApplication33_r.controlsapp
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudadet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbtip = new System.Windows.Forms.ComboBox();
            this.btnolustur = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudadet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADET";
            // 
            // nudadet
            // 
            this.nudadet.Font = new System.Drawing.Font("Myriad Pro Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.nudadet.Location = new System.Drawing.Point(34, 57);
            this.nudadet.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudadet.Name = "nudadet";
            this.nudadet.Size = new System.Drawing.Size(165, 33);
            this.nudadet.TabIndex = 1;
            this.nudadet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(217, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "TİP";
            // 
            // cmbtip
            // 
            this.cmbtip.Font = new System.Drawing.Font("Myriad Pro Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbtip.FormattingEnabled = true;
            this.cmbtip.Items.AddRange(new object[] {
            "Button",
            "TextBox",
            "ComboBox",
            "PictureBox",
            "ListBox"});
            this.cmbtip.Location = new System.Drawing.Point(205, 57);
            this.cmbtip.Name = "cmbtip";
            this.cmbtip.Size = new System.Drawing.Size(230, 34);
            this.cmbtip.TabIndex = 3;
            // 
            // btnolustur
            // 
            this.btnolustur.Font = new System.Drawing.Font("Myriad Pro Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnolustur.Location = new System.Drawing.Point(441, 57);
            this.btnolustur.Name = "btnolustur";
            this.btnolustur.Size = new System.Drawing.Size(118, 34);
            this.btnolustur.TabIndex = 4;
            this.btnolustur.Text = "OLUŞTUR";
            this.btnolustur.UseVisualStyleBackColor = true;
            this.btnolustur.Click += new System.EventHandler(this.btnolustur_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(525, 420);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 543);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnolustur);
            this.Controls.Add(this.cmbtip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudadet);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "OLUŞTURMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudadet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudadet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbtip;
        private System.Windows.Forms.Button btnolustur;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

