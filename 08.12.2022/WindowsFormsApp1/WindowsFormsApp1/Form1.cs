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
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenci yeni_ogrenci = new ogrenci();
            yeni_ogrenci.ad = textBox1.Text;
            yeni_ogrenci.soyad = textBox2.Text;
            yeni_ogrenci.yas = Convert.ToByte(textBox3.Text);
            yeni_ogrenci.kilo = Convert.ToByte(textBox4.Text);
            yeni_ogrenci.Anne_Adi = textBox5.Text;
            yeni_ogrenci.Baba_Adi= textBox6.Text;
            yeni_ogrenci.cinsiyet=comboBox1.SelectedItem.ToString();
            yeni_ogrenci.tcno = textBox7.Text;
            yeni_ogrenci.not_ortalaması=Convert.ToByte(textBox8.Text);
            yeni_ogrenci.sinifi=comboBox3.SelectedItem.ToString();
            yeni_ogrenci.yabanci_dili=textBox10.Text;
            yeni_ogrenci.hobisi=comboBox2.SelectedIndex.ToString();
            MessageBox.Show("adı: " + yeni_ogrenci.ad);
            MessageBox.Show("soyadı: " + yeni_ogrenci.soyad);
            MessageBox.Show("yaşı: " + yeni_ogrenci.yas.ToString());
            MessageBox.Show("Kilosu: " + yeni_ogrenci.kilo.ToString());
            MessageBox.Show("Anne adı: " + yeni_ogrenci.Anne_Adi);
            MessageBox.Show("Baba adı: " + yeni_ogrenci.Baba_Adi);
            MessageBox.Show("Cinsiyeti: " + yeni_ogrenci.cinsiyet);
            MessageBox.Show("TC NUMARASI: " + yeni_ogrenci.tcno);
            MessageBox.Show("Ortalama: " + yeni_ogrenci.not_ortalaması.ToString());
            MessageBox.Show("Sınıfı: " + yeni_ogrenci.sinifi);
            MessageBox.Show("Yabancı dili: " + yeni_ogrenci.yabanci_dili);
            MessageBox.Show("Hobisi: " + yeni_ogrenci.hobisi);

        }
    }
}
