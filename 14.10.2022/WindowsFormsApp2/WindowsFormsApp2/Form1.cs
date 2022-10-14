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
            byte boy = Convert.ToByte(textBox1.Text);
            byte kilo = Convert.ToByte(textBox2.Text);
            if(comboBox1.SelectedItem=="Erkek")
            { if ((kilo>75) && (kilo<100) && (boy>175) && (boy<195)) 
                { MessageBox.Show("Polis olabilir."); } else { MessageBox.Show("Polis olamaz."); } }
            if(comboBox1.SelectedItem=="Kadın")
            {if ((kilo > 60) && (kilo < 90) && (boy > 160) && (boy < 185))
                { MessageBox.Show("Polis olabilir."); } else { MessageBox.Show("Polis olamaz."); } }
        }
    }
}
