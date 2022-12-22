using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_each_ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] ders = new string[50];
        string[] Konu = new string[50];
        byte[] soru=new byte[50];
        int indes1 = 0;
        int indes2= 0;
        int indes3 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ders[indes1] = textBox1.Text;
            indes1++;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Konu[indes1] = textBox2.Text;
           indes2++;
           textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            soru[indes3]=Convert.ToByte(textBox3.Text);
            indes3++;
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string ders1 in ders)
            {   if(ders1!=null) listBox1.Items.Add(ders1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string konu1 in Konu)
                if(konu1!=null) listBox1.Items.Add(konu1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(byte soru1 in soru)
            {
                if (soru1!= 0) listBox1.Items.Add(soru1);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
