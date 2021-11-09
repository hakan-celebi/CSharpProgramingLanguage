
namespace Ders_5_
{
    partial class RegularExpression
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
            this.lblIsMatchMethod = new System.Windows.Forms.Label();
            this.txtExampleForIsMatchMethod = new System.Windows.Forms.TextBox();
            this.btnCheckItIsMatchMethod = new System.Windows.Forms.Button();
            this.lblHeaderOfMatchesExample = new System.Windows.Forms.Label();
            this.lblWebAddress = new System.Windows.Forms.Label();
            this.txtWebAddress = new System.Windows.Forms.TextBox();
            this.listBoxReturnValueOfMatchesMethod = new System.Windows.Forms.ListBox();
            this.btnListMatchesMethodResults = new System.Windows.Forms.Button();
            this.lblProcessState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIsMatchMethod
            // 
            this.lblIsMatchMethod.AutoSize = true;
            this.lblIsMatchMethod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIsMatchMethod.Location = new System.Drawing.Point(116, 9);
            this.lblIsMatchMethod.Name = "lblIsMatchMethod";
            this.lblIsMatchMethod.Size = new System.Drawing.Size(565, 22);
            this.lblIsMatchMethod.TabIndex = 0;
            this.lblIsMatchMethod.Text = "IsMatch Methodu İle TextBox\'ın Boş Olup Olmadığını Kontrol Edelim";
            // 
            // txtExampleForIsMatchMethod
            // 
            this.txtExampleForIsMatchMethod.Location = new System.Drawing.Point(10, 43);
            this.txtExampleForIsMatchMethod.Name = "txtExampleForIsMatchMethod";
            this.txtExampleForIsMatchMethod.Size = new System.Drawing.Size(776, 27);
            this.txtExampleForIsMatchMethod.TabIndex = 1;
            // 
            // btnCheckItIsMatchMethod
            // 
            this.btnCheckItIsMatchMethod.BackColor = System.Drawing.Color.White;
            this.btnCheckItIsMatchMethod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckItIsMatchMethod.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCheckItIsMatchMethod.Location = new System.Drawing.Point(255, 76);
            this.btnCheckItIsMatchMethod.Name = "btnCheckItIsMatchMethod";
            this.btnCheckItIsMatchMethod.Size = new System.Drawing.Size(287, 37);
            this.btnCheckItIsMatchMethod.TabIndex = 2;
            this.btnCheckItIsMatchMethod.Text = "Kontrol Et";
            this.btnCheckItIsMatchMethod.UseVisualStyleBackColor = false;
            this.btnCheckItIsMatchMethod.Click += new System.EventHandler(this.btnCheckItIsMatchMethod_Click);
            // 
            // lblHeaderOfMatchesExample
            // 
            this.lblHeaderOfMatchesExample.AutoSize = true;
            this.lblHeaderOfMatchesExample.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderOfMatchesExample.Location = new System.Drawing.Point(67, 125);
            this.lblHeaderOfMatchesExample.Name = "lblHeaderOfMatchesExample";
            this.lblHeaderOfMatchesExample.Size = new System.Drawing.Size(662, 22);
            this.lblHeaderOfMatchesExample.TabIndex = 0;
            this.lblHeaderOfMatchesExample.Text = "Matches Methodu ile Girilen Bir Web Sitesindeki E-Mail Adreslerini Listeleyelim";
            // 
            // lblWebAddress
            // 
            this.lblWebAddress.AutoSize = true;
            this.lblWebAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWebAddress.Location = new System.Drawing.Point(8, 157);
            this.lblWebAddress.Name = "lblWebAddress";
            this.lblWebAddress.Size = new System.Drawing.Size(126, 22);
            this.lblWebAddress.TabIndex = 0;
            this.lblWebAddress.Text = "Web Address: ";
            // 
            // txtWebAddress
            // 
            this.txtWebAddress.Location = new System.Drawing.Point(144, 155);
            this.txtWebAddress.Name = "txtWebAddress";
            this.txtWebAddress.Size = new System.Drawing.Size(644, 27);
            this.txtWebAddress.TabIndex = 1;
            // 
            // listBoxReturnValueOfMatchesMethod
            // 
            this.listBoxReturnValueOfMatchesMethod.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxReturnValueOfMatchesMethod.FormattingEnabled = true;
            this.listBoxReturnValueOfMatchesMethod.ItemHeight = 19;
            this.listBoxReturnValueOfMatchesMethod.Location = new System.Drawing.Point(8, 188);
            this.listBoxReturnValueOfMatchesMethod.Name = "listBoxReturnValueOfMatchesMethod";
            this.listBoxReturnValueOfMatchesMethod.Size = new System.Drawing.Size(780, 194);
            this.listBoxReturnValueOfMatchesMethod.TabIndex = 3;
            // 
            // btnListMatchesMethodResults
            // 
            this.btnListMatchesMethodResults.BackColor = System.Drawing.Color.White;
            this.btnListMatchesMethodResults.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListMatchesMethodResults.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnListMatchesMethodResults.Location = new System.Drawing.Point(501, 388);
            this.btnListMatchesMethodResults.Name = "btnListMatchesMethodResults";
            this.btnListMatchesMethodResults.Size = new System.Drawing.Size(287, 37);
            this.btnListMatchesMethodResults.TabIndex = 2;
            this.btnListMatchesMethodResults.Text = "Listele";
            this.btnListMatchesMethodResults.UseVisualStyleBackColor = false;
            this.btnListMatchesMethodResults.Click += new System.EventHandler(this.btnListMatchesMethodResults_Click);
            // 
            // lblProcessState
            // 
            this.lblProcessState.AutoSize = true;
            this.lblProcessState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProcessState.Location = new System.Drawing.Point(12, 395);
            this.lblProcessState.Name = "lblProcessState";
            this.lblProcessState.Size = new System.Drawing.Size(127, 22);
            this.lblProcessState.TabIndex = 0;
            this.lblProcessState.Text = "Process State: ";
            // 
            // RegularExpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.listBoxReturnValueOfMatchesMethod);
            this.Controls.Add(this.btnListMatchesMethodResults);
            this.Controls.Add(this.btnCheckItIsMatchMethod);
            this.Controls.Add(this.txtWebAddress);
            this.Controls.Add(this.txtExampleForIsMatchMethod);
            this.Controls.Add(this.lblProcessState);
            this.Controls.Add(this.lblWebAddress);
            this.Controls.Add(this.lblHeaderOfMatchesExample);
            this.Controls.Add(this.lblIsMatchMethod);
            this.Name = "RegularExpression";
            this.Text = "Regular Expression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIsMatchMethod;
        private System.Windows.Forms.TextBox txtExampleForIsMatchMethod;
        private System.Windows.Forms.Button btnCheckItIsMatchMethod;
        private System.Windows.Forms.Label lblHeaderOfMatchesExample;
        private System.Windows.Forms.Label lblWebAddress;
        private System.Windows.Forms.TextBox txtWebAddress;
        private System.Windows.Forms.ListBox listBoxReturnValueOfMatchesMethod;
        private System.Windows.Forms.Button btnListMatchesMethodResults;
        private System.Windows.Forms.Label lblProcessState;
    }
}

