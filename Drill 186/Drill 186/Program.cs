using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_186
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("user input the current day of the week?");

            try
            {
                string userInput = Console.ReadLine();
                DaysOfTheWeek Day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), (userInput));
                Console.WriteLine("you picked the day: " + Day);
            }
            catch(Exception)
            {
                Console.WriteLine("please input actual day of the week");
            }   


            
            Console.ReadLine();
        }

    }
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }
}
