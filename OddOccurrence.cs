using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public static class ArrayExtensions
    {
        public static int FindOddOccurrence(this int[] target)
        {
            return target
                .GroupBy(x => x)
                .Where(g => g.Count() == 1)
                .Select(g => g.First())
                .First();
        }
    }
}
