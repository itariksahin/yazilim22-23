﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter tuşuna basıldı.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esc tuşuna basıldı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.ControlBox == true)
            {
                this.ControlBox = false;
            }
            else
            { 
            this.ControlBox= true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
