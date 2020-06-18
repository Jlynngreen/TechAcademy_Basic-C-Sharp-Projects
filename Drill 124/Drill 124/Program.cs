using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_124
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a Number?");
            int Number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = Number == 88;

            do
            {
                switch (Number)
                {
                    case 42:
                        Console.WriteLine("You guessed 42. Try again.");
                        Console.WriteLine("Guess a Number?");
                        Number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 33:
                        Console.WriteLine("You guessed 33. Try again.");
                        Console.WriteLine("Guess a Number?");
                        Number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 88:
                        Console.WriteLine("you guessed the Number 88. That is correct!");
                        isGuessed = true;
                        break;
                }
            }
            while (!isGuessed);
            
             Console.ReadLine();
        }
    }
}
