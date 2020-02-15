using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var delta = Y - X;
            var jumps = delta / D;
            var remainder = delta % D;
            return remainder == 0 ? jumps : jumps + 1;
        }
    }
}
