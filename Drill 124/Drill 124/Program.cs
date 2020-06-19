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
            Console.WriteLine("Guess a color?");
            string Color = Console.ReadLine();
            bool isGuess = false;



            while (isGuess == false)
            {
                switch (Color)
                {
                    case "Green":
                        Console.WriteLine("You guessed green. Try again.");
                        Console.WriteLine("Guess a Color?");
                        Color = Console.ReadLine();
                        break;
                    case "Red":
                        Console.WriteLine("You guessed Red. Try again.");
                        Console.WriteLine("Guess a Color?");
                        Color = Console.ReadLine();
                        break;
                    case "Blue":
                        Console.WriteLine("you guessed color Blue. That is correct!");
                        isGuess = true;
                        break;
                    default:
                        Console.WriteLine("Guess a color?");
                        Color = Console.ReadLine();
                        break;
                }
            }
          
            Console.WriteLine("Guess a Number?");
            int Number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = true;

            
            do
            { 
                switch (Number)
                {
                    case 42:
                        Console.WriteLine("You guessed 42. Try again.");
                        Console.WriteLine("Guess a Number?");
                        Number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 108:
                        Console.WriteLine("You guessed 108. Try again.");
                        Console.WriteLine("Guess a Number?");
                        Number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 98:
                        Console.WriteLine("You guessed 98. Try again.");
                        Console.WriteLine("Guess a Number?");
                        Number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 33:
                        Console.WriteLine("You guessed 33. You guessed Correct.");
                        Console.WriteLine("Guess a Number?");
                        Number = Convert.ToInt32(Console.ReadLine());
                        isGuessed = true;
                        break;
                     default:
                       Console.WriteLine("Guess a numner?");
                       break;
                }
            }
            while (!isGuessed);
            
             Console.ReadLine();
        }
    }
}
