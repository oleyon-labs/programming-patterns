using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPattern
{
    internal abstract class GraphExplorer
    {
        protected int[][] adjList;
        protected bool[] visited;
        

        public GraphExplorer(int[][] list)
        {
            adjList = list;
            visited = new bool[list.Length];
        }

        public abstract void StartOfTheCrawl(int node);
        public abstract void EndOfTheTour();
        public abstract void VisitNodeV();
        
        public abstract bool IsAllVisited();

        public void Search(int node)
        {
            StartOfTheCrawl(node);

            while(!IsAllVisited())
            {
                VisitNodeV();
            }

            EndOfTheTour();
        }
    }
}
