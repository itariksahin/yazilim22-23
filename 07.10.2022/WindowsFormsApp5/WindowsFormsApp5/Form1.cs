using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        double onceki_ortalama = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ortalama = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) 
                + Convert.ToDouble(textBox3.Text) +Convert.ToDouble(textBox4.Text) 
                + Convert.ToDouble(textBox5.Text) ) / 5;
            label2.Text = "Önceki ortalama:" + onceki_ortalama.ToString();
            label3.Text = "Mevcut ortlama" + ortalama.ToString();
            if (ortalama > onceki_ortalama) { label4.BackColor = Color.Red; }
            else if (ortalama < onceki_ortalama) { label4.BackColor = Color.Yellow; }
            else { label4.BackColor = Color.Blue; }
            onceki_ortalama = ortalama;
        }
    }
}
