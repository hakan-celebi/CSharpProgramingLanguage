namespace WindowsFormsApplication37_backgroundworker
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnbaslat1 = new System.Windows.Forms.Button();
            this.btnbaslat2 = new System.Windows.Forms.Button();
            this.btndurdur1 = new System.Windows.Forms.Button();
            this.btndurdur2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // btnbaslat1
            // 
            this.btnbaslat1.Location = new System.Drawing.Point(36, 91);
            this.btnbaslat1.Name = "btnbaslat1";
            this.btnbaslat1.Size = new System.Drawing.Size(75, 23);
            this.btnbaslat1.TabIndex = 1;
            this.btnbaslat1.Text = "BAŞLAT";
            this.btnbaslat1.UseVisualStyleBackColor = true;
            this.btnbaslat1.Click += new System.EventHandler(this.btnbaslat1_Click);
            // 
            // btnbaslat2
            // 
            this.btnbaslat2.Location = new System.Drawing.Point(152, 91);
            this.btnbaslat2.Name = "btnbaslat2";
            this.btnbaslat2.Size = new System.Drawing.Size(75, 23);
            this.btnbaslat2.TabIndex = 1;
            this.btnbaslat2.Text = "BAŞLAT";
            this.btnbaslat2.UseVisualStyleBackColor = true;
            this.btnbaslat2.Click += new System.EventHandler(this.btnbaslat2_Click);
            // 
            // btndurdur1
            // 
            this.btndurdur1.Location = new System.Drawing.Point(36, 120);
            this.btndurdur1.Name = "btndurdur1";
            this.btndurdur1.Size = new System.Drawing.Size(75, 23);
            this.btndurdur1.TabIndex = 1;
            this.btndurdur1.Text = "DURDUR";
            this.btndurdur1.UseVisualStyleBackColor = true;
            this.btndurdur1.Click += new System.EventHandler(this.btndurdur1_Click);
            // 
            // btndurdur2
            // 
            this.btndurdur2.Location = new System.Drawing.Point(152, 120);
            this.btndurdur2.Name = "btndurdur2";
            this.btndurdur2.Size = new System.Drawing.Size(75, 23);
            this.btndurdur2.TabIndex = 1;
            this.btndurdur2.Text = "DURDUR";
            this.btndurdur2.UseVisualStyleBackColor = true;
            this.btndurdur2.Click += new System.EventHandler(this.btndurdur2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 226);
            this.Controls.Add(this.btndurdur2);
            this.Controls.Add(this.btndurdur1);
            this.Controls.Add(this.btnbaslat2);
            this.Controls.Add(this.btnbaslat1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbaslat1;
        private System.Windows.Forms.Button btnbaslat2;
        private System.Windows.Forms.Button btndurdur1;
        private System.Windows.Forms.Button btndurdur2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

