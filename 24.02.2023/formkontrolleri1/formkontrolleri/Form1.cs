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
                case "KIRMIZI": this.BackColor = Color.Red; break;
                case "MAVİ": this.BackColor = Color.Blue; break;
                case "SİYAH": this.BackColor = Color.Black; break;
                case "YEŞİL": this.BackColor = Color.Green; break;
                case "SARI": this.BackColor = Color.Yellow; break;
                case "BEYAZ": this.BackColor = Color.White; break;
                case "GRİ": this.BackColor = Color.Gray; break;
                case "PEMBE": this.BackColor = Color.Pink; break;
                case "MOR": this.BackColor = Color.Magenta; break;
                 
             }
        }
    }
}
