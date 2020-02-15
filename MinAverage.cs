using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MinAverage
    {
        struct Slice
        {
            public int M, N;
        }

        public static int solution(int[] A)
        {
            var dic = new Dictionary<Slice, double>();
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var min = Int32.MaxValue;
            var minPos = A.Length;
            for (var i = 0; i < A.Length; i++)
            {
                for (var j = i + 1; j < A.Length; j++)
                {
                    var a = A[i];
                    var b = A[j];
                    var avg = (a + b) / (j - i + 1);
                    if (min > avg)
                    {
                        min = avg;
                        minPos = i;
                    }
                }
            }
            return minPos;
        }
    }
}
