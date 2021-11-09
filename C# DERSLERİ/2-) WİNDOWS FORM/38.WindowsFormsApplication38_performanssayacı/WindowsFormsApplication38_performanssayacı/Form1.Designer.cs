namespace WindowsFormsApplication38_performanssayacı
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
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
            this.label1 = new System.Windows.Forms.Label();
            this.prbislemci = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.prbram = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).BeginInit();
            this.SuspendLayout();
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "İşlemci";
            this.performanceCounter1.CounterName = "% Boşta Zaman";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // performanceCounter2
            // 
            this.performanceCounter2.CategoryName = "Bellek";
            this.performanceCounter2.CounterName = "Kullanılan Kaydedilmiş Bayt Yüzdesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Onyx", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU";
            // 
            // prbislemci
            // 
            this.prbislemci.BackColor = System.Drawing.Color.Coral;
            this.prbislemci.ForeColor = System.Drawing.Color.IndianRed;
            this.prbislemci.Location = new System.Drawing.Point(12, 50);
            this.prbislemci.Name = "prbislemci";
            this.prbislemci.Size = new System.Drawing.Size(637, 50);
            this.prbislemci.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbislemci.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Onyx", 26.25F);
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "RAM";
            // 
            // prbram
            // 
            this.prbram.BackColor = System.Drawing.Color.Coral;
            this.prbram.Location = new System.Drawing.Point(12, 139);
            this.prbram.Name = "prbram";
            this.prbram.Size = new System.Drawing.Size(637, 50);
            this.prbram.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbram.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(685, 237);
            this.Controls.Add(this.prbram);
            this.Controls.Add(this.prbislemci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Diagnostics.PerformanceCounter performanceCounter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prbislemci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar prbram;
        private System.Windows.Forms.Timer timer1;
    }
}

