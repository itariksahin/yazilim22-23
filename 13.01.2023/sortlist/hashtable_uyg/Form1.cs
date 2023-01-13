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
// Hashtable örneği değiştirilerek SortedList örneği verildiği  için dosya adı hashtabeldır.
namespace hashtable_uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SortedList ogrencikayit=new SortedList();
        private void button1_Click(object sender, EventArgs e)
        {
            ogrencikayit.Add(int.Parse(textBox1.Text), textBox2.Text);
            textBox1.Text = textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrencikayit.Remove(int.Parse(textBox1.Text));
            ogrencikayit.Remove(textBox2.Text);
            textBox1.Text = textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(DictionaryEntry yaz in ogrencikayit)
            {
                listBox1.Items.Add(yaz.Key + "" + yaz.Value);
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrencikayit[int.Parse(textBox1.Text)]=textBox2.Text;
            textBox1.Text = textBox2.Text = "";
        }
    }
}
