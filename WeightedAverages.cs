using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Trade
    {
        public string Id { get; private set; }
        public double Price { get; private set; }
        public int Size { get; private set; }

        public Trade(string id, double price, int size)
        {
            Id = id;
            Price = price;
            Size = size;
        }
    }

    public static class WeightedAverages
    {
        public static double WeightedAverage<T>(this IEnumerable<T> target, Func<T, double> mapper)
        {
            return target
                .Select(mapper)
                .Average();
        }
    }

    public static class WeightedAverageTest
    {
        public static void Test()
        {
            var trades = new[]
            {
                new Trade("A", 3.5, 1000),
                new Trade("B", 4.7, 2500),
                new Trade("C", 3.2, 3000),
                new Trade("D", 9.2, 1000)
            };
            var sumOfWeights = trades.Sum(t => t.Size);
            Console.WriteLine(trades.WeightedAverage(t => (t.Price * t.Size)/sumOfWeights));
        }
    }
}
