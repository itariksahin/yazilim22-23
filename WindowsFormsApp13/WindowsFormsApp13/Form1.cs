using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red; //Yazı rengini kırmızı yapar.
            textBox1.Enabled = true; //Nesneyi pasifleştirir. Artık metin girişi yapılamaz.
            textBox1.Visible = true; //Nesneyi görünmez hâle getirir.
            textBox1.Font = new Font("Arial",16); //Yazı tipi ve boyutu değişir.
            textBox1.Text = "Hello World";
        }
    }
}
