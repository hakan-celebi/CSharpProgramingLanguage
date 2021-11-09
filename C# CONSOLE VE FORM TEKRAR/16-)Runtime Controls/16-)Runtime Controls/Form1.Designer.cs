namespace _16__Runtime_Controls
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cms1on = new System.Windows.Forms.ToolStripMenuItem();
            this.cms120 = new System.Windows.Forms.ToolStripMenuItem();
            this.cms130 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cms210 = new System.Windows.Forms.ToolStripMenuItem();
            this.csm220 = new System.Windows.Forms.ToolStripMenuItem();
            this.csm230 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms1on});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "10";
            // 
            // cms1on
            // 
            this.cms1on.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms120});
            this.cms1on.Name = "cms1on";
            this.cms1on.Size = new System.Drawing.Size(180, 22);
            this.cms1on.Text = "*10";
            this.cms1on.Click += new System.EventHandler(this.cms1on_Click);
            // 
            // cms120
            // 
            this.cms120.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms130});
            this.cms120.Name = "cms120";
            this.cms120.Size = new System.Drawing.Size(180, 22);
            this.cms120.Text = "*20";
            this.cms120.Click += new System.EventHandler(this.cms120_Click);
            // 
            // cms130
            // 
            this.cms130.Name = "cms130";
            this.cms130.Size = new System.Drawing.Size(180, 22);
            this.cms130.Text = "*30";
            this.cms130.Click += new System.EventHandler(this.cms130_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms210});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "20";
            // 
            // cms210
            // 
            this.cms210.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csm220});
            this.cms210.Name = "cms210";
            this.cms210.Size = new System.Drawing.Size(180, 22);
            this.cms210.Text = "*10";
            this.cms210.Click += new System.EventHandler(this.cms210_Click);
            // 
            // csm220
            // 
            this.csm220.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csm230});
            this.csm220.Name = "csm220";
            this.csm220.Size = new System.Drawing.Size(180, 22);
            this.csm220.Text = "*20";
            this.csm220.Click += new System.EventHandler(this.csm220_Click);
            // 
            // csm230
            // 
            this.csm230.Name = "csm230";
            this.csm230.Size = new System.Drawing.Size(180, 22);
            this.csm230.Text = "*30";
            this.csm230.Click += new System.EventHandler(this.csm230_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cms1on;
        private System.Windows.Forms.ToolStripMenuItem cms120;
        private System.Windows.Forms.ToolStripMenuItem cms130;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cms210;
        private System.Windows.Forms.ToolStripMenuItem csm220;
        private System.Windows.Forms.ToolStripMenuItem csm230;
    }
}

