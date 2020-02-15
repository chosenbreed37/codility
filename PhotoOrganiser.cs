using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Codility
{
    public class PhotoOrganiser
    {
        public struct PhotoEntry
        {
            public string Name { get; set; }
            public string City { get; set; }
            public DateTime Timestamp { get; set; }
        }

        public static PhotoEntry Parse(string input)
        {
            var parts = input.Split(new[] { ',' });
            var name = parts[0]?.Trim();
            var city = parts[1]?.Trim();
            var timestampAsString = parts[2]?.Trim();
            return new PhotoEntry
            {
                Name = name,
                City = city,
                Timestamp = DateTime.Parse(timestampAsString)
            };
        }

        public static string Run(string input)
        {
            var entries = input.Split(new[] { '\n' });
            var parsedEntries = entries.Select(Parse);
            var groups = new Dictionary<string, IEnumerable<dynamic>>();

            foreach (var g in parsedEntries.GroupBy(x => x.City))
            {
                var totalEntriesPerCity = g.Count();
                var maxDigits = (int)Math.Floor(Math.Log10(totalEntriesPerCity) + 1);
                var entriesForCity = g
                    .OrderBy(e => e.Timestamp)
                    .Select((item, index) => new
                    {
                        OriginalName = item.Name,
                        NewName = item.City + (index + 1).ToString().PadLeft(maxDigits, '0') + Path.GetExtension(item.Name)
                    }).ToList();

                groups.Add(g.Key, entriesForCity);
            }

            var builder = new StringBuilder();
            foreach (var entry in parsedEntries)
            {
                var newName = groups[entry.City]
                    .FirstOrDefault(x => x.OriginalName == entry.Name)?.NewName;
                builder.AppendLine(newName);
            }
            return builder.ToString();
        }
    }
}
