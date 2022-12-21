using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tek_Boyutlu_Dizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] marka = new string[225];
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            marka[sayac] = textBox1.Text;
            textBox1.Text = "";
            sayac++;
         }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<marka.Length;i++)
            {   if (marka[i] == null) i = 225;
                else
                    listBox1.Items.Add(marka[i]);
                
            }
        }
    }
}
