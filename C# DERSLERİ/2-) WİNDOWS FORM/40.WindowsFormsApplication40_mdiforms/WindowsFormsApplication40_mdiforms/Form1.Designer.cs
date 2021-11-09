namespace WindowsFormsApplication40_mdiforms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smipersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.smimüsteri = new System.Windows.Forms.ToolStripMenuItem();
            this.smitedarikci = new System.Windows.Forms.ToolStripMenuItem();
            this.smiyonetim = new System.Windows.Forms.ToolStripMenuItem();
            this.smirapor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smipersonel,
            this.smimüsteri,
            this.smitedarikci,
            this.smiyonetim,
            this.smirapor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1108, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smipersonel
            // 
            this.smipersonel.Font = new System.Drawing.Font("Source Code Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smipersonel.ForeColor = System.Drawing.Color.Cornsilk;
            this.smipersonel.Name = "smipersonel";
            this.smipersonel.Size = new System.Drawing.Size(143, 28);
            this.smipersonel.Text = "PERSONELLER";
            this.smipersonel.Click += new System.EventHandler(this.smipersonel_Click);
            this.smipersonel.MouseLeave += new System.EventHandler(this.smipersonel_MouseLeave);
            this.smipersonel.MouseHover += new System.EventHandler(this.pERSONELLERToolStripMenuItem_MouseHover);
            // 
            // smimüsteri
            // 
            this.smimüsteri.Font = new System.Drawing.Font("Source Code Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.smimüsteri.ForeColor = System.Drawing.Color.Cornsilk;
            this.smimüsteri.Name = "smimüsteri";
            this.smimüsteri.Size = new System.Drawing.Size(132, 28);
            this.smimüsteri.Text = "MÜŞTERİLER";
            this.smimüsteri.Click += new System.EventHandler(this.smimüsteri_Click);
            this.smimüsteri.MouseLeave += new System.EventHandler(this.smimüsteri_MouseLeave);
            this.smimüsteri.MouseHover += new System.EventHandler(this.mÜŞTERİLERToolStripMenuItem_MouseHover);
            // 
            // smitedarikci
            // 
            this.smitedarikci.Font = new System.Drawing.Font("Source Code Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.smitedarikci.ForeColor = System.Drawing.Color.Cornsilk;
            this.smitedarikci.Name = "smitedarikci";
            this.smitedarikci.Size = new System.Drawing.Size(154, 28);
            this.smitedarikci.Text = "TEDARİKÇİLER";
            this.smitedarikci.MouseLeave += new System.EventHandler(this.smitedarikci_MouseLeave);
            this.smitedarikci.MouseHover += new System.EventHandler(this.tEDARİKÇİLERToolStripMenuItem_MouseHover);
            // 
            // smiyonetim
            // 
            this.smiyonetim.Font = new System.Drawing.Font("Source Code Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.smiyonetim.ForeColor = System.Drawing.Color.Cornsilk;
            this.smiyonetim.Name = "smiyonetim";
            this.smiyonetim.Size = new System.Drawing.Size(99, 28);
            this.smiyonetim.Text = "YÖNETİM";
            this.smiyonetim.MouseLeave += new System.EventHandler(this.smiyonetim_MouseLeave);
            this.smiyonetim.MouseHover += new System.EventHandler(this.yÖNETİMToolStripMenuItem_MouseHover);
            // 
            // smirapor
            // 
            this.smirapor.Font = new System.Drawing.Font("Source Code Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.smirapor.ForeColor = System.Drawing.Color.Cornsilk;
            this.smirapor.Name = "smirapor";
            this.smirapor.Size = new System.Drawing.Size(110, 28);
            this.smirapor.Text = "RAPORLAR";
            this.smirapor.MouseLeave += new System.EventHandler(this.smirapor_MouseLeave);
            this.smirapor.MouseHover += new System.EventHandler(this.rAPORLARToolStripMenuItem_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1108, 568);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smipersonel;
        private System.Windows.Forms.ToolStripMenuItem smimüsteri;
        private System.Windows.Forms.ToolStripMenuItem smitedarikci;
        private System.Windows.Forms.ToolStripMenuItem smiyonetim;
        private System.Windows.Forms.ToolStripMenuItem smirapor;
    }
}

