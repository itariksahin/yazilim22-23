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
            Random rastgele = new Random();
            int at1 = rastgele.Next(1, 10);
            int at2 = rastgele.Next(1, 10);
            int at3 = rastgele.Next(1, 10);
            int at4 = rastgele.Next(1, 10);
            pictureBox1.Left = pictureBox1.Left + at1;
            pictureBox2.Left=pictureBox2.Left + at2;
            pictureBox3.Left = pictureBox1.Left + at3;
            pictureBox4.Left = pictureBox2.Left + at4;

        }
    }
}
