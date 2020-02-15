using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MaxCounters
    {
        public static int[] solution(int N, int[] A)
        {
            var buffer = new int[N];

            var currentMax = 0;
            for (var i = 0; i < A.Length; i++)
            {
                var j = A[i];
                if (j == N + 1)
                {
                    for (var k = 0; k < N; k++)
                    {
                        buffer[k] = currentMax;
                    }
                }
                else
                {
                    buffer[j - 1] = buffer[j - 1] + 1;
                    if (buffer[j - 1] > currentMax)
                    {
                        currentMax = buffer[j - 1];
                    }
                }
            }
            return buffer;
        }
    }
}
