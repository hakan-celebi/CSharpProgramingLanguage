namespace _18__Runtime_Uygulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudkoylu = new System.Windows.Forms.NumericUpDown();
            this.nudvampir = new System.Windows.Forms.NumericUpDown();
            this.nudbuyucu = new System.Windows.Forms.NumericUpDown();
            this.nuddoktor = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnbasla = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudkoylu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudvampir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudbuyucu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuddoktor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(463, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "VAMPİR KİM ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "KAÇ KÖYLÜ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(8, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "KAÇ VAMPİR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(8, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "KAÇ BÜYÜCÜ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(8, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "KAÇ DOKTOR";
            // 
            // nudkoylu
            // 
            this.nudkoylu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.nudkoylu.Location = new System.Drawing.Point(12, 107);
            this.nudkoylu.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudkoylu.Name = "nudkoylu";
            this.nudkoylu.Size = new System.Drawing.Size(99, 30);
            this.nudkoylu.TabIndex = 0;
            this.nudkoylu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudkoylu.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudvampir
            // 
            this.nudvampir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.nudvampir.Location = new System.Drawing.Point(12, 180);
            this.nudvampir.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudvampir.Name = "nudvampir";
            this.nudvampir.Size = new System.Drawing.Size(99, 30);
            this.nudvampir.TabIndex = 1;
            this.nudvampir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudvampir.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudbuyucu
            // 
            this.nudbuyucu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.nudbuyucu.Location = new System.Drawing.Point(12, 250);
            this.nudbuyucu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudbuyucu.Name = "nudbuyucu";
            this.nudbuyucu.Size = new System.Drawing.Size(99, 30);
            this.nudbuyucu.TabIndex = 2;
            this.nudbuyucu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudbuyucu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuddoktor
            // 
            this.nuddoktor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.nuddoktor.Location = new System.Drawing.Point(12, 319);
            this.nuddoktor.Name = "nuddoktor";
            this.nuddoktor.Size = new System.Drawing.Size(99, 30);
            this.nuddoktor.TabIndex = 3;
            this.nuddoktor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(132, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1003, 568);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnbasla
            // 
            this.btnbasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbasla.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbasla.ForeColor = System.Drawing.Color.Red;
            this.btnbasla.Location = new System.Drawing.Point(12, 365);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(110, 73);
            this.btnbasla.TabIndex = 4;
            this.btnbasla.Text = "BAŞLA";
            this.btnbasla.UseVisualStyleBackColor = true;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // btnreset
            // 
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnreset.ForeColor = System.Drawing.Color.Red;
            this.btnreset.Location = new System.Drawing.Point(12, 459);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(110, 73);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnbasla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 632);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnbasla);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.nuddoktor);
            this.Controls.Add(this.nudbuyucu);
            this.Controls.Add(this.nudvampir);
            this.Controls.Add(this.nudkoylu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudkoylu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudvampir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudbuyucu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuddoktor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudkoylu;
        private System.Windows.Forms.NumericUpDown nudvampir;
        private System.Windows.Forms.NumericUpDown nudbuyucu;
        private System.Windows.Forms.NumericUpDown nuddoktor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Button btnreset;
    }
}

