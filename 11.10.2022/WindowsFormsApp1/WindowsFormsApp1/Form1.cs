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
    {   int gun = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int gun = Convert.ToInt32(DateTime.Now.DayOfWeek);
            
            switch(gun)
            {
                case 1: label1.Text = "pazartesi"; break;
                case 2: label1.Text = "salı";break;
                case 3: label1.Text = "çarşamba";break;
                case 4: label1.Text = "perşembe";break;
                case 5: label1.Text = "cuma";break;
                case 6: label1.Text = "Cumartesi";break;
                case 7: label1.Text = "pazar";break;
                default:label1.Text = "HATA OLUŞTU"; break;

            }
            gun = gun + 1;
            if(gun == 9) { gun = 1; }
        }
    }
}
