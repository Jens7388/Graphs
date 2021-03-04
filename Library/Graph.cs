using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Graph<T>
    {
        protected List<Vertex<T>> _vertices;

        public Graph()
        {

        }

        public Graph(List<Vertex<T>> vertices)
        {
            _vertices = vertices;
        }

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

        public string DepthFirstSearch(Vertex<T> root)
        {
            string toReturn ="";
            if(!root.Visited)
            {
                toReturn += root + "\n";
                root.Visited = true;

                foreach(Vertex<T> neighbor in root.Neighbors)
                {
                   toReturn += DepthFirstSearch(neighbor);
                }
                return toReturn;
            }
            else
            {
                return "";
            }
        }

    }
}
