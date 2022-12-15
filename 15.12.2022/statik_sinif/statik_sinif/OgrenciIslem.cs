using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statik_sinif
{
    public class OgrenciIslem
    {
        public List<Ogrenci> ogrenciler;
        public static int OgrenciSayisi { get; set; }

        static OgrenciIslem()
        {
            OgrenciSayisi = 0;
            Console.WriteLine("Statik yapıcı çalıştı");
        }

        public OgrenciIslem()
        {
            ogrenciler = new List<Ogrenci>();
            Console.WriteLine("Yapıcı çalıştı");
        }

        public void OgrenciEkle(Ogrenci ogr)
        {
            ogrenciler.Add(ogr);
            OgrenciSayisi++;
            Console.WriteLine("Öğrenci ekleme işlemi gerçekleşti");
        }

        public void OgrenciSil(int numara)
        {var ogr=ogrenciler.FirstOrDefault(x=>x.Numara==numara);
            if(ogr!=null)
            {
                ogrenciler.Remove(ogr);
                OgrenciSayisi--;
                Console.WriteLine("Öğrenci silindi :;");
            }


        }

    }
}
