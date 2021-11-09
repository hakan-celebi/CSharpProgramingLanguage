namespace WindowsFormsApplication30_runtimecontrols
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
            this.btnolustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnolustur
            // 
            this.btnolustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnolustur.ForeColor = System.Drawing.Color.Red;
            this.btnolustur.Location = new System.Drawing.Point(250, 160);
            this.btnolustur.Name = "btnolustur";
            this.btnolustur.Size = new System.Drawing.Size(143, 55);
            this.btnolustur.TabIndex = 0;
            this.btnolustur.Text = "BUILD NEW BUTTON";
            this.btnolustur.UseVisualStyleBackColor = true;
            this.btnolustur.Click += new System.EventHandler(this.btnolustur_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnolustur;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(649, 414);
            this.Controls.Add(this.btnolustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnolustur;
    }
}

