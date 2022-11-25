using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ucgen
    {
        int a;
        int b;
        int c;
        public int A
        {
            get { return a; }
            set {
                if (value <= 0)
                    Console.WriteLine("Hatalı giriş yapıldı");
                else
                    a = value;       
            }
        
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Hatalı giriş yapıldı");
                else
                    b = value;
            }

        }
        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Hatalı giriş yapıldı");
                else
                    c = value;
            }

        }

        public int cevre
        {
            get { return a + b + c; }
        }


    }
}
