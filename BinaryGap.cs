using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    using System;
    using System.Text.RegularExpressions;

    class Solution
    {
        public class Result
        {
            public int Quotient { get; set; }
            public int Remainder { get; set; }
        }

        public static Result div(int n)
        {
            var quotient = n / 2;
            var remainder = n % 2;
            return new Result { Quotient = quotient, Remainder = remainder };
        }

        public static string ToBinaryString(int n)
        {
            var r = div(n);
            var binaryText = "";
            while (r.Quotient > 0)
            {
                binaryText += $"{r.Remainder}";
                r = div(r.Quotient);
            }
            binaryText += $"{r.Remainder}";

            return binaryText;
        }

        public static int MaxGap(string text)
        {
            // Define a regular expression for repeated words.
            Regex rx = new Regex(@"1[0]+", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            // Find matches.
            MatchCollection matches = rx.Matches(text);

            Regex counter = new Regex(@"0", RegexOptions.Compiled);
            var maxGap = 0;
            // Report on each match.
            foreach (Match match in matches)
            {
                var r = counter.Matches(match.Value);
                if (r.Count > maxGap)
                {
                    maxGap = r.Count;
                }
            }
            return maxGap;
        }


        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var binaryText = ToBinaryString(N);
            return MaxGap(binaryText);
        }
    }
    
    class BinaryGap
    {
    }
}
