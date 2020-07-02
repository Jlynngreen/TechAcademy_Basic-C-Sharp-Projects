using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_170
{
    class Employee : Person, IQuittable
    {
        public int Id{ get; set; }
        public void Quit()
        {
            Console.WriteLine("I quit");
        }
        public static bool operator == (Employee employee, Employee person)
        {
            if (employee.Id == person.Id) { return true; }
            else { return false; }
        }
        public static bool operator !=(Employee employee, Employee person)
        {
            if (employee.Id != person.Id) { return true; }
            else { return false; }
        }
    }    

}