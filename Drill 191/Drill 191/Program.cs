using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_191
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNum = new Number() { Amount = .25M };
            Console.WriteLine(myNum.Amount);
            Console.ReadLine();
        }
        struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
