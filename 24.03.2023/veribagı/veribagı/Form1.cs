using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace veribagı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList kaynakveri=new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            kitap yeni_kitap=new kitap();
            yeni_kitap.yazar_adi = textBox1.Text;
            yeni_kitap.kitap_adi = textBox2.Text;
            yeni_kitap.kitap_turu = comboBox1.SelectedItem.ToString();
            yeni_kitap.basim_yili=dateTimePicker1.Value.ToString();
            yeni_kitap.sayfa_sayisi = maskedTextBox1.Text;
            kaynakveri.Add(yeni_kitap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kaynakveri;
          }
    }
}
