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
        {   //for(int i=0;i<150;i++){}
            int i = 0;
            while(i<150)
            {
               listBox1.Items.Add(textBox1.Text);

             i++;
            }
        }
    }
}
