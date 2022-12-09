using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soyutsinifornegi
{
    public abstract class MotorluArac
    {
        public int MotorHacmi { get; set; }
        public int ModelYili { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public abstract string Calis();
        public abstract string dur();
    }
}
