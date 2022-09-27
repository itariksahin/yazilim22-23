using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {   double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sayi3 = Convert.ToDouble(textBox3.Text);
            double sayi4 = Convert.ToDouble(textBox4.Text);
            double sayi5 = Convert.ToDouble(textBox5.Text);
            double sayi6 = Convert.ToDouble(textBox6.Text);
            double sayi7 = Convert.ToDouble(textBox7.Text);
            double sayi8 = Convert.ToDouble(textBox8.Text);
            double carpim = sayi1 * sayi2 * sayi3 * sayi4 * sayi5 * sayi6 * sayi7 * sayi8;
            label9.Text = "Sayıların çarpımı:" + (carpim.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sayi3 = Convert.ToDouble(textBox3.Text);
            double sayi4 = Convert.ToDouble(textBox4.Text);
            double sayi5 = Convert.ToDouble(textBox5.Text);
            double sayi6 = Convert.ToDouble(textBox6.Text);
            double sayi7 = Convert.ToDouble(textBox7.Text);
            double sayi8 = Convert.ToDouble(textBox8.Text);
            double ortalama = (sayi1 + sayi2 + sayi3 + sayi4 + sayi5 + sayi6 + sayi7 + sayi8)/8;
            label10.Text = "Ortalama:" + (ortalama.ToString());
        }
    }
}
