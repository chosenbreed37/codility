using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class PermMissingElement
    {
        public static int Find(int[] input)
        {
            var set = new HashSet<int>(input);

            for (var n = 1; n < input.Length + 1; n++)
            {
                if (!set.Contains(n))
                {
                    return n;
                }
            }
            return 0;
        }
    }
}
