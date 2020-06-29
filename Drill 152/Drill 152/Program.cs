using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Drill_152
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            Class1 mathclass = new Class1();
            Console.WriteLine(mathclass.Sum(num));

            Class1 mathclass1 = new Class1();
            Console.WriteLine(mathclass1.Substraction(num));

            Class1 mathclass2 = new Class1();
            Console.WriteLine(mathclass2.division(num));

            Console.ReadLine();
        }
    }

}