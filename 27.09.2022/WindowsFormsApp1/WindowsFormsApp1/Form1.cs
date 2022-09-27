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
    { Double zamli_fiyat;  
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Double fiyat = Convert.ToDouble(textBox2.Text);
            byte yuzde = Convert.ToByte(textBox3.Text);
            zamli_fiyat = fiyat + ((fiyat * yuzde) / 100);
            label4.Text =textBox1.Text+" zamlı fiyat " + zamli_fiyat.ToString() + " tl dir.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text+":"+zamli_fiyat);
            textBox1.Text =textBox2.Text=textBox3.Text="";
        }
    }
}
