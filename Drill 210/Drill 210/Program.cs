using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Drill_210
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User put in a number?");
            float text = float.Parse(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\users\black\log1.txt", true))
            {
                file.WriteLine(text);
            }

               
            Console.WriteLine(File.ReadAllText(@"C:\users\black\log1.txt"));
            Console.ReadLine();

        }
    }
}


