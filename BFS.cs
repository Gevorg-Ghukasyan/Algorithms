using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSBFS
{
    static class BFS
    {
        public static HashSet<int> BreadthFirstSearch(int vertex, Dictionary<int, List<int>> graph)
        {
            HashSet<int> visited = new HashSet<int>();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(vertex);
            while (queue.Count > 0)
            {
                int currentVertex = queue.Dequeue();
                if (!visited.Contains(currentVertex))
                {
                    visited.Add(currentVertex);
                    if (graph.ContainsKey(currentVertex))
                    {
                        foreach (int neighbor in graph[currentVertex])
                        {
                            if (!visited.Contains(neighbor))
                            {
                                visited.Add(neighbor);
                                queue.Enqueue(neighbor);
                            }
                        }
                    }
                }
            }

            return visited;

        }

    }
}
