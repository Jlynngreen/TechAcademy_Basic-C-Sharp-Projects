using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_221
{
    class Class1
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        
        public Class1 ( int first, int second)
        {
            num1 = first;
            num2 = second;
        }
        public Class1(int first): this (first, 4)
        {

        }
        public int Substraction()
        {
            return num1 - num2;
        }
    }
}
