using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string:");
            string input = Console.ReadLine();
            string output = "";
            
            string[] tokens = input.Split(' ');
            foreach (string token in tokens)
            {
                output = output + "\"" + token + "\" ";
            }
            output = output + "\b";
            Console.WriteLine(output);
        }
    }
}
