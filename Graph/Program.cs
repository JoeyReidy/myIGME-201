using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Program
    {
        static bool[,] mGraph = new bool[,]
        {
           { false   , true    , true   , false   , false    , false   , false   , false },
           { false   , false   , false   , true    , true   , false   , false   , false },
           { false    , false   , false   , true   , false   , true   , false   , false },
           { false   , true   , true   , false   , false   , false   , false   , false },
           { false   , false   , false   , false   , false   , false   , false    , true },
           { false   , false   , false   , false   , false   , false   , true   , false },
           { false   , false   , false   , false   , true   , false   , false   , false },
           { false   , false   , false   , false   , false   , false    , false   , false }
        };

        static int[][] lraph = new int[][]
        {
            new int[] { 2, 3 },
            new int[] { 3, 4 },
            new int[] { 3, 5 },
            new int[] { 2, 1 },
            new int[] { 7 },
            new int[] { 6 },
            new int[] { 4 },
            null
        };
        static void Main(string[] args)
        {
            

        }
    }
}
