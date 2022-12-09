using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golgeleme
{
    internal class yonetim:personel
    {
        public string birim { get; set; }

        public string maasi { get; set; }

        public new string adsoyad() //New eklenerek iki sınıf arasındaki gölgeleme ortadan kaldırıldı
        {
            return Ad + " " + Soyad + " " +birim+" "+maasi;
        }
    }
}
