using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıfornegidikdortgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dikdortgen ilk_dikdortgen = new dikdortgen(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = label3.Text + ilk_dikdortgen.AlanHesap().ToString()+"Metre2";
            label4.Text = label4.Text + ilk_dikdortgen.Cevrehesap().ToString()+"Metre";
        }
    }
}
