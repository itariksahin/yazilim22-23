using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dortislem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dortislem islem = new Dortislem(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            if (comboBox1.SelectedItem.ToString() == "TOPLA")
            {
                label3.Text = "SONUÇ:" + islem.topla().ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "ÇIKART")
            {
                label3.Text = "SONUÇ:" + islem.cıkart().ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "BÖL")
            {
                label3.Text = "SONUÇ:" + islem.bol().ToString();
            }
            if (comboBox1.SelectedItem.ToString() == "ÇARP")
            {
                label3.Text = "SONUÇ:" + islem.carp().ToString();
            }
        }
    }
}
