using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;

namespace Drill_138
{
    class Program
    {
        static void Main(string[] args)

        // 1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each string in the Array, adding the user’s text to the string. 
        //Then create a loop that prints off each string in the Array on a separate line.
        {
            string[] colors = { "blue", "green", "yellow", "black" };
            Console.WriteLine("Please Write some text");
            string input = Console.ReadLine();

            for (int b = 0; b < colors.Length; b++)
            {
                Console.WriteLine(colors[b] + " " + input);
            }

            for (int b = 0; b < colors.Length; b++)
            {
                Console.WriteLine(colors[b]);

            }


            // 2. Create an infinite loop.


            //int i = 1;

            //while (i <= 10)
            //{

            //    Console.WriteLine("variable i is equal to : " + i);

            //}


            // 3. Fix the infinite loop so it will execute.

            int i = 1;

            while (i <= 10)
            {

                Console.WriteLine("variable i is equal to : " + i);
                i++;

            }


            // 4. Create a loop where the comparison used to determine
            //whether to continue iterating the loop is a “<” operator.

            List<int> testScores = new List<int>();
            testScores.Add(98);
            testScores.Add(75);
            testScores.Add(88);
            testScores.Add(55);
            testScores.Add(65);

            foreach (int score in testScores)
            {
                if (score < 75)
                {
                    Console.WriteLine("Falling test score:" + score);
                }
            }

            // 5. Create a loop where the comparison used 
            // to determine whether to continue iterating the loop is a “<=” operator.

            List<int> testScore = new List<int>();
            testScore.Add(98);
            testScore.Add(75);
            testScore.Add(88);
            testScore.Add(55);
            testScore.Add(65);

            foreach (int scores in testScore)
            {
                if (scores <= 75)
                {
                    Console.WriteLine("Falling test score:" + scores);
                }
            }

            // 6. Create a List of strings where each item in the list is unique. Ask the user to input text to search for in the List.
            //Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.

            List<string> shapes = new List<string>();
            Console.WriteLine("Pick a shape");
            string user = (Console.ReadLine());
            shapes.Add("circle");
            shapes.Add("square");
            shapes.Add("rectangle");
            shapes.Add("triangle");

            for (int b = 0; b < shapes.Count; b++)
            {

                if (user == shapes[b])
                {


                    Console.WriteLine("this shape is located at index:" + b);
                    break;

                }
                else
                {        // 7.  Add code to that above loop that tells a user 
                         // if they put in text that isn’t in the List.

                    Console.WriteLine("that shape is not on the list");
                    Console.WriteLine("your input was:" + user);

                    // 8. Add code to that above loop that stops it from executing once a match has been found.
                }

            }
            // 9. Create a List of strings that has at least two identical strings in the List. 
            //Ask the user to select text to search for in the List. 
            // Create a loop that iterates through the loop 
            //and then displays the indices of the array that contain matching text on the screen. 

            List<string> cars = new List<string>();
            Console.WriteLine("Pick a car");
            string customer = Console.ReadLine();
            cars.Add("truck");
            cars.Add("jeep");
            cars.Add("truck");
            cars.Add("4-wheeler");

            for (int j = 0; j < cars.Count; j++)
            {

                if (customer == cars[j])
                {


                    Console.WriteLine("this car is located at index:" + j);

                }
                
                if (!cars.Contains(customer))
                {
                    Console.WriteLine(customer + " is not found in the list.");
                    break;
                }
                    // 10. Add code to that above loop that tells a user if
                    // they put in text that isn’t in the List.
;

            }

            // 11. Create a List of strings that has at least two identical strings in the List. 
            // Create a foreach loop that evaluates each item in the list, 
            //and displays a message showing the string and whether 
            // or not it has already appeared in the list.

            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Watermelon");
            fruits.Add("Apple");
            fruits.Add("Banana");

            List<string> fruits2 = new List<string>();

            for (int F = 0; F < fruits.Count; F++)
            {
                if (fruits2.Contains(fruits[F]))
                {
                    Console.WriteLine(fruits[F] + "has already been mentioned.");

                }
                else
                {
                    Console.WriteLine(fruits[F]);
                    fruits2.Add(fruits[F]);
                }
                

            }

            Console.ReadLine();
        }
    }
}