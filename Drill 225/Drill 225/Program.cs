using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Drill_225
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age.");
                int age = Convert.ToInt32(Console.ReadLine());
                   
                if (age < 0)
                {
                    throw new AgeException();
                }
                if (age == 0)
                {
                    throw new AgeException();
                }

                else
                {
                    Console.WriteLine("Year you were born in: " + DateTime.Now.AddYears(-age).Year);
                    Console.ReadLine();
                }   
            }
            catch (AgeException e)
            {
                Console.WriteLine("AgeIsNegativeException: {0}", e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid age.");
            }
            Console.ReadLine();
        }
    }
}
