using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSBFS
{
    static class DFS
    {

        #region DFS with HashSET
        public static void DepthFirstSearchHSet(Dictionary<int, List<int>> graph, int vertex)
        {
            HashSet<int> visited = new HashSet<int>();
            DepthFirstSearchHSet(graph, vertex, visited);
        }

        public static void DepthFirstSearchHSet(Dictionary<int, List<int>> graph, int vertex, HashSet<int> visited)
        {
            visited.Add(vertex);
            Console.Write($"{vertex} ");

            foreach (int neighbor in graph[vertex])
            {
                if (!visited.Contains(neighbor))
                {
                    DepthFirstSearchHSet(graph, neighbor, visited);
                }
            }
        }
        #endregion


        public static void DepthFirstSearch(Dictionary<int, List<int>> graph, int vertex, List<bool> visited)
            {
                visited[vertex] = true;
                //        Console.WriteLine("------------------");

                foreach (int neighbor in graph[vertex])
                {
                    if (!visited[neighbor])
                    DepthFirstSearch(graph, neighbor, visited);
                }
                Console.Write($"{vertex}, ");

            }
        
    }


}