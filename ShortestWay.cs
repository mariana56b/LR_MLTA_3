using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LR_MLTA_3
{
    internal class ShortestWay
    {
        private int vertices;
        private List<(int, int, int)> edges; 
        private string[] vertexNames = { "a", "b", "c", "d", "e", "f" }; 

        public ShortestWay(int v)
        {
            vertices = v;
            edges = new List<(int, int, int)>();
        }

        public void AddEdge(int from, int to, int weight)
        {
            edges.Add((from, to, weight));
        }

        public int[] Dekstra(int source)
        {
            int[] dist = Enumerable.Repeat(int.MaxValue, vertices).ToArray(); 
            bool[] visited = new bool[vertices];
            dist[source] = 0;

            for (int i = 0; i < vertices - 1; i++)
            {
                int u = MinDistance(dist, visited);
                if (u == -1) break; 
                visited[u] = true;

                foreach (var (from, to, weight) in edges)
                {
                    if (from == u && !visited[to] && dist[u] != int.MaxValue && dist[u] + weight < dist[to])
                    {
                        dist[to] = dist[u] + weight;
                    }
                }
            }

            return dist;
        }
        private int MinDistance(int[] dist, bool[] visited)
        {
            int minIndex = -1;
            int minValue = int.MaxValue;

            for (int i = 0; i < dist.Length; i++)
            {
                if (!visited[i] && dist[i] < minValue)
                {
                    minValue = dist[i];
                    minIndex = i;
                }
            }
            return minIndex; 
        }

        public string PrintDekstra(int[] dist)
        {
            var sb = new StringBuilder();
            sb.AppendLine("   Найкоротші відстані від вершини a:"); 

            for (int i = 0; i < dist.Length; i++)
            {
                if (dist[i] == int.MaxValue)
                {
                    sb.AppendLine($"   До вершини {vertexNames[i]}: недосяжно");
                }
                else
                {
                    sb.AppendLine($"   До вершини {vertexNames[i]}: {dist[i]}");
                }
            }
            return sb.ToString(); 
        }

        public int[,] Floyd()
        {
            int[,] dist = new int[vertices, vertices];

            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    dist[i, j] = i == j ? 0 : int.MaxValue;
                }
            }

            foreach (var (from, to, weight) in edges)
            {
                dist[from, to] = weight;
            }

            for (int k = 0; k < vertices; k++)
            {
                for (int i = 0; i < vertices; i++)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        if (dist[i, k] != int.MaxValue && dist[k, j] != int.MaxValue && dist[i, k] + dist[k, j] < dist[i, j])
                        {
                            dist[i, j] = dist[i, k] + dist[k, j];
                        }
                    }
                }
            }

            return dist; 
        }

        public string PrintFloyd(int[,] dist)
        {
            var sb = new StringBuilder();
            sb.Append("     "); 
            for (int i = 0; i < vertices; i++)
            {
                sb.Append($"{vertexNames[i],6}"); 
            }
            sb.AppendLine();
            for (int i = 0; i < vertices; i++)
            {
                sb.Append($"{vertexNames[i],4}  "); 
                for (int j = 0; j < vertices; j++)
                {
                    if (dist[i, j] == int.MaxValue)
                    {
                        sb.Append($"{'\u221E',5}"); 
                    }
                    else
                    {
                        sb.Append($"{dist[i, j],5}"); 
                    }
                }
                sb.AppendLine(); 
            }

            return sb.ToString();
        }
    }

}
