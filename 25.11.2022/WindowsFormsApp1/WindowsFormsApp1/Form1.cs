﻿using System;
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
            ucgen yeni_ucgen = new ucgen();
            yeni_ucgen.A=Convert.ToInt32(textBox1.Text);
            yeni_ucgen.B = Convert.ToInt32(textBox2.Text);
            yeni_ucgen.C = Convert.ToInt32(textBox3.Text);
            MessageBox.Show("Üç genin çevresi=" + yeni_ucgen.cevre.ToString());
        }
    }
}
