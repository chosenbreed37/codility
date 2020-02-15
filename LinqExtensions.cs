using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public static class LinqExtensions
    {
        public static IEnumerable<U> Map<T, U>(this IEnumerable<T> target, Func<T, U> mapper)
        {
            return target.Select(mapper);
        }

        public static IEnumerable<T> Filter<T>(this IEnumerable<T> target, Func<T, bool> predicate)
        {
            return target.Where(predicate);
        }

        public static U Reduce<T, U>(this IEnumerable<T> target, U seed, Func<U, T, U> reducer)
        {
            return target.Aggregate(seed, reducer);
        }
    }
}
