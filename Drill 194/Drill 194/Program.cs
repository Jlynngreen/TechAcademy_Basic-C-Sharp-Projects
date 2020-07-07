using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_194
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee JohnS = new Employee() { FirstName = "John", LastName = "Smith", Id = 1 };
            Employee SeanW = new Employee() { FirstName = "Sean", LastName = "Wilson", Id = 2 };
            Employee JoeM = new Employee() { FirstName = "Joe", LastName = "Morgan", Id = 3 };
            Employee KarenJ = new Employee() { FirstName = "Karen", LastName = "Johnson", Id = 4 };
            Employee BobW = new Employee() { FirstName = "Bob", LastName = "Wells", Id = 5 };
            Employee JoeC = new Employee() { FirstName = "Joe", LastName = "Clark", Id = 6 };
            Employee MorganF = new Employee() { FirstName = "Morgan", LastName = "Freedman", Id = 7 };
            Employee LukeC = new Employee() { FirstName = "Luke", LastName = "Cook", Id = 8 };
            Employee SteveG = new Employee() { FirstName = "Steve", LastName = "Gold", Id = 9 };
            Employee RickM = new Employee() { FirstName = "Rick", LastName = "Morty", Id = 10 };

            List<Employee> employees = new List<Employee>()
            {
                JohnS,
                SeanW,
                JoeM,
                KarenJ,
                BobW,
                JoeC,
                MorganF,
                LukeC,
                SteveG,
                RickM
            };

            List<Employee> joes = new List<Employee>();

            foreach (Employee employee in employees)
            {
               
                if(employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }


            List<Employee> LanJoes = new List<Employee>();

            LanJoes = employees.Where(x => x.FirstName.Contains("Joe")).ToList();

            LanJoes = employees.Where(x => x.Id > 5).ToList();


            Console.ReadLine();

        }


    }


}
