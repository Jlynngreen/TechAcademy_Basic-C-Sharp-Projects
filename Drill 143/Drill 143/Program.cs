using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Drill_143
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 10 };
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                foreach (int num in intList)

                    Console.WriteLine(num / numberOne);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            { 
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
           
        }
    }
}   










// 1. Create a list of integers. Ask the user for a number to divide each number in the list by. 
// Write a loop that takes each integer in the list, divides it by the number the user entered, 
// and displays the result to the screen.

// 2. Run that code, entering in non-zero numbers as the user.Look at the displayed results.

// 3. Run that code, entering in zero as the number to divide by.Note any error messages you get.

// 4. Run that code, entering in a string as the number to divide by.Note any error messages you get.

// 5. Now put the loop in a try/catch block.Below and outside of the try/catch block, 
//  make the program print a message to the display to let you know the program has emerged from the 
// try/catch block and continued on with program execution.In the catch block, display the error message to the screen.
// Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after the 
//   try/catch block gets executed.