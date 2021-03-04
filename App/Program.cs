using Library;

using System;

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

            kastrup.AddNeighbor(tirstrup);
            kastrup.AddNeighbor(ronne);
            kastrup.AddNeighbor(aalborg);
            kastrup.AddNeighbor(billund);

            aalborg.AddNeighbor(ronne);
            aalborg.AddNeighbor(billund);
            aalborg.AddNeighbor(odense);

            Console.WriteLine(kastrup.Print(kastrup));
        }
    }
}
