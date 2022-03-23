using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] adjList =
            {
                new int[] { 1, 3 },
                new int[] { 0, 2 },
                new int[] { 1, 3, 4 },
                new int[] { 0, 2 },
                new int[] { 2 }
            };

            DFSExplorer dFSExplorer = new DFSExplorer(adjList);
            dFSExplorer.Search(0);

            Console.WriteLine();

            BFSExplorer bFSExplorer = new BFSExplorer(adjList);
            bFSExplorer.Search(0);

        }
    }
}
