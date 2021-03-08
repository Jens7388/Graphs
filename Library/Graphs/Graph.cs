using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Graphs
{
    public abstract class Graph<T>
    {
        protected List<Vertex<T>> _vertices;

        public virtual List<Vertex<T>> Vertices
        {
            get
            {
                return _vertices;
            }
            set
            {
                _vertices = value;
            }
        }

        public virtual string DepthFirstSearch(Vertex<T> root)
        {
            string toReturn = "";
            if(!root.Visited)
            {
                toReturn += root + "\n";
                root.Visited = true;

                foreach(Vertex<T> neighbor in root.Neighbors)
                {
                    toReturn += DepthFirstSearch(neighbor);
                }

            }
            return toReturn;
        }

        public virtual string BreadthFirstSearch(Vertex<T> root)
        {
            string toReturn = "";
            Queue<Vertex<T>> queue = new Queue<Vertex<T>>();

            root.Visited = true;
            toReturn += root + "\n";
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                Vertex<T> current = queue.Dequeue();
                foreach(Vertex<T> neighbor in current.Neighbors)
                {
                    if(!neighbor.Visited)
                    {
                        toReturn += neighbor + "\n";
                        neighbor.Visited = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }
            return toReturn;
        }
    }
}
