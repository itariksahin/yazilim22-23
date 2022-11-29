using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buyukolanıbul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayiBulucu yeni_sayibul=new sayiBulucu();
            MessageBox.Show(yeni_sayibul.bul(Convert.ToInt16(textBox1.Text)
                , Convert.ToInt16(textBox2.Text)).ToString());
        }
    }
}
