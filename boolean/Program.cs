using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1 = 0;
            int var2 = 0;
            while (true)
            {
                

                Console.WriteLine("Please enter two numbers, with at least one being less than 10:");
                var1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pease enter another number:");
                var2 = Convert.ToInt32(Console.ReadLine());

                bool op1 = (var1 < 10);
                bool op2 = (var2 < 10);

                if ((op1 == true) || (op2 == true))
                {
                    Console.WriteLine("Good job!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again.");
                }
            }
           
        }
    }
}
