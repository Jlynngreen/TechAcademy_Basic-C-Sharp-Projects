using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_156
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 add = new Class1();
            Console.WriteLine("Input a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another number if you want to");
            try
            {
                int userInput2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(add.MyMethod(userInput, userInput2));
            }
            catch (Exception)
            {
                Console.WriteLine(add.MyMethod(userInput));

            }
            Console.ReadLine();

        }

    }

}

//1. Create a class. In that class, create a method that takes two integers as parameters.Make one of them optional.Have the method do a math operation and return an integer result.

//2. In the Main() method of the console app, instantiate the class.

//3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.

//4. Call the method in the class, passing in the one or two numbers entered.

//5. Try various combinations of numbers on the code, including having no second number.