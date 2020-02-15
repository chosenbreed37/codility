using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.PreFixSums
{
    public class CountDivTests
    {
        [TestCase(11, 49, 4, 10)]
        [TestCase(6, 11, 2, 3)]
        [TestCase(5, 113, 7, 16)]
        public void Execute(int A, int B, int K, int expected)
        {
            var actual = CountDiv.Execute(A, B, K);

            Assert.AreEqual(expected, actual);
        }
    }
}
