using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kup
{
    internal class kup
    {
        int kenar;
        public kup(int kenar)
        { this.kenar = kenar;}
        public int cevre()
        {

            return kenar * 14;
        }
        public int alan()
        {
            return 6 * kenar * kenar;
        }
        public int hacim()
        { return kenar * kenar * kenar; }
    }
}
