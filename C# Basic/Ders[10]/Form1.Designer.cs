
namespace Ders_10_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetDiskInformation = new System.Windows.Forms.Button();
            this.btnGetMicroprocessorInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetDiskInformation
            // 
            this.btnGetDiskInformation.Location = new System.Drawing.Point(12, 12);
            this.btnGetDiskInformation.Name = "btnGetDiskInformation";
            this.btnGetDiskInformation.Size = new System.Drawing.Size(776, 43);
            this.btnGetDiskInformation.TabIndex = 0;
            this.btnGetDiskInformation.Text = "Get Disk Information";
            this.btnGetDiskInformation.UseVisualStyleBackColor = true;
            this.btnGetDiskInformation.Click += new System.EventHandler(this.btnGetDiskInformation_Click);
            // 
            // btnGetMicroprocessorInformation
            // 
            this.btnGetMicroprocessorInformation.Location = new System.Drawing.Point(12, 61);
            this.btnGetMicroprocessorInformation.Name = "btnGetMicroprocessorInformation";
            this.btnGetMicroprocessorInformation.Size = new System.Drawing.Size(776, 43);
            this.btnGetMicroprocessorInformation.TabIndex = 0;
            this.btnGetMicroprocessorInformation.Text = "Get Microprocessor Information";
            this.btnGetMicroprocessorInformation.UseVisualStyleBackColor = true;
            this.btnGetMicroprocessorInformation.Click += new System.EventHandler(this.btnGetMicroprocessorInformation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetMicroprocessorInformation);
            this.Controls.Add(this.btnGetDiskInformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetDiskInformation;
        private System.Windows.Forms.Button btnGetMicroprocessorInformation;
    }
}

