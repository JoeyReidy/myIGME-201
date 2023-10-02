using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salaryStruct
{
    internal class Program
    {
        struct Employee
        {
            public string sName;
            public double dSalary;
        }

        static bool GiveRaise(ref Employee employee)
        {
            if (employee.sName == "Joey")
            {
                Console.WriteLine("Congratulations! You got a raise!");
                employee.dSalary += 19999.99;
                return true;

            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            Employee employee = new Employee();
            employee.sName = Console.ReadLine();
            employee.dSalary = 30000;
            GiveRaise(ref employee);
            Console.WriteLine("Your salary is now $" + employee.dSalary);
        }
    }
}
