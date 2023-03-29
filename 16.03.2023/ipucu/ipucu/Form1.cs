using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            ad.Text = "";
            soyad.Text = "";
            sinif.Text = "";
            yas.Text = "";
            tc.Text = "";
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ad.Text + " " + soyad.Text + " " + sinif.Text + " " + yas.Text + " " + tc.Text+" "+takim.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip kopya=new ToolTip();
            kopya.SetToolTip(ad, "Adınızı girilmelisiniz");
            kopya.SetToolTip(soyad, "Soyadınızı girmelisiniz");
            kopya.SetToolTip(yas, "Yaşınızı tam sayı olarak giriniz");
            kopya.SetToolTip(sinif, "Sınıfınızı giriniz");
            kopya.SetToolTip(tc, "11 haneli Türkiye cumhuriyeti kimlik numarası");
            kopya.SetToolTip(sil, "Formu temizler");
            kopya.SetToolTip(kaydet, "Formu kaydeder");
            kopya.SetToolTip(takim, "Taraftarı olduğunuz takımı giriniz");
        }
    }
}
