using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_155
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            Class1 mathclass = new Class1();
            Console.WriteLine(mathclass.Sum(num));

            Console.WriteLine("User input a decimal");
            decimal dec = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(mathclass.Sum(dec));

            Console.WriteLine("user put in a number");
            string word = Console.ReadLine();
            Console.WriteLine(mathclass.Sum(word));

            
            Console.ReadLine();
        }
    }
}
