using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPattern
{
    internal class DFSExplorer : GraphExplorer
    {
        Stack<int> stack = new Stack<int>();

        public DFSExplorer(int[][] adjList):base(adjList)
        {

        }
        public override void EndOfTheTour()
        {
            Console.WriteLine("Конец обхода DFS");
        }

        public override void StartOfTheCrawl(int node)
        {
            Console.WriteLine("Начало обхода DFS");
            visited = new bool[adjList.Length];
            visited[node] = true;
            stack.Push(node);
            VisitNodeV();
        }
        public override bool IsAllVisited()
        {
            return stack.Count == 0;
        }

        public override void VisitNodeV()
        {
            
            int node = stack.Pop();
            Console.WriteLine($"Посетили {node+1} вершину");
            int[] adjNodes = adjList[node];
            for(int i = 0; i < adjNodes.Length; i++)
            {
                if(!visited[adjNodes[i]])
                {
                    visited[adjNodes[i]] = true;
                    stack.Push(adjNodes[i]);
                }
            }

        }
    }
}
