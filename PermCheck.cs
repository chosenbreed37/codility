using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class PermCheck
    {
        public static int solution(int[] input)
        {
            var set = new HashSet<int>(input);

            var n = input.Length;
            for (var i = 1; i < n + 1; i++)
            {
                if (!set.Contains(i))
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
