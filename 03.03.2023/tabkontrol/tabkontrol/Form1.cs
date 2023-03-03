using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabkontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = textBox1.Text + " " + textBox2.Text + Environment.NewLine 
                + textBox3.Text + Environment.NewLine + dateTimePicker1.Text 
                + Environment.NewLine + textBox4.Text;
            Decimal hesap = numericUpDown1.Value * 90 + numericUpDown2.Value * 60 +
                numericUpDown3.Value * 55 + numericUpDown4.Value * 30 +
                numericUpDown5.Value * 105 + numericUpDown6.Value * 96 +
                numericUpDown7.Value * 20 + numericUpDown8.Value * 35 +
                numericUpDown9.Value * 20 + numericUpDown10.Value * 50 +
                numericUpDown11.Value * 50 + numericUpDown12.Value * 100 +
                numericUpDown13.Value * 80 + numericUpDown14.Value * 50 +
                numericUpDown15.Value * 35 + numericUpDown16.Value * 30 +
                numericUpDown17.Value * 15 + numericUpDown18.Value * 20 +
                numericUpDown19.Value * 15 + numericUpDown20.Value * 14 +
                numericUpDown21.Value * 10 + numericUpDown22.Value * 10 +
                numericUpDown23.Value * 35 + numericUpDown24.Value * 30 +
                numericUpDown25.Value * 38 + numericUpDown26.Value * 20 +
                numericUpDown27.Value * 65 + numericUpDown28.Value * 40 +
                numericUpDown29.Value * 55 + numericUpDown30.Value * 30 +
                numericUpDown31.Value * 20 + numericUpDown32.Value * 40 +
                numericUpDown33.Value * 60;
            textBox6.Text = hesap.ToString() + "TL";

        }
    }
}
