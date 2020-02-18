using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Sorting
{
    public class IntersectingDiscs
    {
        public static int Execute(int[] A)
        {
            var intersections = 0;
            for (var i = 0; i < A.Length; i++)
                for (var j = i + 1; j < A.Length; j++)
                {
                    if (i == j) continue;
                    if (((long)i + A[i]) >= ((long)j - A[j])) intersections++;
                    if (intersections > 10000000) return -1;
                }
            return intersections;
        }
    }
}
