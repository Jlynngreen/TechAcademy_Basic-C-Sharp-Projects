using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_101
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ages = Convert.ToInt32(age);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? please enter true or false");
            bool trueOrfalse = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool qual = (ages >= 15 && trueOrfalse == false && tickets <= 3);
            Console.WriteLine(qual);
            Console.ReadLine();

        }
    }
}
