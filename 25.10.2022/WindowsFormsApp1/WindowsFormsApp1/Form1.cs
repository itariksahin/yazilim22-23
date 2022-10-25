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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            while (sayac < 50)
            { 
            listBox1.Items.Add(sayac.ToString());
            sayac++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            do
            {
                listBox2.Items.Add(sayac.ToString());
                sayac++;
            } while (sayac < 50);
        }
    }
}
