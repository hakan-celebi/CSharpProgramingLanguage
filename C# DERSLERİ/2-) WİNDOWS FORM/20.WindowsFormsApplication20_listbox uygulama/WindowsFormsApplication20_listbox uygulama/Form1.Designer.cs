namespace WindowsFormsApplication20_listbox_uygulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtgir = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaristir = new System.Windows.Forms.Button();
            this.lstyer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1118, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Windows Form Genel Uygulama";
            // 
            // txtgir
            // 
            this.txtgir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgir.Location = new System.Drawing.Point(379, 89);
            this.txtgir.Name = "txtgir";
            this.txtgir.Size = new System.Drawing.Size(409, 44);
            this.txtgir.TabIndex = 0;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.LightGray;
            this.btnekle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnekle.Location = new System.Drawing.Point(379, 139);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(123, 58);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.LightGray;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.Location = new System.Drawing.Point(508, 139);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(123, 58);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaristir
            // 
            this.btnkaristir.BackColor = System.Drawing.Color.LightGray;
            this.btnkaristir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaristir.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaristir.Location = new System.Drawing.Point(637, 139);
            this.btnkaristir.Name = "btnkaristir";
            this.btnkaristir.Size = new System.Drawing.Size(151, 58);
            this.btnkaristir.TabIndex = 3;
            this.btnkaristir.Text = "KARIŞTIR";
            this.btnkaristir.UseVisualStyleBackColor = false;
            this.btnkaristir.Click += new System.EventHandler(this.btnkaristir_Click);
            // 
            // lstyer
            // 
            this.lstyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstyer.ForeColor = System.Drawing.Color.Crimson;
            this.lstyer.FormattingEnabled = true;
            this.lstyer.ItemHeight = 55;
            this.lstyer.Location = new System.Drawing.Point(12, 203);
            this.lstyer.Name = "lstyer";
            this.lstyer.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstyer.Size = new System.Drawing.Size(1148, 389);
            this.lstyer.TabIndex = 5;
            this.lstyer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstyer_KeyDown);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 651);
            this.Controls.Add(this.lstyer);
            this.Controls.Add(this.btnkaristir);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtgir);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WİNDOWS FORM EKLEME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgir;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaristir;
        private System.Windows.Forms.ListBox lstyer;
    }
}

