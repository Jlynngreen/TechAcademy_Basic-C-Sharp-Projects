using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_181
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string> { "coffee", "paper", "pencil" };
            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int> { 10, 20, 30, 40 };

            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
                
            }
            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);

            }

            Console.ReadLine();
        }
    }
}
