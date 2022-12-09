using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golgeleme
{
    internal class personel
    {
        public string Ad{ get; set; }
        public string Soyad { get; set; }

        public string kimlik_numarasi { get; set; }

        public string adsoyad()
        { return Ad+" " + Soyad+" " + kimlik_numarasi; }
    }
}
