using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_156
{
    class Class1
    {
        public double  MyMethod(int x, int y = 0)
        {
            double total = (x * 1) + (y * 2);
            return total;
        }
    }
}
