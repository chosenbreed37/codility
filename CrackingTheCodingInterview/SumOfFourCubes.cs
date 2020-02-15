using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.CrackingTheCodingInterview
{
    /// <summary>
    /// Find all values of a, b, c, d less than 1000 
    /// for which a^3 + b^3 = c^3 + d^3
    /// </summary>
    public class SumOfFourCubes
    {
        public static IEnumerable<(int a, int b, int c, int d)> BruteForce()
        {
            var upperBound = 10;
            // brute force
            for (var a = 1; a < upperBound + 1; a++)
                for (var b = 1; b < upperBound + 1; b++)
                    for (var c = 1; c < upperBound + 1; c++)
                        for (var d = 1; d < upperBound + 1; d++)
                        {
                            var i = Math.Pow(a, 3);
                            var j = Math.Pow(b, 3);
                            var k = Math.Pow(c, 3);
                            var l = Math.Pow(d, 3);
                            if (i + j == k + l)
                            {
                                yield return (a, b, c, d);
                                break; // optimisation as there can only be one value of d for any given set of a, b and c that can satisfy the equation.
                            }
                        }
        }

        /// <summary>
        /// Reduce the runtime to O(N^3) by noting that d = (a^3 + b^3 - c^3)^1/3
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<(int a, int b, int c, int d)> BruteForce2()
        {
            var upperBound = 10;
            // brute force
            for (var a = 1; a < upperBound + 1; a++)
                for (var b = 1; b < upperBound + 1; b++)
                    for (var c = 1; c < upperBound + 1; c++)
                    {
                        var i = Math.Pow(a, 3);
                        var j = Math.Pow(b, 3);
                        var k = Math.Pow(c, 3);
                        var cubeRoot = 1.0 / 3.0;
                        var d = Math.Pow(i + j - k, cubeRoot);
                        var l = Math.Pow(d, 3);
                        if (i + j == k + l)
                        {
                            yield return (a, b, c, (int)d);
                        }
                    }
        }

        /// <summary>
        /// Reduce the runtime to O(N^2) by mapping out possible pairs for either side
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<(int a, int b, int c, int d)> BruteForce3()
        {
            var upperBound = 10;
            var pairs = new List<(int a, int b)>();
            // brute force
            for (var n = 1; n < upperBound + 1; n++)
                for (var m = 1; m < upperBound + 1; m++)
                    pairs.Add((n, m));

            foreach (var p1 in pairs)
                foreach (var p2 in pairs)
                {
                    (int a, int b) = p1;
                    (int c, int d) = p2;
                    var i = Math.Pow(a, 3);
                    var j = Math.Pow(b, 3);
                    var k = Math.Pow(c, 3);
                    var l = Math.Pow(d, 3);
                    if (i + j == k + l)
                    {
                        yield return (a, b, c, d);
                    }
                }
        }

        public static void Run()
        {
            // brute force algorithm
            var stopwatch = Stopwatch.StartNew();
            var result = BruteForce().Count();
            var elapsed = stopwatch.Elapsed;
            Console.WriteLine($"BruteForce1...");
            Console.WriteLine($"Number of combinations: {result}");
            Console.WriteLine($"Time elapsed: {elapsed}");

            stopwatch = Stopwatch.StartNew();
            result = BruteForce2().Count();
            elapsed = stopwatch.Elapsed;
            Console.WriteLine($"BruteForce2...");
            Console.WriteLine($"Number of combinations: {result}");
            Console.WriteLine($"Time elapsed: {elapsed}");

            stopwatch = Stopwatch.StartNew();
            result = BruteForce3().Count();
            elapsed = stopwatch.Elapsed;
            Console.WriteLine($"BruteForce3...");
            Console.WriteLine($"Number of combinations: {result}");
            Console.WriteLine($"Time elapsed: {elapsed}");
        }
    }
}
