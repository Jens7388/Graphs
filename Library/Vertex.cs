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
        }

        public virtual void AddNeighbor(Vertex<T> neighbor)
        {
            neighbors.Add(neighbor);
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
    }
}
