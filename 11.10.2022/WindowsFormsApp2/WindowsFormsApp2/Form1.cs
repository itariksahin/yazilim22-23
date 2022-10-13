using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { byte ay = Convert.ToByte(textBox1.Text);
            switch (ay)
            {

                case 1: label2.Text="BU AYIN ADI:"+"Ocak"; break;
                case 2: label2.Text = "BU AYIN ADI:" + "Şubat"; break;
                case 3: label2.Text = "BU AYIN ADI:" + "Mart"; break;
                case 4: label2.Text = "BU AYIN ADI:" + "Nisan"; break;
                case 5: label2.Text = "BU AYIN ADI:" + "Mayıs"; break;
                case 6: label2.Text = "BU AYIN ADI:" + "Haziran"; break;
                case 7: label2.Text = "BU AYIN ADI:" + "Temmuz"; break;
                case 8: label2.Text = "BU AYIN ADI:" + "Ağustos"; break;
                case 9: label2.Text = "BU AYIN ADI:" + "Eylül"; break;
                case 10: label2.Text = "BU AYIN ADI:" + "Ekim"; break;
                case 11: label2.Text = "BU AYIN ADI:" + "Kasım"; break;
                case 12: label2.Text = "BU AYIN ADI:" + "Aralık"; break;

                default: label2.Text = "BU AYIN ADI:" + "Hata Böyle bir ay yok"; break;
            }
        }
    }
}
