using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_127
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "jess";
            string quote = "They said, \"Hi\", jess. \n Hi its finally the weekend. \n \t yay can't wait.";


            string author = "Robin Williams";
            Console.WriteLine(author);


            StringBuilder sb = new StringBuilder();

            sb.Append(" My name is Jess,");

            sb.AppendLine(" I Like C#!");

            sb.AppendLine("Can't wait to move out of utah one day.");

            Console.WriteLine(sb);



            Console.WriteLine(quote);
            Console.ReadLine();
        }
    }
}
