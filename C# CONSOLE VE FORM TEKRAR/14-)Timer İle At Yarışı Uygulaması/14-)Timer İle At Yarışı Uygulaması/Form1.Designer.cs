namespace _14__Timer_İle_At_Yarışı_Uygulaması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HAKAN = new System.Windows.Forms.PictureBox();
            this.APO = new System.Windows.Forms.PictureBox();
            this.EMRE = new System.Windows.Forms.PictureBox();
            this.BATUS = new System.Windows.Forms.PictureBox();
            this.btnbasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HAKAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMRE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BATUS)).BeginInit();
            this.SuspendLayout();
            // 
            // HAKAN
            // 
            this.HAKAN.BackColor = System.Drawing.Color.Transparent;
            this.HAKAN.Image = ((System.Drawing.Image)(resources.GetObject("HAKAN.Image")));
            this.HAKAN.Location = new System.Drawing.Point(12, 12);
            this.HAKAN.Name = "HAKAN";
            this.HAKAN.Size = new System.Drawing.Size(188, 116);
            this.HAKAN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HAKAN.TabIndex = 0;
            this.HAKAN.TabStop = false;
            // 
            // APO
            // 
            this.APO.BackColor = System.Drawing.Color.Transparent;
            this.APO.Image = ((System.Drawing.Image)(resources.GetObject("APO.Image")));
            this.APO.Location = new System.Drawing.Point(12, 134);
            this.APO.Name = "APO";
            this.APO.Size = new System.Drawing.Size(188, 116);
            this.APO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.APO.TabIndex = 0;
            this.APO.TabStop = false;
            // 
            // EMRE
            // 
            this.EMRE.BackColor = System.Drawing.Color.Transparent;
            this.EMRE.Image = ((System.Drawing.Image)(resources.GetObject("EMRE.Image")));
            this.EMRE.Location = new System.Drawing.Point(12, 256);
            this.EMRE.Name = "EMRE";
            this.EMRE.Size = new System.Drawing.Size(188, 116);
            this.EMRE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EMRE.TabIndex = 0;
            this.EMRE.TabStop = false;
            // 
            // BATUS
            // 
            this.BATUS.BackColor = System.Drawing.Color.Transparent;
            this.BATUS.Image = ((System.Drawing.Image)(resources.GetObject("BATUS.Image")));
            this.BATUS.Location = new System.Drawing.Point(12, 378);
            this.BATUS.Name = "BATUS";
            this.BATUS.Size = new System.Drawing.Size(188, 116);
            this.BATUS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BATUS.TabIndex = 0;
            this.BATUS.TabStop = false;
            // 
            // btnbasla
            // 
            this.btnbasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbasla.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbasla.ForeColor = System.Drawing.Color.Aqua;
            this.btnbasla.Location = new System.Drawing.Point(12, 500);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(188, 49);
            this.btnbasla.TabIndex = 1;
            this.btnbasla.Text = "BAŞLA";
            this.btnbasla.UseVisualStyleBackColor = true;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1263, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 536);
            this.label1.TabIndex = 2;
            this.label1.Text = "\r\nF\r\nI\r\nN\r\nI\r\nS\r\nH\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1313, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbasla);
            this.Controls.Add(this.BATUS);
            this.Controls.Add(this.EMRE);
            this.Controls.Add(this.APO);
            this.Controls.Add(this.HAKAN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HAKAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMRE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BATUS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HAKAN;
        private System.Windows.Forms.PictureBox APO;
        private System.Windows.Forms.PictureBox EMRE;
        private System.Windows.Forms.PictureBox BATUS;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

