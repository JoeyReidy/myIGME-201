using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    internal class Program
    {
        static bool GiveRaise(string name, ref double salary)
        {
            if (name == "Joey")
            {
                Console.WriteLine("Congratulations! You got a raise!");
                salary += 19999.99;
                return true;
                
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            Console.WriteLine("Please enter your name: ");
            sName = Console.ReadLine();
            GiveRaise(sName, ref dSalary);
            Console.WriteLine("Your salary is now $" + dSalary);
        }
    }
}
