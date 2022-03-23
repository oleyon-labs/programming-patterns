using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPattern
{
    internal class BFSExplorer : GraphExplorer
    {
        Queue<int> queue = new Queue<int>();

        public BFSExplorer(int[][] adjList) : base(adjList)
        {

        }
        public override void EndOfTheTour()
        {
            Console.WriteLine("Конец обхода BFS");
        }

        public override bool IsAllVisited()
        {
            return queue.Count == 0;
        }

        public override void StartOfTheCrawl(int node)
        {
            Console.WriteLine("Начало обхода BFS");
            visited = new bool[adjList.Length];
            visited[node] = true;
            queue.Enqueue(node);
            VisitNodeV();
        }

        public override void VisitNodeV()
        {

            int node = queue.Dequeue();
            Console.WriteLine($"Посетили {node + 1} вершину");
            int[] adjNodes = adjList[node];
            for (int i = 0; i < adjNodes.Length; i++)
            {
                if (!visited[adjNodes[i]])
                {
                    visited[adjNodes[i]] = true;
                    queue.Enqueue(adjNodes[i]);
                }
            }

        }
    }
}
