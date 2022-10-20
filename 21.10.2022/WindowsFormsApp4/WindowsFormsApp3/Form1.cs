using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
            for (int i = 0; i < 100; i++)
            {
                Random rastgele = new Random();
                int at1 = rastgele.Next(1, 10);
                int at2 = rastgele.Next(1, 10);
                int at3 = rastgele.Next(1, 10);
                int at4 = rastgele.Next(1, 10);
                pictureBox1.Left = pictureBox1.Left + at1;
                pictureBox2.Left = pictureBox2.Left + at2;
                pictureBox3.Left = pictureBox1.Left + at3;
                pictureBox4.Left = pictureBox2.Left + at4;
                Thread.Sleep(300);
            }
            if ((pictureBox1.Left > pictureBox2.Left) && (pictureBox1.Left > pictureBox3.Left) && (pictureBox1.Left > pictureBox4.Left))
                MessageBox.Show("At 1 kazandı");
            if ((pictureBox2.Left > pictureBox1.Left) && (pictureBox2.Left > pictureBox3.Left) && (pictureBox2.Left > pictureBox4.Left))
                MessageBox.Show("At 2 kazandı");
            if ((pictureBox3.Left > pictureBox2.Left) && (pictureBox3.Left > pictureBox1.Left) && (pictureBox3.Left > pictureBox4.Left))
                MessageBox.Show("At 3 kazandı");
            if ((pictureBox4.Left > pictureBox2.Left) && (pictureBox4.Left > pictureBox3.Left) && (pictureBox4.Left > pictureBox1.Left))
                MessageBox.Show("At 4 kazandı");
        }
    }
}
