
namespace Ders_3_
{
    partial class testForm
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
            this.btnDisposeMainForm = new System.Windows.Forms.Button();
            this.btnGoMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisposeMainForm
            // 
            this.btnDisposeMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisposeMainForm.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDisposeMainForm.Location = new System.Drawing.Point(12, 12);
            this.btnDisposeMainForm.Name = "btnDisposeMainForm";
            this.btnDisposeMainForm.Size = new System.Drawing.Size(104, 58);
            this.btnDisposeMainForm.TabIndex = 0;
            this.btnDisposeMainForm.Text = "Dispose Main Form";
            this.btnDisposeMainForm.UseVisualStyleBackColor = true;
            this.btnDisposeMainForm.Click += new System.EventHandler(this.btnDisposeMainForm_Click);
            // 
            // btnGoMainForm
            // 
            this.btnGoMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoMainForm.ForeColor = System.Drawing.Color.Lime;
            this.btnGoMainForm.Location = new System.Drawing.Point(122, 12);
            this.btnGoMainForm.Name = "btnGoMainForm";
            this.btnGoMainForm.Size = new System.Drawing.Size(104, 58);
            this.btnGoMainForm.TabIndex = 0;
            this.btnGoMainForm.Text = "Go Main Form";
            this.btnGoMainForm.UseVisualStyleBackColor = true;
            this.btnGoMainForm.Click += new System.EventHandler(this.btnGoMainForm_Click);
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoMainForm);
            this.Controls.Add(this.btnDisposeMainForm);
            this.Name = "testForm";
            this.Text = "Test Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisposeMainForm;
        private System.Windows.Forms.Button btnGoMainForm;
    }
}