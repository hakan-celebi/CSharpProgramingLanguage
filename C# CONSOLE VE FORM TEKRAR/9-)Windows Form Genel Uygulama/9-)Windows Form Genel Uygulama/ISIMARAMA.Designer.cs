namespace _9__Windows_Form_Genel_Uygulama
{
    partial class ISIMARAMA
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtekle = new System.Windows.Forms.TextBox();
            this.txtara = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.lbcalisan = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAMBLY COMPANY ÇALIŞAN LİSTESİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "İSİM EKLE: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(444, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "İSİM ARA: ";
            // 
            // txtekle
            // 
            this.txtekle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtekle.Location = new System.Drawing.Point(101, 61);
            this.txtekle.Name = "txtekle";
            this.txtekle.Size = new System.Drawing.Size(208, 33);
            this.txtekle.TabIndex = 0;
            // 
            // txtara
            // 
            this.txtara.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtara.Location = new System.Drawing.Point(539, 61);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(208, 33);
            this.txtara.TabIndex = 2;
            this.txtara.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtara_KeyUp);
            // 
            // btnekle
            // 
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.Tomato;
            this.btnekle.Location = new System.Drawing.Point(315, 61);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(85, 33);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.Tomato;
            this.btnsil.Location = new System.Drawing.Point(315, 100);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(85, 33);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // lbcalisan
            // 
            this.lbcalisan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbcalisan.FormattingEnabled = true;
            this.lbcalisan.ItemHeight = 25;
            this.lbcalisan.Location = new System.Drawing.Point(7, 150);
            this.lbcalisan.Name = "lbcalisan";
            this.lbcalisan.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbcalisan.Size = new System.Drawing.Size(762, 354);
            this.lbcalisan.TabIndex = 4;
            // 
            // ISIMARAMA
            // 
            this.AcceptButton = this.btnekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 518);
            this.Controls.Add(this.lbcalisan);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.txtekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ISIMARAMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISIMARAMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtekle;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.ListBox lbcalisan;
    }
}