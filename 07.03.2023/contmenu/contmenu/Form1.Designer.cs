namespace contmenu
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
            this.aÇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hizalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yukarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşağıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aÇToolStripMenuItem,
            this.kapatToolStripMenuItem,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.hizalaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 114);
            // 
            // aÇToolStripMenuItem
            // 
            this.aÇToolStripMenuItem.Name = "aÇToolStripMenuItem";
            this.aÇToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aÇToolStripMenuItem.Text = "AÇ";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // hizalaToolStripMenuItem
            // 
            this.hizalaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sağaToolStripMenuItem,
            this.solaToolStripMenuItem,
            this.yukarıToolStripMenuItem,
            this.aşağıToolStripMenuItem});
            this.hizalaToolStripMenuItem.Name = "hizalaToolStripMenuItem";
            this.hizalaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.hizalaToolStripMenuItem.Text = "Hizala";
            // 
            // sağaToolStripMenuItem
            // 
            this.sağaToolStripMenuItem.Name = "sağaToolStripMenuItem";
            this.sağaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sağaToolStripMenuItem.Text = "sağa";
            // 
            // solaToolStripMenuItem
            // 
            this.solaToolStripMenuItem.Name = "solaToolStripMenuItem";
            this.solaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.solaToolStripMenuItem.Text = "sola";
            // 
            // yukarıToolStripMenuItem
            // 
            this.yukarıToolStripMenuItem.Name = "yukarıToolStripMenuItem";
            this.yukarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yukarıToolStripMenuItem.Text = "yukarı";
            // 
            // aşağıToolStripMenuItem
            // 
            this.aşağıToolStripMenuItem.Name = "aşağıToolStripMenuItem";
            this.aşağıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aşağıToolStripMenuItem.Text = "Aşağı";
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(27, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(271, 152);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 268);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aÇToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hizalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yukarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşağıToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

