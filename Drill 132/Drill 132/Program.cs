using System;
using System.Collections.Generic;


namespace Drill_132
{
    class Program
    {
        static void Main()
        {

            // 1. Create a one-dimensional Array of strings. Ask the user to select an index of the Array
            // and then display the string at that index on the screen.
            string[] color = new string[] { "brown", "red", "yellow", "black", "blue", "Green" };

            Console.WriteLine("select a number between 0 through 5.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput <= 5 && userInput >= 0)
            {
                Console.WriteLine(color[userInput]);
            } else
            {
                Console.WriteLine("doesn't exist");
            }

            

            

            // 2. Create a one-dimensional Array of integers. Ask the user to select an index of the Array 
            // and then display the integer at that index on the screen.


            

            int[] numArray1 = new int[] { 20, 7, 12, 20, 55, 2 };

            Console.WriteLine("select a number between 0 through 5.");
            int CustInput = Convert.ToInt32(Console.ReadLine());
            if (CustInput <= 5 && CustInput >= 0)
            {
                Console.WriteLine(numArray1[CustInput]);
            }
            else
            {
                Console.WriteLine("doesn't exist");
            }


            List<string> intList = new List<string>();
            intList.Add("Purple");
            intList.Add("Yellow");
            intList.Add("Pink");
            Console.WriteLine("select a number between 0 through 3.");
            int List = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intList[List]);
            Console.ReadLine();
        }
    }
}
