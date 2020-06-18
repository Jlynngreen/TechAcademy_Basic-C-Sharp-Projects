using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int packageweight = Convert.ToInt32(Console.ReadLine());

            if (packageweight >= 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            Console.WriteLine("user please input the package width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("user please input the package height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("user please input the package lenght:");
            int length = Convert.ToInt32(Console.ReadLine());

            if (width + height + length >= 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            Console.WriteLine("Estimated total to ship this package.");
            int quote = (width * height * length * packageweight / 100);
            

            Console.WriteLine("Your Estimated total is: $" +  quote);

            Console.WriteLine("Thank You");
            Console.ReadLine();

        }
    }
}

