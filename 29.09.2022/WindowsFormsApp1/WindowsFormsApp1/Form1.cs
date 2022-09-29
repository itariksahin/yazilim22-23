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
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt16(textBox1.Text) + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Convert.ToInt16(textBox2.Text) + 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToInt16(textBox3.Text) + 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(Convert.ToInt16(textBox4.Text) + 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(Convert.ToInt16(textBox5.Text) + 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(Convert.ToInt16(textBox6.Text) + 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Text = Convert.ToString(Convert.ToInt16(textBox7.Text) + 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox8.Text = Convert.ToString(Convert.ToInt16(textBox8.Text) + 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt16(textBox1.Text) - 1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Convert.ToInt16(textBox2.Text) - 1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToInt16(textBox3.Text) - 1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(Convert.ToInt16(textBox4.Text) - 1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(Convert.ToInt16(textBox5.Text) - 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(Convert.ToInt16(textBox6.Text) - 1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox7.Text = Convert.ToString(Convert.ToInt16(textBox7.Text) - 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox8.Text = Convert.ToString(Convert.ToInt16(textBox8.Text) - 1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text =
                textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label1.Text+ ":" + textBox1.Text);
            listBox1.Items.Add(label2.Text +  ":" + textBox2.Text);
            listBox1.Items.Add(label3.Text +  ":" + textBox3.Text);
            listBox1.Items.Add(label4.Text +  ":" + textBox4.Text);
            listBox1.Items.Add(label5.Text +  ":" + textBox5.Text);
            listBox1.Items.Add(label6.Text +  ":" + textBox6.Text);
            listBox1.Items.Add(label7.Text +  ":" + textBox7.Text);
            listBox1.Items.Add(label8.Text +  ":" + textBox8.Text);
            listBox1.Items.Add("##########################");
        }
    }
}
