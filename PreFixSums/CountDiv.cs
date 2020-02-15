using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.PreFixSums
{
    public class CountDiv
    {
        public static int Execute(int A, int B, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var count = 0;
            //for (var n = A; n < B + 1; n++)
            //{
            //    if (n % K == 0) count++;
            //}
            var m = A / K;
            var n = B / K;

            if (A % K == 0)
            {
                return n - m + 1;
            }
            else
            {
                return n - m;
            }
        }
    }
}
