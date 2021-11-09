namespace _9__OOP_Uygulama
{
    partial class Admingiris
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
            this.txtadminkadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadminprl = new System.Windows.Forms.TextBox();
            this.btnadmingyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI: ";
            // 
            // txtadminkadi
            // 
            this.txtadminkadi.Font = new System.Drawing.Font("Impact", 15.75F);
            this.txtadminkadi.Location = new System.Drawing.Point(138, 6);
            this.txtadminkadi.Name = "txtadminkadi";
            this.txtadminkadi.Size = new System.Drawing.Size(225, 33);
            this.txtadminkadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "PAROLA : ";
            // 
            // txtadminprl
            // 
            this.txtadminprl.Font = new System.Drawing.Font("Impact", 15.75F);
            this.txtadminprl.Location = new System.Drawing.Point(138, 46);
            this.txtadminprl.Name = "txtadminprl";
            this.txtadminprl.Size = new System.Drawing.Size(225, 33);
            this.txtadminprl.TabIndex = 1;
            // 
            // btnadmingyap
            // 
            this.btnadmingyap.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnadmingyap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadmingyap.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnadmingyap.ForeColor = System.Drawing.Color.Lime;
            this.btnadmingyap.Location = new System.Drawing.Point(369, 6);
            this.btnadmingyap.Name = "btnadmingyap";
            this.btnadmingyap.Size = new System.Drawing.Size(118, 73);
            this.btnadmingyap.TabIndex = 2;
            this.btnadmingyap.Text = "GİRİŞ\r\nYAP\r\n";
            this.btnadmingyap.UseVisualStyleBackColor = true;
            this.btnadmingyap.Click += new System.EventHandler(this.btnadmingyap_Click);
            // 
            // Admingiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 91);
            this.Controls.Add(this.btnadmingyap);
            this.Controls.Add(this.txtadminprl);
            this.Controls.Add(this.txtadminkadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admingiris";
            this.Text = "Admingiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtadminkadi;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtadminprl;
        internal System.Windows.Forms.Button btnadmingyap;
    }
}