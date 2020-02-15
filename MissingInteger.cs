using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MissingInteger
    {
        public static int solution(int[] input)
        {
            var max = Int32.MinValue;
            var min = Int32.MaxValue;

            for (var i = 0; i < input.Length; i++)
            {
                var ith = input[i];
                if (min > ith)
                {
                    min = ith;
                }
                if (max < ith)
                {
                    max = ith;
                }
            }

            if (max <= 0)
            {
                return 1;
            }

            //if (max == min)
            //{
            //    return max > 1 ? 1 : max + 1;
            //}

            // convert to hash set
            var set = new HashSet<int>(input);

            for (var n = 1; n < max + 1; n++)
            {
                if (!set.Contains(n) && n > 0)
                {
                    return n;
                }
            }

            return max + 1;
        }
    }
}
