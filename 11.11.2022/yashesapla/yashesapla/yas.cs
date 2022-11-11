using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yashesapla
{
    internal class yas
    {
        int ay, gun, yil;
        public yas(int gun,int ay,int yil)
        {
            this.gun = gun;
            this.ay = ay;
            this.yil = yil;
        }
        public int yasbul()
        {
            DateTime dogum_gunu = new DateTime(yil,ay,gun);
            DateTime bugun = DateTime.Today;
            int yas =bugun.Year - dogum_gunu.Year;
            return yas;

        }
    }
}
