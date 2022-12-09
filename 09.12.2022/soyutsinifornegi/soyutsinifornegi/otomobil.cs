using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soyutsinifornegi
{
    public class otomobil:MotorluArac
    {
        public Boolean OtomatikVites { get; set; }

        public override string Calis()
        {
            return  marka + " marka " + model + " model " + "Araç ÇAlıştı";
        }
        public override string dur()
        {
            return marka + " marka " + model + " model " + "Araç durdu";
        }


    }
}
