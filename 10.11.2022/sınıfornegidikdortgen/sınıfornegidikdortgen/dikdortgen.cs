using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıfornegidikdortgen
{
    internal class dikdortgen
    {
        private int kenar1, kenar2;
        public dikdortgen(int kenar1, int kenar2)
        { 
        this.kenar1 = kenar1;
        this.kenar2 = kenar2;
        }
        public int AlanHesap()
        {
            int alan = kenar1 * kenar2;
            return alan;
        }
        public int Cevrehesap()
        {
            int cevre = 2 * (kenar1 + kenar2);
            return cevre;
        }
    }
}
