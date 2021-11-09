namespace Ders_3_
{
    partial class mainForm
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
            this.btnGoOtherForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoOtherForm
            // 
            this.btnGoOtherForm.BackColor = System.Drawing.Color.Black;
            this.btnGoOtherForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoOtherForm.ForeColor = System.Drawing.Color.White;
            this.btnGoOtherForm.Location = new System.Drawing.Point(266, 171);
            this.btnGoOtherForm.Name = "btnGoOtherForm";
            this.btnGoOtherForm.Size = new System.Drawing.Size(184, 62);
            this.btnGoOtherForm.TabIndex = 0;
            this.btnGoOtherForm.Text = "Go Other Form";
            this.btnGoOtherForm.UseVisualStyleBackColor = false;
            this.btnGoOtherForm.Click += new System.EventHandler(this.btnGoOtherForm_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 404);
            this.Controls.Add(this.btnGoOtherForm);
            this.Name = "mainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoOtherForm;
    }
}

