using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dosya kaydedildi.");
        }

        private void optikSürücüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Optik sürücüye kaydedildi");
        }

        private void hDDSürücüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HDD sürücüye kaydedildi");
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
