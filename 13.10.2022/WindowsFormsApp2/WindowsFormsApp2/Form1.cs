using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "A": MessageBox.Show("A harfi 1. harftir"); break;
                case "B": MessageBox.Show("B harfi 2. harftir"); break;
                case "C": MessageBox.Show("C harfi 3. harftir"); break;
                case "Ç": MessageBox.Show("Ç harfi 4. harftir"); break;
                case "D": MessageBox.Show("D harfi 5. harftir"); break;
                case "E": MessageBox.Show("E harfi 6. harftir"); break;
                case "F": MessageBox.Show("F harfi 7. harftir"); break;
                case "G": MessageBox.Show("G harfi 8. harftir"); break;
                case "Ğ": MessageBox.Show("Ğ harfi 9. harftir"); break;
                case "H": MessageBox.Show("H harfi 10. harftir"); break;
                case "I": MessageBox.Show("I harfi 11. harftir"); break;
                case "İ": MessageBox.Show("İ harfi 12. harftir"); break;
                case "J": MessageBox.Show("J harfi 13. harftir"); break;
                case "K": MessageBox.Show("K harfi 14. harftir"); break;
                case "L": MessageBox.Show("L harfi 15. harftir"); break;
                case "M": MessageBox.Show("M harfi 16. harftir"); break;
                case "N": MessageBox.Show("N harfi 17. harftir"); break;
                case "O": MessageBox.Show("O harfi 18. harftir"); break;
                case "Ö": MessageBox.Show("Ö harfi 19. harftir"); break;
                case "P": MessageBox.Show("P harfi 20. harftir"); break;
                case "R": MessageBox.Show("R harfi 21. harftir"); break;
                case "S": MessageBox.Show("S harfi 22. harftir"); break;
                case "Ş": MessageBox.Show("Ş harfi 23. harftir"); break;
                case "T": MessageBox.Show("T harfi 24. harftir"); break;
                case "U": MessageBox.Show("U harfi 25. harftir"); break;
                case "Ü": MessageBox.Show("Ü harfi 26. harftir"); break;
                case "V": MessageBox.Show("V harfi 27. harftir"); break;
                case "Y": MessageBox.Show("Y harfi 28. harftir"); break;
                case "Z": MessageBox.Show("Z harfi 29. harftir"); break;
            }    
        }
    }
}
