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

        private void button1_Click(object sender, EventArgs e)
        { int topla=0;
            int sayac = Convert.ToInt32(textBox1.Text);
            while (sayac <= Convert.ToInt32(textBox2.Text))
            {
                topla += sayac;
                sayac++;
            }
            MessageBox.Show(topla.ToString());
        }
    }
}
