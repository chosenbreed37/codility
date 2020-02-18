using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Sorting
{
    class IntersectingDiscsTests
    {
        [Test]
        public void Sample()
        {
            var A = new int[] { 1, 5, 2, 1, 4, 0 };
            var expected = 11;
            var actual = IntersectingDiscs.Execute(A);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sample2()
        {
            var A = new int[] { 1, 1, 1 };
            var expected = 3;
            var actual = IntersectingDiscs.Execute(A);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sample3()
        {
            var A = new int[] { 1, 2147483647, 0 };
            var expected = 2;
            var actual = IntersectingDiscs.Execute(A);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void With1000()
        {
            var generator = new Random();
            var A = Enumerable.Range(0, 1000)
                .Select(_ => generator.Next(0, Int32.MaxValue))
                .ToArray();
            var expected = 11;
            var actual = IntersectingDiscs.Execute(A);
        }

        [Test]
        public void With10000()
        {
            var generator = new Random();
            var A = Enumerable.Range(0, 10000)
                .Select(_ => generator.Next(0, Int32.MaxValue))
                .ToArray();
            var expected = 11;
            var actual = IntersectingDiscs.Execute(A);
            //Assert.AreEqual(expected, actual);
        }

        [Test]
        public void With100000()
        {
            var generator = new Random();
            var A = Enumerable.Range(0, 100000)
                .Select(_ => generator.Next(0, Int32.MaxValue))
                .ToArray();
            var expected = 11;
            var actual = IntersectingDiscs.Execute(A);
            //Assert.AreEqual(expected, actual);
        }
    }
}
