using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_155
{
    class Class1
    {
        
        public int Sum(int x)
        {

            int result = x + 35;

            return result;
        }
        public int Sum(decimal x)
        {

            int result = (int)(x - 98.5m);

            return result;
        }


        public int Sum(string x)
        {
            int myNum = Int32.Parse(x);
            int result = myNum + 15;
            return result;
        }
    }
}