using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mesajkutulari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sadece mesaj verir.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
          DialogResult yanit= MessageBox.Show("Utkan şu anda çalıştırılamıyor"," ",MessageBoxButtons.AbortRetryIgnore);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Nuri çalıştırılamıyor", "Yenide dene", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                MessageBox.Show("Çalıştırılamadı");
            }
            else if(cevap == DialogResult.No)
            {

                MessageBox.Show("Sistem durduruldu");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Köpekler sevilemedi", "", MessageBoxButtons.RetryCancel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Köpekler sevilemedi", "", MessageBoxButtons.YesNoCancel);
            if (cevap == DialogResult.Yes)
            {
                MessageBox.Show("evet tıklandı");

            }
            else if (cevap == DialogResult.No)
            {
                MessageBox.Show("hayır tıklandı");
            }
            else if(cevap == DialogResult.Cancel)
            {

                MessageBox.Show("iptal tıklandı");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Dosya çalıştırılamadı", "", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Dosya çalıştırılamadı", "", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Dosya çalıştırılamadı", "", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Hazaldan tiksinir misin?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                MessageBox.Show("Tiksinme yazık kıza onunda bir teneffüste yanına koştuğu var");
            }
            else if(cevap == DialogResult.No)
            {
                MessageBox.Show("Midesiz");

            }
        }
    }
}
