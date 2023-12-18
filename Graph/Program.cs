using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Program
    {
        static bool[] visited;

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

        static string[][] lGraph = new string[][]
        {
            new string[] { "grey", "cyan" },
            new string[] { "cyan", "yellow" },
            new string[] { "cyan", "orange" },
            new string[] { "grey", "blue" },
            new string[] { "green" },
            new string[] { "purple" },
            new string[] { "yellow" },
            new string[] {  },
        };
        static void Main(string[] args)
        {
            DFS();
        }

        static void DFS()
        {
            visited = new bool[lGraph.Length];

            for (int i = 0; i < lGraph.Length - 1; i++)
            {
                if (!visited[i])
                {
                    DFSUtil(i);
                }
            }
        }

        static void DFSUtil(int vertex)
        {
            visited[vertex] = true;
            Console.WriteLine(lGraph[vertex][0]);

            for (int i = 0; i < lGraph.Length - 1; i++)
            {
                if ((i < mGraph.Length) && mGraph[vertex, i] && !visited[i])
                {
                    DFSUtil(i);
                }
            }
        }
    }
}
