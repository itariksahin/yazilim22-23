using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupbxkontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tabanfiyat=500;
            decimal cpufiyat = 0;
            decimal ramfiyat = 0;
            decimal diskfiyat = 0;
            decimal ekranfiyat = 0;
            if (radioButton1.Checked) cpufiyat = 700;
            else if (radioButton2.Checked) cpufiyat = 500;
            else if (radioButton3.Checked) cpufiyat = 350;
            else if (radioButton4.Checked) cpufiyat = 600;
            else if (radioButton5.Checked) cpufiyat = 375;
            else MessageBox.Show("işlemci Seciniz");
            tabanfiyat += cpufiyat;
            if (radioButton6.Checked) ramfiyat = 1000;
            else if (radioButton7.Checked) ramfiyat = 800;
            else if (radioButton8.Checked) ramfiyat = 600;
            else if (radioButton9.Checked) ramfiyat = 400;
            else if (radioButton10.Checked) ramfiyat = 200;
            else MessageBox.Show("Ram seciniz");
            tabanfiyat+=ramfiyat;
            if (radioButton11.Checked) diskfiyat = 500;
            else if (radioButton12.Checked) diskfiyat = 400;
            else if (radioButton13.Checked) diskfiyat = 300;
            else if (radioButton14.Checked) diskfiyat = 200;
            else if (radioButton15.Checked) diskfiyat = 100;
            else MessageBox.Show("Sabit disk fiyatı seciniz");
            tabanfiyat+=diskfiyat;
            if (radioButton16.Checked) ekranfiyat = 2000;
            else if (radioButton17.Checked) ekranfiyat = 1500;
            else if (radioButton18.Checked) ekranfiyat = 1750;
            else if (radioButton19.Checked) ekranfiyat = 1850;
            else if (radioButton20.Checked) ekranfiyat = 1900;
            else MessageBox.Show("Ekran kartı seciniz");
            tabanfiyat+=ekranfiyat;
            if (checkBox1.Checked) tabanfiyat += 350;
            if (checkBox2.Checked) tabanfiyat += 120;
            if (checkBox3.Checked) tabanfiyat += 130;
            if (checkBox4.Checked) tabanfiyat += 222;
            if (checkBox5.Checked) tabanfiyat += 600;
            textBox1.Text = tabanfiyat.ToString()+"TL";

        }
    }
}
