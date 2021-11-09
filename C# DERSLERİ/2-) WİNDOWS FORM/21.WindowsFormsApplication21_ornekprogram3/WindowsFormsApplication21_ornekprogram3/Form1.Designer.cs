namespace WindowsFormsApplication21_ornekprogram3
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radtoplama = new System.Windows.Forms.RadioButton();
            this.radcikarma = new System.Windows.Forms.RadioButton();
            this.radcarpma = new System.Windows.Forms.RadioButton();
            this.radbolme = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Name = "label2";
            // 
            // txtsayi1
            // 
            resources.ApplyResources(this.txtsayi1, "txtsayi1");
            this.txtsayi1.Name = "txtsayi1";
            // 
            // txtsayi2
            // 
            resources.ApplyResources(this.txtsayi2, "txtsayi2");
            this.txtsayi2.Name = "txtsayi2";
            // 
            // btnhesapla
            // 
            resources.ApplyResources(this.btnhesapla, "btnhesapla");
            this.btnhesapla.ForeColor = System.Drawing.Color.Crimson;
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // txtsonuc
            // 
            this.txtsonuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtsonuc, "txtsonuc");
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Name = "label3";
            // 
            // radtoplama
            // 
            resources.ApplyResources(this.radtoplama, "radtoplama");
            this.radtoplama.ForeColor = System.Drawing.Color.Crimson;
            this.radtoplama.Name = "radtoplama";
            this.radtoplama.TabStop = true;
            this.radtoplama.UseVisualStyleBackColor = true;
            // 
            // radcikarma
            // 
            resources.ApplyResources(this.radcikarma, "radcikarma");
            this.radcikarma.ForeColor = System.Drawing.Color.Crimson;
            this.radcikarma.Name = "radcikarma";
            this.radcikarma.TabStop = true;
            this.radcikarma.UseVisualStyleBackColor = true;
            // 
            // radcarpma
            // 
            resources.ApplyResources(this.radcarpma, "radcarpma");
            this.radcarpma.ForeColor = System.Drawing.Color.Crimson;
            this.radcarpma.Name = "radcarpma";
            this.radcarpma.TabStop = true;
            this.radcarpma.UseVisualStyleBackColor = true;
            // 
            // radbolme
            // 
            resources.ApplyResources(this.radbolme, "radbolme");
            this.radbolme.ForeColor = System.Drawing.Color.Crimson;
            this.radbolme.Name = "radbolme";
            this.radbolme.TabStop = true;
            this.radbolme.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.radbolme);
            this.Controls.Add(this.radcarpma);
            this.Controls.Add(this.radcikarma);
            this.Controls.Add(this.radtoplama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsonuc);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radtoplama;
        private System.Windows.Forms.RadioButton radcikarma;
        private System.Windows.Forms.RadioButton radcarpma;
        private System.Windows.Forms.RadioButton radbolme;
    }
}

