using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_1
{
    public class WeightComparer : IComparer<Edge>
    {
        public int Compare(Edge a, Edge b)
        {
            if (a.Weight > b.Weight)
            {
                return 1;
            }
            else if (a.Weight < b.Weight)
            {
                return -1;
            }

            return 0;
        }
    }
}
