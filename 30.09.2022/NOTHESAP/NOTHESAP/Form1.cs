using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOTHESAP
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

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Ders notlarının hesaplanması
            double ders1, ders2, ders3, ders4, ders5, ders6, ders7, ders8,
                ders9, ders10, ders11, ders12;
            ders1 = Convert.ToDouble(textBox1.Text) * 0.40 +
                    Convert.ToDouble(textBox2.Text) * 0.30 +
                    Convert.ToDouble(textBox3.Text) * 0.15 +
                    Convert.ToDouble(textBox4.Text) * 0.15;
            textBox5.Text = ders1.ToString();
            ders2 = Convert.ToDouble(textBox7.Text) * 0.40 +
                    Convert.ToDouble(textBox8.Text) * 0.30 +
                    Convert.ToDouble(textBox9.Text) * 0.15 +
                    Convert.ToDouble(textBox10.Text) * 0.15;
            textBox11.Text = ders2.ToString();
            ders3 = Convert.ToDouble(textBox13.Text) * 0.40 +
                    Convert.ToDouble(textBox14.Text) * 0.30 +
                    Convert.ToDouble(textBox15.Text) * 0.15 +
                    Convert.ToDouble(textBox16.Text) * 0.15;
            textBox17.Text = ders3.ToString();
            ders4 = Convert.ToDouble(textBox19.Text) * 0.40 +
                    Convert.ToDouble(textBox20.Text) * 0.30 +
                    Convert.ToDouble(textBox21.Text) * 0.15 +
                    Convert.ToDouble(textBox22.Text) * 0.15;
            textBox23.Text = ders4.ToString();
            ders5 = Convert.ToDouble(textBox25.Text) * 0.40 +
                    Convert.ToDouble(textBox26.Text) * 0.30 +
                    Convert.ToDouble(textBox27.Text) * 0.15 +
                    Convert.ToDouble(textBox28.Text) * 0.15;
            textBox29.Text = ders5.ToString();
            ders6 = Convert.ToDouble(textBox31.Text) * 0.40 +
                    Convert.ToDouble(textBox32.Text) * 0.30 +
                    Convert.ToDouble(textBox33.Text) * 0.15 +
                    Convert.ToDouble(textBox34.Text) * 0.15;
            textBox35.Text = ders6.ToString();
            ders7 = Convert.ToDouble(textBox37.Text) * 0.40 +
                    Convert.ToDouble(textBox38.Text) * 0.30 +
                    Convert.ToDouble(textBox39.Text) * 0.15 +
                    Convert.ToDouble(textBox40.Text) * 0.15;
            textBox41.Text = ders7.ToString();
            ders8 = Convert.ToDouble(textBox43.Text) * 0.40 +
                    Convert.ToDouble(textBox44.Text) * 0.30 +
                    Convert.ToDouble(textBox45.Text) * 0.15 +
                    Convert.ToDouble(textBox46.Text) * 0.15;
            textBox47.Text = ders8.ToString();
            ders9 = Convert.ToDouble(textBox49.Text) * 0.40 +
                    Convert.ToDouble(textBox50.Text) * 0.30 +
                    Convert.ToDouble(textBox51.Text) * 0.15 +
                    Convert.ToDouble(textBox52.Text) * 0.15;
            textBox53.Text = ders9.ToString();
            ders10 = Convert.ToDouble(textBox55.Text) * 0.40 +
                    Convert.ToDouble(textBox56.Text) * 0.30 +
                    Convert.ToDouble(textBox57.Text) * 0.15 +
                    Convert.ToDouble(textBox58.Text) * 0.15;
            textBox59.Text = ders10.ToString();
            ders11 = Convert.ToDouble(textBox61.Text) * 0.40 +
                    Convert.ToDouble(textBox62.Text) * 0.30 +
                    Convert.ToDouble(textBox63.Text) * 0.15 +
                    Convert.ToDouble(textBox64.Text) * 0.15;
            textBox65.Text = ders11.ToString();
            ders12 = Convert.ToDouble(textBox67.Text) * 0.40 +
                    Convert.ToDouble(textBox68.Text) * 0.30 +
                    Convert.ToDouble(textBox69.Text) * 0.15 +
                    Convert.ToDouble(textBox70.Text) * 0.15;
            textBox71.Text = ders12.ToString();
            // Toplam ders saaati 
            int top_ders = Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox12.Text) +
                Convert.ToInt32(textBox18.Text) + Convert.ToInt32(textBox24.Text) +
                Convert.ToInt32(textBox30.Text) + Convert.ToInt32(textBox36.Text) +
                Convert.ToInt32(textBox42.Text) + Convert.ToInt32(textBox48.Text) +
                Convert.ToInt32(textBox54.Text) + Convert.ToInt32(textBox60.Text) +
                Convert.ToInt32(textBox66.Text) + Convert.ToInt32(textBox72.Text);
            // Agırlıklı orlama
           double agirlikli_ort= (ders1*Convert.ToInt32(textBox6.Text) + ders2 * Convert.ToInt32(textBox12.Text) +
                ders3 * Convert.ToInt32(textBox18.Text) + ders4 * Convert.ToInt32(textBox24.Text) +
                ders5 * Convert.ToInt32(textBox30.Text) + ders6 * Convert.ToInt32(textBox36.Text) +
                ders7 * Convert.ToInt32(textBox42.Text) + ders8 * Convert.ToInt32(textBox48.Text) +
                ders9 * Convert.ToInt32(textBox54.Text) + ders10 * Convert.ToInt32(textBox60.Text) +
                ders11 * Convert.ToInt32(textBox66.Text) + ders12 * Convert.ToInt32(textBox72.Text))/top_ders;
            label22.Text = agirlikli_ort.ToString();
        }
    }
}
