using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue yigin=new Queue();
        Stack yigin2=new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            yigin.Enqueue(textBox1.Text);
            textBox1.Text = "";
            Listele();

        }
        private void Listele()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Queue listesi");
            foreach (string yaz in yigin)
            {
                listBox1.Items.Add(yaz);
            }
            listBox1.Items.Add("stack listesi");
            foreach (string yaz in yigin2)
            {
                listBox1.Items.Add(yaz);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            yigin.Dequeue();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yigin2.Push(textBox1.Text);
            textBox1.Text = "";
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yigin2.Pop();
            Listele();
        }
    }
}
