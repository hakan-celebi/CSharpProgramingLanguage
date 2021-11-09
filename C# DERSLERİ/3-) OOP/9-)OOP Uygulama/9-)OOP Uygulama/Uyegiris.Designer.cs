namespace _9__OOP_Uygulama
{
    partial class Uyegiris
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
            this.txtuyekadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuyeprl = new System.Windows.Forms.TextBox();
            this.linklblkayitol = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnuyegyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI: ";
            // 
            // txtuyekadi
            // 
            this.txtuyekadi.Font = new System.Drawing.Font("Impact", 15.75F);
            this.txtuyekadi.Location = new System.Drawing.Point(140, 6);
            this.txtuyekadi.Name = "txtuyekadi";
            this.txtuyekadi.Size = new System.Drawing.Size(224, 33);
            this.txtuyekadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "PAROLA :";
            // 
            // txtuyeprl
            // 
            this.txtuyeprl.Font = new System.Drawing.Font("Impact", 15.75F);
            this.txtuyeprl.Location = new System.Drawing.Point(140, 48);
            this.txtuyeprl.Name = "txtuyeprl";
            this.txtuyeprl.Size = new System.Drawing.Size(224, 33);
            this.txtuyeprl.TabIndex = 1;
            // 
            // linklblkayitol
            // 
            this.linklblkayitol.AutoSize = true;
            this.linklblkayitol.Location = new System.Drawing.Point(263, 84);
            this.linklblkayitol.Name = "linklblkayitol";
            this.linklblkayitol.Size = new System.Drawing.Size(55, 13);
            this.linklblkayitol.TabIndex = 2;
            this.linklblkayitol.TabStop = true;
            this.linklblkayitol.Text = "KAYIT OL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Henüz kayıt olamdınmı ";
            // 
            // btnuyegyap
            // 
            this.btnuyegyap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnuyegyap.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnuyegyap.ForeColor = System.Drawing.Color.Lime;
            this.btnuyegyap.Location = new System.Drawing.Point(370, 6);
            this.btnuyegyap.Name = "btnuyegyap";
            this.btnuyegyap.Size = new System.Drawing.Size(127, 75);
            this.btnuyegyap.TabIndex = 4;
            this.btnuyegyap.Text = "GİRİŞ\r\nYAP";
            this.btnuyegyap.UseVisualStyleBackColor = true;
            // 
            // Uyegiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 107);
            this.Controls.Add(this.btnuyegyap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linklblkayitol);
            this.Controls.Add(this.txtuyeprl);
            this.Controls.Add(this.txtuyekadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Uyegiris";
            this.Text = "Uyegiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuyekadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuyeprl;
        private System.Windows.Forms.LinkLabel linklblkayitol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnuyegyap;
    }
}