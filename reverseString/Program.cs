using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string:");
            string input = Console.ReadLine();
            string output = "";

            for(int i = input.Length - 1; i >= 0; i--)
            {
                output = output + input[i];
            }
            
            Console.WriteLine(output);
        }
    }
}
