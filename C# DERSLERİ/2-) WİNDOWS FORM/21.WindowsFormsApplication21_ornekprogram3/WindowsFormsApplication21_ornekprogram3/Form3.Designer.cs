namespace WindowsFormsApplication21_ornekprogram3
{
    partial class Form3
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
            this.lstzayif = new System.Windows.Forms.ListBox();
            this.lstorta = new System.Windows.Forms.ListBox();
            this.lstkilolu = new System.Windows.Forms.ListBox();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtkilo = new System.Windows.Forms.TextBox();
            this.btngonder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Museo 900", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(115, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD SOYAD : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Museo 900", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(184, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "KİLO : ";
            // 
            // lstzayif
            // 
            this.lstzayif.Font = new System.Drawing.Font("Microsoft MHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstzayif.ForeColor = System.Drawing.Color.Crimson;
            this.lstzayif.FormattingEnabled = true;
            this.lstzayif.ItemHeight = 28;
            this.lstzayif.Location = new System.Drawing.Point(12, 252);
            this.lstzayif.Name = "lstzayif";
            this.lstzayif.Size = new System.Drawing.Size(187, 200);
            this.lstzayif.TabIndex = 2;
            // 
            // lstorta
            // 
            this.lstorta.Font = new System.Drawing.Font("Microsoft MHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.lstorta.ForeColor = System.Drawing.Color.Crimson;
            this.lstorta.FormattingEnabled = true;
            this.lstorta.ItemHeight = 28;
            this.lstorta.Location = new System.Drawing.Point(230, 252);
            this.lstorta.Name = "lstorta";
            this.lstorta.Size = new System.Drawing.Size(187, 200);
            this.lstorta.TabIndex = 3;
            // 
            // lstkilolu
            // 
            this.lstkilolu.Font = new System.Drawing.Font("Microsoft MHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.lstkilolu.ForeColor = System.Drawing.Color.Crimson;
            this.lstkilolu.FormattingEnabled = true;
            this.lstkilolu.ItemHeight = 28;
            this.lstkilolu.Location = new System.Drawing.Point(446, 252);
            this.lstkilolu.Name = "lstkilolu";
            this.lstkilolu.Size = new System.Drawing.Size(187, 200);
            this.lstkilolu.TabIndex = 4;
            // 
            // txtisim
            // 
            this.txtisim.Font = new System.Drawing.Font("Museo 900", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtisim.Location = new System.Drawing.Point(273, 32);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(210, 40);
            this.txtisim.TabIndex = 0;
            // 
            // txtkilo
            // 
            this.txtkilo.Font = new System.Drawing.Font("Museo 900", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtkilo.Location = new System.Drawing.Point(273, 73);
            this.txtkilo.Name = "txtkilo";
            this.txtkilo.Size = new System.Drawing.Size(210, 40);
            this.txtkilo.TabIndex = 1;
            // 
            // btngonder
            // 
            this.btngonder.Font = new System.Drawing.Font("Myanmar MN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngonder.Location = new System.Drawing.Point(367, 132);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(116, 44);
            this.btngonder.TabIndex = 2;
            this.btngonder.Text = "GÖNDER";
            this.btngonder.UseVisualStyleBackColor = true;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(24, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "ZAYIF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(267, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "ORTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(456, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "KİLOLU";
            // 
            // Form3
            // 
            this.AcceptButton = this.btngonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(645, 460);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.txtkilo);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.lstkilolu);
            this.Controls.Add(this.lstorta);
            this.Controls.Add(this.lstzayif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstzayif;
        private System.Windows.Forms.ListBox lstorta;
        private System.Windows.Forms.ListBox lstkilolu;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtkilo;
        private System.Windows.Forms.Button btngonder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}