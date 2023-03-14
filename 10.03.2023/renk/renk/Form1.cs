using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yAZIRENGİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog renk=new ColorDialog(); ;
            if(renk.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.ForeColor=renk.Color;
            }
        }

        private void yAZIARKAPLANRENGİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog renk = new ColorDialog(); ;
            if (renk.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor=renk.Color;
            }
        }

        private void aRKAPLANRENGİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog renk = new ColorDialog(); ;
            if (renk.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = renk.Color;   
            }
        }
    }
}
