using Library.Graphs;

using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class UndirectedGraph<T> : Graph<T>
    {  
        public UndirectedGraph()
        {

        }

        public UndirectedGraph(List<Vertex<T>> vertices)
        {
            _vertices = vertices;
        }   
    }
}
