using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.PreFixSums
{
    public class GenomicRangeQueryTest
    {
        [Test]
        public void Sample()
        {
            var S = "CAGCCTA";
            var P = new int[] { 2, 5, 0 };
            var Q = new int[] { 4, 5, 6 };

            var expected = new int[] { 2, 4, 1 };
            var actual = GenomicRangeQuery.Execute(S, P, Q);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
