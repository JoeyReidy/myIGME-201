using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundDelegate
{
    internal class Program
    {
        delegate double roundDelegate(double num, int roundBy);
        static void Main(string[] args)
        {
            roundDelegate round = Math.Round;

            double result = round(15.867, 2);
            Console.WriteLine(result);
        }
    }
}
