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
            Double sayi1 = Convert.ToDouble(textBox1.Text);
            Double sayi2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(sayi1 / sayi2);
        }
    }
}
