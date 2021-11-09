
namespace Ders_8_
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
            this.gettingInputWithUserControl1 = new MyUserControl.GettingInputWithUserControl();
            this.SuspendLayout();
            // 
            // gettingInputWithUserControl1
            // 
            this.gettingInputWithUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.gettingInputWithUserControl1.Location = new System.Drawing.Point(222, 77);
            this.gettingInputWithUserControl1.Name = "gettingInputWithUserControl1";
            this.gettingInputWithUserControl1.Size = new System.Drawing.Size(391, 138);
            this.gettingInputWithUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gettingInputWithUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyUserControl.GettingInputWithUserControl gettingInputWithUserControl1;
    }
}

