using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Sorting
{
    class Triangle
    {
        public static bool IsTriangular(int pth, int qth, int rth)
        {
            return pth + qth > rth
                && qth + rth > pth
                && rth + pth > qth;
        }

        public static int ExecuteBruteForce(int[] A)
        {
            for (var p = 0; p < A.Length - 3; p++)
            {
                for (var q = p + 1; q < A.Length - 2; q++)
                {
                    for (var r = p + 2; r < A.Length - 1; r++)
                    {
                        if (IsTriangular(p, q, r))
                        {
                            return 1;
                        }
                    }
                }
            }

            return 0;
        }

        public static int Execute(int[] A)
        {
            Array.Sort(A);

            for (var n = 0; n < A.Length - 3; n++)
            {
                if (IsTriangular(A[n], A[n + 1], A[n + 2]))
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
