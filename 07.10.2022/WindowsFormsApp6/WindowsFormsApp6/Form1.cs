using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(textBox1.Text);
            int sayi2 = Convert.ToInt16(textBox2.Text);
            int sayi3 = Convert.ToInt16(textBox3.Text);
            int gecici;
            if (sayi1 > sayi2) { gecici = sayi2;
                                 sayi2 = sayi1;
                                 sayi1 = gecici;
            }
            if (sayi1 > sayi3) {
                gecici = sayi3;
                sayi3 = sayi1;
                sayi1 = gecici;
            }
            if (sayi2 > sayi3) {
                gecici = sayi2;
                sayi2 = sayi3;
                sayi3 = gecici;
            }
            textBox1.Text = sayi1.ToString();
            textBox2.Text = sayi2.ToString();
            textBox3.Text = sayi3.ToString();
        }
    }
}
