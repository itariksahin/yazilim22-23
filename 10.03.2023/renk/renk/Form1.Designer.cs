namespace renk
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bİCİMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yAZIRENGİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yAZIARKAPLANRENGİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRKAPLANRENGİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bİCİMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bİCİMToolStripMenuItem
            // 
            this.bİCİMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yAZIRENGİToolStripMenuItem,
            this.yAZIARKAPLANRENGİToolStripMenuItem,
            this.aRKAPLANRENGİToolStripMenuItem});
            this.bİCİMToolStripMenuItem.Name = "bİCİMToolStripMenuItem";
            this.bİCİMToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.bİCİMToolStripMenuItem.Text = "BİCİM";
            // 
            // yAZIRENGİToolStripMenuItem
            // 
            this.yAZIRENGİToolStripMenuItem.Name = "yAZIRENGİToolStripMenuItem";
            this.yAZIRENGİToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.yAZIRENGİToolStripMenuItem.Text = "YAZI RENGİ";
            this.yAZIRENGİToolStripMenuItem.Click += new System.EventHandler(this.yAZIRENGİToolStripMenuItem_Click);
            // 
            // yAZIARKAPLANRENGİToolStripMenuItem
            // 
            this.yAZIARKAPLANRENGİToolStripMenuItem.Name = "yAZIARKAPLANRENGİToolStripMenuItem";
            this.yAZIARKAPLANRENGİToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.yAZIARKAPLANRENGİToolStripMenuItem.Text = "YAZI ARKA PLAN RENGİ";
            this.yAZIARKAPLANRENGİToolStripMenuItem.Click += new System.EventHandler(this.yAZIARKAPLANRENGİToolStripMenuItem_Click);
            // 
            // aRKAPLANRENGİToolStripMenuItem
            // 
            this.aRKAPLANRENGİToolStripMenuItem.Name = "aRKAPLANRENGİToolStripMenuItem";
            this.aRKAPLANRENGİToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.aRKAPLANRENGİToolStripMenuItem.Text = "ARKA PLAN RENGİ";
            this.aRKAPLANRENGİToolStripMenuItem.Click += new System.EventHandler(this.aRKAPLANRENGİToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(145, 284);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 419);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bİCİMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yAZIRENGİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yAZIARKAPLANRENGİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRKAPLANRENGİToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

