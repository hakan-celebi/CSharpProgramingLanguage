namespace WindowsFormsApplication28_timer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblgerisayim = new System.Windows.Forms.Label();
            this.lblkronometre = new System.Windows.Forms.Label();
            this.btnkstart = new System.Windows.Forms.Button();
            this.btnkpause = new System.Windows.Forms.Button();
            this.btnkrestart = new System.Windows.Forms.Button();
            this.btngstart = new System.Windows.Forms.Button();
            this.btngpause = new System.Windows.Forms.Button();
            this.btngrestart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtgeridakika = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtgerisaniye = new System.Windows.Forms.TextBox();
            this.txtgerisalise = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "KRONOMETRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "GERİ SAYIM";
            // 
            // lblgerisayim
            // 
            this.lblgerisayim.AutoSize = true;
            this.lblgerisayim.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F);
            this.lblgerisayim.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblgerisayim.Location = new System.Drawing.Point(602, 133);
            this.lblgerisayim.Name = "lblgerisayim";
            this.lblgerisayim.Size = new System.Drawing.Size(139, 30);
            this.lblgerisayim.TabIndex = 1;
            this.lblgerisayim.Text = "00:00:00";
            // 
            // lblkronometre
            // 
            this.lblkronometre.AutoSize = true;
            this.lblkronometre.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkronometre.ForeColor = System.Drawing.Color.Coral;
            this.lblkronometre.Location = new System.Drawing.Point(146, 136);
            this.lblkronometre.Name = "lblkronometre";
            this.lblkronometre.Size = new System.Drawing.Size(139, 30);
            this.lblkronometre.TabIndex = 1;
            this.lblkronometre.Text = "00:00:00";
            // 
            // btnkstart
            // 
            this.btnkstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkstart.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkstart.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnkstart.Location = new System.Drawing.Point(12, 226);
            this.btnkstart.Name = "btnkstart";
            this.btnkstart.Size = new System.Drawing.Size(133, 49);
            this.btnkstart.TabIndex = 2;
            this.btnkstart.Text = "START";
            this.btnkstart.UseVisualStyleBackColor = true;
            this.btnkstart.Click += new System.EventHandler(this.btnkstart_Click);
            // 
            // btnkpause
            // 
            this.btnkpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkpause.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkpause.ForeColor = System.Drawing.Color.Coral;
            this.btnkpause.Location = new System.Drawing.Point(151, 226);
            this.btnkpause.Name = "btnkpause";
            this.btnkpause.Size = new System.Drawing.Size(133, 49);
            this.btnkpause.TabIndex = 2;
            this.btnkpause.Text = "PAUSE";
            this.btnkpause.UseVisualStyleBackColor = true;
            this.btnkpause.Click += new System.EventHandler(this.btnkpause_Click);
            // 
            // btnkrestart
            // 
            this.btnkrestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkrestart.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkrestart.ForeColor = System.Drawing.Color.Crimson;
            this.btnkrestart.Location = new System.Drawing.Point(290, 226);
            this.btnkrestart.Name = "btnkrestart";
            this.btnkrestart.Size = new System.Drawing.Size(133, 49);
            this.btnkrestart.TabIndex = 2;
            this.btnkrestart.Text = "RESTART";
            this.btnkrestart.UseVisualStyleBackColor = true;
            this.btnkrestart.Click += new System.EventHandler(this.btnkrestart_Click);
            // 
            // btngstart
            // 
            this.btngstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngstart.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngstart.ForeColor = System.Drawing.Color.DarkCyan;
            this.btngstart.Location = new System.Drawing.Point(459, 272);
            this.btngstart.Name = "btngstart";
            this.btngstart.Size = new System.Drawing.Size(133, 49);
            this.btngstart.TabIndex = 2;
            this.btngstart.Text = "START";
            this.btngstart.UseVisualStyleBackColor = true;
            this.btngstart.Click += new System.EventHandler(this.btngstart_Click);
            // 
            // btngpause
            // 
            this.btngpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngpause.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngpause.ForeColor = System.Drawing.Color.Coral;
            this.btngpause.Location = new System.Drawing.Point(598, 272);
            this.btngpause.Name = "btngpause";
            this.btngpause.Size = new System.Drawing.Size(133, 49);
            this.btngpause.TabIndex = 2;
            this.btngpause.Text = "PAUSE";
            this.btngpause.UseVisualStyleBackColor = true;
            this.btngpause.Click += new System.EventHandler(this.btngpause_Click);
            // 
            // btngrestart
            // 
            this.btngrestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrestart.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngrestart.ForeColor = System.Drawing.Color.Crimson;
            this.btngrestart.Location = new System.Drawing.Point(737, 272);
            this.btngrestart.Name = "btngrestart";
            this.btngrestart.Size = new System.Drawing.Size(133, 49);
            this.btngrestart.TabIndex = 2;
            this.btngrestart.Text = "RESTART";
            this.btngrestart.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtgeridakika
            // 
            this.txtgeridakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgeridakika.Location = new System.Drawing.Point(608, 182);
            this.txtgeridakika.Name = "txtgeridakika";
            this.txtgeridakika.Size = new System.Drawing.Size(37, 31);
            this.txtgeridakika.TabIndex = 0;
            this.txtgeridakika.Text = "00";
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtgerisaniye
            // 
            this.txtgerisaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgerisaniye.Location = new System.Drawing.Point(651, 182);
            this.txtgerisaniye.Name = "txtgerisaniye";
            this.txtgerisaniye.Size = new System.Drawing.Size(37, 31);
            this.txtgerisaniye.TabIndex = 1;
            this.txtgerisaniye.Text = "00";
            // 
            // txtgerisalise
            // 
            this.txtgerisalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgerisalise.Location = new System.Drawing.Point(694, 182);
            this.txtgerisalise.Name = "txtgerisalise";
            this.txtgerisalise.Size = new System.Drawing.Size(37, 31);
            this.txtgerisalise.TabIndex = 2;
            this.txtgerisalise.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(951, 454);
            this.Controls.Add(this.txtgerisalise);
            this.Controls.Add(this.txtgerisaniye);
            this.Controls.Add(this.txtgeridakika);
            this.Controls.Add(this.btngrestart);
            this.Controls.Add(this.btngpause);
            this.Controls.Add(this.btnkrestart);
            this.Controls.Add(this.btngstart);
            this.Controls.Add(this.btnkpause);
            this.Controls.Add(this.btnkstart);
            this.Controls.Add(this.lblkronometre);
            this.Controls.Add(this.lblgerisayim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblgerisayim;
        private System.Windows.Forms.Label lblkronometre;
        private System.Windows.Forms.Button btnkstart;
        private System.Windows.Forms.Button btnkpause;
        private System.Windows.Forms.Button btnkrestart;
        private System.Windows.Forms.Button btngstart;
        private System.Windows.Forms.Button btngpause;
        private System.Windows.Forms.Button btngrestart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtgeridakika;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtgerisaniye;
        private System.Windows.Forms.TextBox txtgerisalise;
    }
}

