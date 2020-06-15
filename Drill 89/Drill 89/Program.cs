using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_89
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("input number to multiply by 50");
            string number = Console.ReadLine();
            int numbers = Convert.ToInt32(number);
            int mult = numbers * 50;
            Console.WriteLine(mult);
            Console.ReadLine();



            Console.WriteLine("input number to add 25");
            string addition = Console.ReadLine();
            int add = Convert.ToInt32(addition);
            int adds = add + 25;
            Console.WriteLine(adds);
            Console.ReadLine();



            Console.WriteLine("input number to divided by 12.5");
            string division = Console.ReadLine();
            double quotient = Convert.ToInt32(division);
            double quo = quotient / 12.5;
            Console.WriteLine(quo);
            



            Console.WriteLine("input number greater that 50");
            string greater = Console.ReadLine();
            int great = Convert.ToInt32(greater);
            bool trueOrFalse = great > 50;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();




            Console.WriteLine("input a number that is a remainder of 7");
            string remainder = Console.ReadLine();
            int remainds = Convert.ToInt32(remainder);
            int precent = remainds % 7;
            Console.WriteLine(precent);
            Console.ReadLine();

            
        }
    }
}
