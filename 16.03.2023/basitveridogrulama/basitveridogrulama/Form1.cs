using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basitveridogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("Kullanıcı adı boş olamaz");
            else if (string.IsNullOrEmpty(textBox2.Text))
                MessageBox.Show("şifre girmediniz");
            else if (string.IsNullOrEmpty(textBox3.Text))
                MessageBox.Show("Kullanıcı kodu gereklidir");
            else if (textBox1.Text !="utkan")
                MessageBox.Show("Kullanıcı adı hatalı");
            else if (textBox2.Text !="nuri")
                MessageBox.Show("Girilen şifre hatalı");
            else if (textBox3.Text != "123456")
                MessageBox.Show("KOd hatalı");
            else
            {
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                Form2 form2=new Form2();
                form2.ShowDialog();
                
            }

        }
    }
}
