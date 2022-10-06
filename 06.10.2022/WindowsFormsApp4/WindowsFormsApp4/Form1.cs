using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double ortalama = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) +
                Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox4.Text)) / 4;
            if (ortalama < 50) { label2.Text = "Sonuç:GEÇMEZ"; }
            else if(ortalama < 60) { label2.Text = "Sonuç:GEÇER"; }
            else if (ortalama < 70) { label2.Text = "Sonuç:ORTA"; }
            else if (ortalama < 85) { label2.Text = "Sonuç:İYİ"; }
            else { label2.Text = "Sonuç:PEKİYİ"; }
        }
    }
}
