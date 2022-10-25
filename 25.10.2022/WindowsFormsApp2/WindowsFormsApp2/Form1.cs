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
        {
            int sayac2 = 0; 
            int sayac3 = 0;
            for (int sayac1 = 0; sayac1 < Convert.ToInt16(textBox1.Text); sayac1++)
            {
                listBox1.Items.Add(textBox2.Text);
            }

            while(sayac2 < Convert.ToInt16(textBox1.Text))
            {
                listBox2.Items.Add(textBox2.Text);
                sayac2++;
            }

            do
            {
                listBox3.Items.Add(textBox2.Text);
                sayac3++;
            } while (sayac3 < Convert.ToInt16(textBox1.Text));

        }
    }
}
