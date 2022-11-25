using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class dikdortgen
    {
        int a;
        int b;
        public int A
        { get { return a; } 
            set { if (value <= 0)
                    Console.WriteLine("HAtalı giriş");
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
                    Console.WriteLine("HAtalı giriş");
                else
                    b = value;
            }
        }
        public int alan
        { get { return a*b; }}


    }
}
