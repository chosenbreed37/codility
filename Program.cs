﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            //CrackingTheCodingInterview.SumOfFourCubes.Run();
            //var parser = new DynamicObjectParser.Tests.Parser();
            var parser = new DynamicObjectParser.Tests.DynamicParser2();
            var result = parser.Parse("Sample.txt");
            Console.WriteLine($"IsEnabled: {result.IsEnabled}");
            Console.WriteLine($"TimeToLive: {result.TimeToLive}");


            var input = @"photo.jpg, Warsaw, 2013-09-05 14:08:15
                john.png, London, 2015 - 06 - 20 15:13:22
                myFriends.png, Warsaw, 2013 - 09 - 05 14:07:13
                Eiffel.jpg, Paris, 2015 - 07 - 23 08:03:02
                pisatower.jpg, Paris, 2015 - 07 - 22 23:59:59
                BOB.jpg, London, 2015 - 08 - 05 00:02:03
                notredame.png, Paris, 2015 - 09 - 01 12:00:00
                me.jpg, Warsaw, 2013 - 09 - 06 15:40:22
                a.png, Warsaw, 2016 - 02 - 13 13:33:50
                b.jpg, Warsaw, 2016 - 01 - 02 15:12:22
                c.jpg, Warsaw, 2016 - 01 - 02 14:34:30
                d.jpg, Warsaw, 2016 - 01 - 02 15:15:01
                e.png, Warsaw, 2016 - 01 - 02 09:49:09
                f.png, Warsaw, 2016 - 01 - 02 10:55:32
                g.jpg, Warsaw, 2016 - 02 - 29 22:13:11";
            //Console.WriteLine(PhotoOrganiser.Run(input));
        }
    }
}
