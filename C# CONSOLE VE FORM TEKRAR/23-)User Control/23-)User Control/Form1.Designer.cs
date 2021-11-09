namespace _23__User_Control
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
            this.ctrlisim = new _23__User_Control.InputControls();
            this.ctrlsoyisim = new _23__User_Control.InputControls();
            this.ctrlmail = new _23__User_Control.InputControls();
            this.ctrlsifre = new _23__User_Control.InputControls();
            this.btnkaydol = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ctrlisim
            // 
            this.ctrlisim.BackColor = System.Drawing.Color.Transparent;
            this.ctrlisim.Location = new System.Drawing.Point(12, 12);
            this.ctrlisim.Name = "ctrlisim";
            this.ctrlisim.Size = new System.Drawing.Size(340, 52);
            this.ctrlisim.TabIndex = 0;
            // 
            // ctrlsoyisim
            // 
            this.ctrlsoyisim.BackColor = System.Drawing.Color.Transparent;
            this.ctrlsoyisim.Location = new System.Drawing.Point(12, 70);
            this.ctrlsoyisim.Name = "ctrlsoyisim";
            this.ctrlsoyisim.Size = new System.Drawing.Size(340, 52);
            this.ctrlsoyisim.TabIndex = 0;
            // 
            // ctrlmail
            // 
            this.ctrlmail.BackColor = System.Drawing.Color.Transparent;
            this.ctrlmail.Location = new System.Drawing.Point(12, 128);
            this.ctrlmail.Name = "ctrlmail";
            this.ctrlmail.Size = new System.Drawing.Size(340, 52);
            this.ctrlmail.TabIndex = 0;
            // 
            // ctrlsifre
            // 
            this.ctrlsifre.BackColor = System.Drawing.Color.Transparent;
            this.ctrlsifre.Location = new System.Drawing.Point(12, 186);
            this.ctrlsifre.Name = "ctrlsifre";
            this.ctrlsifre.Size = new System.Drawing.Size(340, 52);
            this.ctrlsifre.TabIndex = 0;
            // 
            // btnkaydol
            // 
            this.btnkaydol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydol.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydol.Location = new System.Drawing.Point(12, 244);
            this.btnkaydol.Name = "btnkaydol";
            this.btnkaydol.Size = new System.Drawing.Size(327, 75);
            this.btnkaydol.TabIndex = 1;
            this.btnkaydol.Text = "KAYDOL";
            this.btnkaydol.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(386, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(634, 296);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İSİM";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SOYİSİM";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-MAİL";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ŞİFRE";
            this.columnHeader4.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 333);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnkaydol);
            this.Controls.Add(this.ctrlsifre);
            this.Controls.Add(this.ctrlmail);
            this.Controls.Add(this.ctrlsoyisim);
            this.Controls.Add(this.ctrlisim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnkaydol;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public InputControls ctrlisim;
        public InputControls ctrlsoyisim;
        public InputControls ctrlmail;
        public InputControls ctrlsifre;
    }
}

