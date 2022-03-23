using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPattern
{
    internal class Graph
    {
        int[][] adjList;
        bool [] visited;

        public Graph(int[][] list)
        {
            adjList = list;
            visited = new bool[list.Length];
        }

        void DFS(int vertex, int depth = 0)
        {
            visited[vertex] = true;
            Print(vertex, depth);
            int[] connectedVertices = adjList[vertex];
            for (int i = 0; i < connectedVertices.Length; i++)
            {
                if (!visited[connectedVertices[i]])
                {
                    DFS(connectedVertices[i], depth+1);
                }
            }
        }

        public void BFS(int vertex)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(vertex);
            visited[vertex] = true;

            _BFS(queue);
        }
        void _BFS(Queue<int> queue, int depth = 0)
        {
            int count = queue.Count;
            
            for (int i = 0; i < count; i++)
            {
                int vertex = queue.Dequeue();
                
                int[] connectedVertices = adjList[vertex];
                for (int j = 0; j < connectedVertices.Length; j++)
                {
                    int newV = connectedVertices[i];
                    if (!visited[newV])
                    {
                        
                        queue.Enqueue(newV);
                        visited[vertex] = true;
                        Print(vertex, depth);
                    }
                }
            }

            if(queue.Count > 0)
            {
                _BFS(queue, depth+1);
            }


            
        }



        void Print(int vertex, int depth)
        {

        }
    }
}
