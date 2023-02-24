using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formkontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString()) 
            { 
                case "KIRMIZI": button1.BackColor = this.BackColor; this.BackColor = Color.Red; break;
                case "MAVİ": button1.BackColor = this.BackColor; this.BackColor = Color.Blue; break;
                case "SİYAH": button1.BackColor = this.BackColor; this.BackColor = Color.Black; break;
                case "YEŞİL": button1.BackColor = this.BackColor; this.BackColor = Color.Green; break;
                case "SARI": button1.BackColor = this.BackColor; this.BackColor = Color.Yellow; break;
                case "BEYAZ": button1.BackColor = this.BackColor; this.BackColor = Color.White; break;
                case "GRİ": button1.BackColor = this.BackColor; this.BackColor = Color.Gray; break;
                case "PEMBE": button1.BackColor = this.BackColor; this.BackColor = Color.Pink; break;
                case "MOR": button1.BackColor = this.BackColor; this.BackColor = Color.Magenta; break;
                 
             }
        }
    }
}
