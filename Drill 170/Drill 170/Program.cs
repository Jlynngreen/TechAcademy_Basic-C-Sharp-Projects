using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_170
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.firstName = "Sample";
            employee1.lastName = "Student";
            employee1.SayName();

            IQuittable mark = new Employee();
            mark.Quit();

            employee1.Id = 1;
            Employee holden = new Employee();
            holden.Id = 2;
            holden.firstName = "holden";
            holden.lastName = "wiese";

            Console.WriteLine(holden == employee1);

            Console.ReadLine();
        }
    }
}
