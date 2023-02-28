using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal renk = 0;
            decimal model = 0;
            decimal toplamfiyat = 100000;
            decimal lcapi = 0;
            decimal tekeryanagi = 0;
            if (radioButton1.Checked) model = 16750;
            else if (radioButton2.Checked) model = 16000;
            else if (radioButton3.Checked) model = 15000;
            else if (radioButton4.Checked) model = 14000;
            else if (radioButton5.Checked) model = 13000;
            else if (radioButton6.Checked) model = 11000;
            else if (radioButton7.Checked) model = 10000;
            else MessageBox.Show("Model Seçiniz");
            toplamfiyat += model;
            if (radioButton8.Checked) { renk = 1000; this.BackColor = Color.Gold; this.ForeColor = Color.Black; }
            else if (radioButton9.Checked) { renk = 1000; this.BackColor = Color.Black; this.ForeColor = Color.White; }
            else if (radioButton10.Checked) { renk = 1000; this.BackColor = Color.RoyalBlue; this.ForeColor = Color.Black; }
            else if (radioButton11.Checked) { renk = 1000; this.BackColor = Color.Gray; this.ForeColor = Color.Black; }
            else if (radioButton12.Checked) { renk = 1000; this.BackColor = Color.LawnGreen; this.ForeColor = Color.Black; }
            else if (radioButton13.Checked) { renk = 1000; this.BackColor = Color.Red; this.ForeColor = Color.Black; }
            else if (radioButton14.Checked) { renk = 1000; this.BackColor = Color.HotPink; this.ForeColor = Color.Black; }
            else if (radioButton15.Checked) { renk = 1000; this.BackColor = Color.BlueViolet; this.ForeColor = Color.Black; }
            else if (radioButton16.Checked) { renk = 1000; this.BackColor = Color.White; this.ForeColor = Color.Black; }
            else MessageBox.Show("Renk Seçiniz");
            toplamfiyat += renk;
            if (radioButton17.Checked) lcapi = 1100;
            else if (radioButton18.Checked) lcapi = 1200;
            else if (radioButton19.Checked) lcapi = 13000;
            else if (radioButton20.Checked) lcapi = 1400;
            else if (radioButton21.Checked) lcapi = 1500;
            else MessageBox.Show("Lastik Çapı Seçiniz");
            toplamfiyat += lcapi;
            if (radioButton22.Checked) tekeryanagi = 1000;
            else if (radioButton23.Checked) tekeryanagi = 1200;
            else if (radioButton24.Checked) tekeryanagi = 1400;
            else if (radioButton25.Checked) tekeryanagi = 900;
            else if (radioButton26.Checked) tekeryanagi = 1300;
            else MessageBox.Show("Teker Yanağı Seçinşz");
            toplamfiyat += tekeryanagi;
            if (checkBox1.Checked) toplamfiyat += 1000;
            if (checkBox2.Checked) toplamfiyat += 10000;
            if (checkBox3.Checked) toplamfiyat += 1200;
            if (checkBox4.Checked) toplamfiyat += 3450;
            if (checkBox5.Checked) toplamfiyat += 1360;
            if (checkBox6.Checked) toplamfiyat += 3540;
            if (checkBox7.Checked) toplamfiyat += 5500;
            if (checkBox8.Checked) toplamfiyat += 3000;
            if (checkBox9.Checked) toplamfiyat += 4000;
            if (checkBox10.Checked) toplamfiyat += 2500;
            if (checkBox11.Checked) toplamfiyat += 3000;
            if (checkBox12.Checked) toplamfiyat += 1200;
            if (checkBox13.Checked) toplamfiyat += 900;
            if (checkBox14.Checked) toplamfiyat += 5000;
            textBox1.Text = toplamfiyat.ToString() + " TL";
        }
    }
}
