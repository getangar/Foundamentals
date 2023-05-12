using System;
using System.Collections.Generic;

public class Graph
{
    private int V;
    private List<int>[] adj;

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
        adj[w].Add(v);
    }

    public void PrintGraph()
    {
        for (int i = 0; i < V; i++)
        {
            Console.Write("Vertice " + i + ": ");
            foreach (int j in adj[i])
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

public class Program
{
    public static void Main()
    {
        Graph g = new Graph(5);

        g.AddEdge(0, 1);
        g.AddEdge(0, 4);
        g.AddEdge(1, 2);
        g.AddEdge(1, 3);
        g.AddEdge(1, 4);
        g.AddEdge(2, 3);
        g.AddEdge(3, 4);

        g.PrintGraph();
    }
}
