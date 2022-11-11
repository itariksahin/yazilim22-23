using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dortislem
{
    internal class Dortislem
    {
        double a, b;
        public  Dortislem(double a,double b)
        { 
        this.a = a;
        this.b = b;
        }
        public double topla()
        {
            return a + b;

        }
        public double cıkart()
        {
            return a - b;
        }
        public double carp()
        {
            return a * b;
        }
        public double bol()
        {
            return a / b;
        }
    }
}
