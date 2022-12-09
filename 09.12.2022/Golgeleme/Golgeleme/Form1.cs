using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golgeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yonetim yunus=new yonetim();
            yunus.Ad = textBox1.Text;
            yunus.Soyad = textBox2.Text;
            yunus.kimlik_numarasi = textBox3.Text;
            yunus.birim = textBox4.Text;
            yunus.maasi = textBox5.Text;
            MessageBox.Show(yunus.adsoyad());
        }
    }
}
