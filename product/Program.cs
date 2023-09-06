using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int int1 = 1;
            int int2 = 1;
            int int3 = 1;
            int int4 = 1;
            int result = 0;

            Console.WriteLine("Please enter a number: ");
            int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number: ");
            int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a third number: ");
            int3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a fourth number: ");
            int4 = Convert.ToInt32(Console.ReadLine());

            result = int1 * int2 * int3 * int4;

            Console.WriteLine("The product of " + int1 + " * " + int2 + " * " + int3 + " * " + int4 + " is " + result);

        }
    }
}
