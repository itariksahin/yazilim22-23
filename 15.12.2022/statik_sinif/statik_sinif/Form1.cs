using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statik_sinif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OgrenciIslem oi=new OgrenciIslem();
        private void button1_Click(object sender, EventArgs e)
        {
            oi.OgrenciEkle(new Ogrenci 
            {Numara=Convert.ToInt32(textBox1.Text),AdSoyad=textBox2.Text });
            MessageBox.Show("Öğrenci sayısı="+OgrenciIslem.OgrenciSayisi.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
        oi.OgrenciSil(Convert.ToInt32(textBox1.Text));
         MessageBox.Show("Öğrenci sayısı=" + OgrenciIslem.OgrenciSayisi.ToString());
        }
    }
}
