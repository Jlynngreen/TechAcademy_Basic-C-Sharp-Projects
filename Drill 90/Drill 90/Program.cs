using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string Hourly = Console.ReadLine();
            int Hour = Convert.ToInt32(Hourly);

            Console.WriteLine("Hours worked per week?");
            string worked = Console.ReadLine();
            int work = Convert.ToInt32(worked);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string Hours = Console.ReadLine();
            int Hr = Convert.ToInt32(Hours);

            Console.WriteLine("Hours worked per week?");
            string Worked = Console.ReadLine();
            int works = Convert.ToInt32(Worked);

            Console.WriteLine("Annual salary of Person 1");
            int salary1 = 52 * Hour * work;
            Console.WriteLine(salary1);

            Console.WriteLine("Annual salary of Person 2");
            int salary2 = 52 * Hr * works;
            Console.WriteLine(salary2);

            Console.WriteLine("Does Person 1 make more money than Person 2? ");
            bool moreMoney = salary1>salary2;
            Console.WriteLine(moreMoney);
            Console.ReadLine();
        }
    }
}
