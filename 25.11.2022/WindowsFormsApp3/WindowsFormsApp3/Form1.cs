using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cdortgen dortgen=new cdortgen();    
            dortgen.A=Convert.ToInt32(textBox1.Text);
            dortgen.B = Convert.ToInt32(textBox2.Text);
            dortgen.C = Convert.ToInt32(textBox3.Text);
            dortgen.D = Convert.ToInt32(textBox4.Text);
            MessageBox.Show("Çeşit kenar dörtgenin çevresi=" + dortgen.cevre.ToString());
        }
    }
}
