using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    internal class Program
    {
        delegate string Input();
        static void Main(string[] args)
        {
            Input input = Console.ReadLine;
            Console.WriteLine("write something really cool: ");

            string line = input();

            Console.WriteLine(line);

        }
    }
}
