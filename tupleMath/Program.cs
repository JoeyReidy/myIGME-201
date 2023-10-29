using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tupleMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<(double, double, double), double> formula = new SortedList<(double, double, double), double>();
            double z;
            for (double w = -2; w <= 0; w = w + 0.2)
            {
                for(double y = -1; y<= 1; y = y + 0.1)
                {
                    for(double x = 0; x <= 4; x = x + 0.1)
                    {
                        z = (4 * Math.Pow(y, 3)) + (2 * Math.Pow(x, 2)) - 8 * w + 7;
                        z = Math.Round(z, 3);
                        formula.Add((w, x, y), z);
                        
                    }
                }
            }
        }
    }
}
