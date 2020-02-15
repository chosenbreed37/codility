using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class FrogRiverOne
    {
        public static int solution(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var set = new HashSet<int>();
            var total = 0;
            var expectedTotal = (X * (X + 1)) / 2;
            for (var n = 0; n < A.Length; n++)
            {
                var curr = A[n];
                if (curr <= X)
                {
                    if (!set.Contains(curr))
                    {
                        set.Add(curr);
                        total += curr;
                    }
                    if (total == expectedTotal)
                    {
                        return n;
                    }
                }
            }
            return -1;
        }
    }
}
