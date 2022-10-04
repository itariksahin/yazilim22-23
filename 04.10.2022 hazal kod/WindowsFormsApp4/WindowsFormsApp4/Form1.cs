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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sayi3, sayi4, sayi5, ortalama;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sayi3 = Convert.ToDouble(textBox3.Text);
            sayi4 = Convert.ToDouble(textBox4.Text);
            sayi5 = Convert.ToDouble(textBox5.Text);
            ortalama = ((sayi1 + sayi2 + sayi3 + sayi4 + sayi5));
            
           
           







        }
    }
}
