using Library;
using Library.Graphs;

using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main()
        {
            #region undirected
            /*
            Vertex<string> kastrup = new("Kastrup");
            Vertex<string> tirstrup = new("Tirstrup");
            Vertex<string> ronne = new("Ronne");
            Vertex<string> aalborg = new("Aalborg");
            Vertex<string> billund = new("Billund");
            Vertex<string> odense = new("Odense");

            kastrup.AddNeighbor(aalborg);
            kastrup.AddNeighbor(tirstrup);
            kastrup.AddNeighbor(ronne);
            kastrup.AddNeighbor(billund);

            aalborg.AddNeighbor(ronne);
            aalborg.AddNeighbor(billund);
            aalborg.AddNeighbor(odense);

            UndirectedGraph<string> graph = new(new List<Vertex<string>>() {kastrup , odense, ronne, aalborg, billund, tirstrup });
            Console.WriteLine("BFS:");
            Console.WriteLine(graph.BreadthFirstSearch(kastrup));

            foreach(Vertex<string> vertex in graph.Vertices)
            {
                vertex.Visited = false;
            }

            Console.WriteLine("DFS:");
            Console.WriteLine(graph.DepthFirstSearch(kastrup));
            */
            #endregion
            #region directed
            Vertex<string> kastrup = new("Kastrup");
            Vertex<string> tirstrup = new("Tirstrup");
            Vertex<string> ronne = new("Ronne");
            Vertex<string> aalborg = new("Aalborg");
            Vertex<string> billund = new("Billund");
            Vertex<string> odense = new("Odense");
            DirectedGraph<string, int> graph = new (new List<Vertex<string>>() { kastrup, odense, ronne, aalborg, billund, tirstrup });

            graph.AddEdge(kastrup, tirstrup, 230);
            graph.AddEdge(kastrup, ronne, 160);
            graph.AddEdge(kastrup, billund, 264);
            graph.AddEdge(kastrup, aalborg, 315);

            graph.AddEdge(aalborg, ronne, 477);
            graph.AddEdge(aalborg, billund, 178);
            graph.AddEdge(aalborg, odense, 256);

            Console.WriteLine("DFS:");
            Console.WriteLine(graph.DepthFirstSearch(kastrup));
            #endregion
        }
    }
}
