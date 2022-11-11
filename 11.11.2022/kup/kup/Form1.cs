using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kup yeni_kup = new kup(Convert.ToInt32(textBox1.Text));
                label2.Text = label2.Text + yeni_kup.cevre().ToString();
                label3.Text = label3.Text + yeni_kup.alan().ToString();
                label4.Text = label4.Text + yeni_kup.hacim().ToString();
            }
            catch
            {
                MessageBox.Show("sayısal değer girmediniz");
            }
            finally
            { }
        }
    }
}
