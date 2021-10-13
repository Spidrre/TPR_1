using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_1
{
    public class Vertex
    {
        public string Name { get; }
        public List<Vertex> adjacentVertexes { get; }
        public bool isChecked { get; set; }
        public Vertex predPoint { get; set; }
        public int MetkaVal { get; set; }
        public int D { get; set; }

        public Vertex(string name)
        {
            Name = name;
            adjacentVertexes = new List<Vertex>();
            isChecked = false;
            MetkaVal = 65536;
            D = 0;
        }

        public Vertex AddChildren(Vertex Point, bool bidirect = true)
        {
            adjacentVertexes.Add(Point);
            if (bidirect)
            {
                Point.adjacentVertexes.Add(this);
            }
            return this;
        }

        public void RemoveAdjacent(Vertex v)
        {
            adjacentVertexes.Remove(v);
            //n.Children.Remove(this);
        }
    }
}

