using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Drill_213
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("user input a number");
            int hour = Convert.ToInt32(Console.ReadLine());
            DateTime date1 = DateTime.Now;
            Console.WriteLine("the time in " + hour  + " hours will be " + date1.AddHours(hour));
           
            Console.ReadLine();
        }
    }
}
