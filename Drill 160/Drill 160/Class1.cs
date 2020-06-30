using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_160
{
     static class Class1
    {
        public static void MyMethod(int x)
        {
            int div = x / 2;
            Console.WriteLine("results:" + div);

            
        }
        public static void MyMethod(int x, out int div)
        {
            div = x * 2;
            

        }
    }
}