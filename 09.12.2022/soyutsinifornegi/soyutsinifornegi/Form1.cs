using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soyutsinifornegi
{
    public partial class Form1 : Form
    {   otomobil Hazali_ezen=new otomobil();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hazali_ezen.marka = comboBox1.SelectedIndex.ToString();
            Hazali_ezen.model= comboBox2.SelectedIndex.ToString();
            Hazali_ezen.ModelYili=Convert.ToInt32(comboBox3.SelectedIndex.ToString());
            Hazali_ezen.MotorHacmi=Convert.ToInt32(comboBox4.SelectedIndex.ToString());
            Hazali_ezen.OtomatikVites = checkBox1.Checked;
            MessageBox.Show(Hazali_ezen.marka + "-" + Hazali_ezen + "-"
                +Hazali_ezen.ModelYili+"-"+Hazali_ezen.MotorHacmi);
            if (Hazali_ezen.OtomatikVites)
            {
                MessageBox.Show("ARAÇ OTOMATİK");
             }
            else
            {
                MessageBox.Show("ARAÇ MANUEL");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hazali_ezen.Calis();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hazali_ezen.dur();
        }
    }
}
