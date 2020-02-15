using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.PreFixSums
{
    public class GenomicRangeQuery
    {
        public static int[] Execute(string S, int[] P, int[] Q)
        {
            var impactFactor = new Dictionary<char, int>
            {
                { 'A', 1 },
                { 'C', 2 },
                { 'G', 3 },
                {'T', 4 }
            };

            var result = new List<int>();

            for (var n = 0; n < P.Length; n++)
            {
                var i = P[n];
                var j = Q[n];
                var minFactor = Int32.MaxValue;
                for (var m = i; m < j + 1; m++)
                {
                    var entry = S[m];
                    var factor = impactFactor[entry];
                    if (factor < minFactor)
                    {
                        minFactor = factor;
                    }
                }
                result.Add(minFactor);
            }

            return result.ToArray();
        }
    }
}
