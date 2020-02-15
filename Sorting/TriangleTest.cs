using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Sorting
{
    class TriangleTest
    {
        [Test]
        public void Sample1()
        {
            var A = new int[] { 10, 2, 5, 1, 8, 20 };
            var expected = 1;
            var actual = Triangle.Execute(A);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sample2()
        {
            var A = new int[] { 10, 50, 5, 1 };
            var expected = 0;
            var actual = Triangle.Execute(A);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LargeSample1()
        {
            var generator = new Random();
            var A = Enumerable.Range(0, 100000).Select(x => generator.Next(Int32.MinValue, Int32.MaxValue)).ToArray();
            var expected = 1;
            var actual = Triangle.Execute(A);

            Assert.AreEqual(expected, actual);
        }
    }
}
