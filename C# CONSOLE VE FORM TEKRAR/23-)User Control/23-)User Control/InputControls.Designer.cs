namespace _23__User_Control
{
    partial class InputControls
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcontrol = new System.Windows.Forms.Label();
            this.txtcontrol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblcontrol
            // 
            this.lblcontrol.AutoSize = true;
            this.lblcontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcontrol.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcontrol.Location = new System.Drawing.Point(3, 15);
            this.lblcontrol.Name = "lblcontrol";
            this.lblcontrol.Size = new System.Drawing.Size(88, 23);
            this.lblcontrol.TabIndex = 0;
            this.lblcontrol.Text = "label1";
            // 
            // txtcontrol
            // 
            this.txtcontrol.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcontrol.Location = new System.Drawing.Point(120, 12);
            this.txtcontrol.Name = "txtcontrol";
            this.txtcontrol.Size = new System.Drawing.Size(229, 31);
            this.txtcontrol.TabIndex = 1;
            // 
            // InputControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtcontrol);
            this.Controls.Add(this.lblcontrol);
            this.Name = "InputControls";
            this.Size = new System.Drawing.Size(352, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblcontrol;
        public System.Windows.Forms.TextBox txtcontrol;
    }
}
