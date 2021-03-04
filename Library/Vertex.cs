using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Vertex<T>: Node<T>
    {
        protected bool visited;
        protected List<Vertex<T>> neighbors;

        public Vertex(T item){
            _item = item;
            neighbors = new();
        }

        public virtual void AddNeighbor(Vertex<T> neighbor)
        {
            Neighbors.Add(neighbor);
            neighbor.Neighbors.Add(this);
        }

        public virtual bool HasNeighbor(Vertex<T> neighbor)
        {
            if(neighbors.Contains(neighbor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Vertex<T>> Neighbors
        {
            get
            {
                return neighbors;
            }
            set
            {
                neighbors = value;
            }
        }

        public bool Visited
        {
            get
            {
                return visited;
            }
            set
            {
                visited = value;
            }
        }

        public virtual string Print(Vertex<T> vertex)
        {
            string toReturn = vertex.ToString() + ": \n";
            if(vertex.neighbors != null)
            {
                foreach(Vertex<T> neighbor in vertex.Neighbors)
                {
                    toReturn += neighbor + "\n";
                }
                return toReturn;
            }
            else
            {
                return toReturn;
            }
        }
    }
}
