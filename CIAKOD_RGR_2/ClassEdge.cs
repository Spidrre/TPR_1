using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_1
{
    public class Edge
    {
        public Vertex FirstPoint { get; private set; }
        public Vertex SecondPoint { get; private set; }
        public int Weight { get; set; }
        public int rflow { get; set; }
        public bool metka { get; set; }

        public Edge(Vertex first, Vertex second, int val)
        {
            FirstPoint = first;
            SecondPoint = second;
            Weight = val;
            rflow = 0;
            metka = false;
        }

        public void newWeight(int val)
        {
            Weight = val;
        }
    }
}
