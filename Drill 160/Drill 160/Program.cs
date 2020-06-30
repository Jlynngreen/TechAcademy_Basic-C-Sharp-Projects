using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_160
{
    class Program
    {
      
            static void Main(string[] args)
            {
                //Class1 div = new Class1();

                Console.WriteLine("Please enter a number");
                int user = Convert.ToInt32(Console.ReadLine());
                Class1.MyMethod(user);
                Console.WriteLine("Please enter another number");
                int user2 = Convert.ToInt32(Console.ReadLine());
                int num;
                Class1.MyMethod(user2, out num);
                Console.WriteLine("your results:" + num);

                Console.ReadLine();
            }
        }
    }

 