using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem)
            {
                case "1": MessageBox.Show("Adana"); break;
                case "2": MessageBox.Show("Adıyaman"); break;
                case "3": MessageBox.Show("Afyon"); break;
                case "4": MessageBox.Show("Ağrı"); break;
                case "5": MessageBox.Show("Amasya"); break;
                case "6": MessageBox.Show("Ankara"); break;
                case "7": MessageBox.Show("Antalya"); break;
                case "8": MessageBox.Show("Artvin"); break;
                case "9": MessageBox.Show("Aydın"); break;
                case "10": MessageBox.Show("Balıkesir"); break;
                case "11": MessageBox.Show("Bilecik"); break;
                case "12": MessageBox.Show("Bingöl"); break;
                case "13": MessageBox.Show("Bitlis"); break;
                case "14": MessageBox.Show("Bolu"); break;
                case "15": MessageBox.Show("Burdur"); break;
                case "16": MessageBox.Show("Bursa"); break;
                case "17": MessageBox.Show("Çanakkale"); break;
                case "18": MessageBox.Show("Çankırı"); break;
                case "19": MessageBox.Show("Çorum"); break;
                case "20": MessageBox.Show("Denizli"); break;
                case "21": MessageBox.Show("Diyarbakır"); break;
                case "22": MessageBox.Show("Edirne"); break;
                case "23": MessageBox.Show("Elazığ"); break;
                case "24": MessageBox.Show("Erzincan"); break;
                case "25": MessageBox.Show("Erzurum"); break;
                case "26": MessageBox.Show("Eskişehir"); break;
                case "27": MessageBox.Show("Gaziantep"); break;
                case "28": MessageBox.Show("Giresun"); break;
                case "29": MessageBox.Show("Gümüşhane"); break;
                case "30": MessageBox.Show("Hakkari"); break;
                case "31": MessageBox.Show("Hatay"); break;
                case "32": MessageBox.Show("Isparta"); break;
                case "33": MessageBox.Show("İçel"); break;
                case "34": MessageBox.Show("İstanbul"); break;
                case "35": MessageBox.Show("İzmir"); break;
                case "36": MessageBox.Show("Kars"); break;
                case "37": MessageBox.Show("Kastamonu"); break;
                case "38": MessageBox.Show("Kayseri"); break;
                case "39": MessageBox.Show("Kırklareli"); break;
                case "40": MessageBox.Show("Kırşehir"); break;
                case "41": MessageBox.Show("Kocaeli"); break;
                case "42": MessageBox.Show("Konya"); break;
                case "43": MessageBox.Show("Kütahya"); break;
                case "44": MessageBox.Show("Malatya"); break;
                case "45": MessageBox.Show("Manisa"); break;
                case "46": MessageBox.Show("Kahramanmaraş"); break;
                case "47": MessageBox.Show("Mardin"); break;
                case "48": MessageBox.Show("Muğla"); break;
                case "49": MessageBox.Show("Muş"); break;
                case "50": MessageBox.Show("Nevşehir"); break;
                case "51": MessageBox.Show("Niğde"); break;
                case "52": MessageBox.Show("Ordu"); break;
                case "53": MessageBox.Show("Rize"); break;
                case "54": MessageBox.Show("Sakarya"); break;
                case "55": MessageBox.Show("Samsun"); break;
                case "56": MessageBox.Show("Siirt"); break;
                case "57": MessageBox.Show("Sinop"); break;
                case "58": MessageBox.Show("Sivas"); break;
                case "59": MessageBox.Show("Tekirdağ"); break;
                case "60": MessageBox.Show("Tokat"); break;
                case "61": MessageBox.Show("Trabzon"); break;
                case "62": MessageBox.Show("Tunceli"); break;
                case "63": MessageBox.Show("Şanlıurfa"); break;
                case "64": MessageBox.Show("Uşak"); break;
                case "65": MessageBox.Show("Van"); break;
                case "66": MessageBox.Show("Yozgat"); break;
                case "67": MessageBox.Show("Zonguldak"); break;
                case "68": MessageBox.Show("Aksaray"); break;
                case "69": MessageBox.Show("Bayburt"); break;
                case "70": MessageBox.Show("Karaman"); break;
                case "71": MessageBox.Show("Kırıkkale"); break;
                case "72": MessageBox.Show("Batman"); break;
                case "73": MessageBox.Show("Şırnak"); break;
                case "74": MessageBox.Show("Bartın"); break;
                case "75": MessageBox.Show("Ardahan"); break;
                case "76": MessageBox.Show("Iğdır"); break;
                case "77": MessageBox.Show("Yalova"); break;
                case "78": MessageBox.Show("Karabük"); break;
                case "79": MessageBox.Show("Kilis"); break;
                case "80": MessageBox.Show("Osmaniye"); break;
                case "81": MessageBox.Show("Düzce"); break;
                

            }
        }
    }
}
