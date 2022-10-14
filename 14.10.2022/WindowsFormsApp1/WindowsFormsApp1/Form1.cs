using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici_adi = "utkan";
            string sifre = "berkay1453";
            if ((kullanici_adi==textBox1.Text)&&(sifre==textBox2.Text)) 
            { MessageBox.Show("Hoş geldiniz"); }
            else { MessageBox.Show("tekrar deneyin!!"); }
        }
    }
}
