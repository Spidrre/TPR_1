using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_1
{
    public class Circle
    {
        public int X { get; }
        public int Y { get; }
        public int diam = 50;
        public bool chosen = false;

        public Circle(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool inCircle(int x, int y)
        {
            int a1 = (X - x) * (X - x);
            int a2 = (Y - y) * (Y - y);
            int a3 = diam * diam / 4;
            if ((a1 + a2) <= a3)
                chosen = !chosen;
            return ((a1 + a2) <= a3);
        }
    }
}
