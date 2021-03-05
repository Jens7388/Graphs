using Library;

using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main()
        {
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

            Graph<string> graph = new(new List<Vertex<string>>() {kastrup , odense, ronne, aalborg, billund, tirstrup });
            Console.WriteLine("BFS:");
            Console.WriteLine(graph.BreadthFirstSearch(kastrup));

            foreach(Vertex<string> vertex in graph.Vertices)
            {
                vertex.Visited = false;
            }

            Console.WriteLine("DFS:");
            Console.WriteLine(graph.DepthFirstSearch(kastrup));
        }
    }
}
