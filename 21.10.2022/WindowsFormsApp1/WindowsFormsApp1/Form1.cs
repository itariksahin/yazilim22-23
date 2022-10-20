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
            int topla = Convert.ToInt16(textBox1.Text) + Convert.ToInt16(textBox2.Text);
            textBox1.Text = topla.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cikar = Convert.ToInt16(textBox1.Text) - Convert.ToInt16(textBox2.Text);
            textBox1.Text = cikar.ToString();
        }
    }
}
