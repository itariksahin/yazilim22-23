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

namespace dictionary_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int,string> iller=new Dictionary<int,string>();
        private void button1_Click(object sender, EventArgs e)
        {
            iller.Add(int.Parse(textBox1.Text), textBox2.Text);
            textBox1.Text = textBox2.Text = "";
            listBox1.Items.Clear();
            foreach(var yaz in iller)
            { listBox1.Items.Add(yaz.Key+"-"+yaz.Value); }

        }
    }
}
