using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte kilo = Convert.ToByte(textBox1.Text);
            if (kilo < 20) { label2.Text = "İskelet";label2.BackColor = Color.DarkBlue;label2.ForeColor = Color.White; }
            else if (kilo < 40) { label2.Text = "ÇILIZ";label2.BackColor = Color.Blue; label2.ForeColor = Color.Gray; }
            else if (kilo < 60) { label2.Text = "İDEAL";label2.BackColor = Color.Green; label2.ForeColor = Color.Azure; }
            else if (kilo < 80) { label2.Text = "HAFİF KİLOLU";label2.BackColor = Color.Yellow; label2.ForeColor = Color.Coral; }
            else if (kilo < 100) { label2.Text = "BALIK ETLİ";label2.BackColor = Color.Cyan; label2.ForeColor = Color.DarkOrange; }
            else if (kilo < 120) { label2.Text = "OBEZ";label2.BackColor = Color.Red; label2.ForeColor = Color.FloralWhite; }
            else { label2.Text = "YOK ARTIK HAZAL";label2.BackColor = Color.DarkRed; label2.ForeColor = Color.DarkViolet; }
        }
    }
}
