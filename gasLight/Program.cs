using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string:");

            string input = Console.ReadLine();

            string yes = input.Replace("no", "yes");
            yes = input.Replace("No", "Yes");
            yes = yes.Replace("NO", "YES");
            yes = yes.Replace("no", "yes");
            yes = yes.Replace("nO", "YeS");

            Console.WriteLine(yes);
            
        }
    }
}
