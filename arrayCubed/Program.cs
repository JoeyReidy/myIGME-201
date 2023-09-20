using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayCubed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            z = 3y2 + 2x - 1*/
            
            
            double z;
            int xCount = 0;
            int yCount = 0;
            double[,,] array = new double[21,31, 3];


            for (double x = -1; x <=1; x = x + 0.1)
            {
                yCount = 0;
                for(double y = 1; y <= 4; y = y + 0.1)
                {
                    z = 3*(y * y) + (2*x) - 1;
                    array[xCount, yCount, 0] = x;
                    array[xCount, yCount, 1] = y;
                    array[xCount, yCount, 2] = z;

                    
                    yCount++;
                }
                xCount++;
            }
        }
    }
}
