using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;

/*
Reuse the following exceptions:

- UnknownKeyException
- EmptyKeyException
- InvalidKeyException
- DuplicatedKeyException
*/
namespace DynamicObjectParser.Tests
{
    public class DynamicParser2 : IParser
    {
        /*
        Here is an example input configuration to parse:

        UserName:admin;
        Password:""super%^&*333password;
        DNSName:SomeName;

        TimeToLive:4;
        ClusterSize:2;
        PortNumber:2222;

        IsEnabled:true;
        EnsureTransaction:false;
        PersistentStorage:false;
        */
        public dynamic Parse(string configuration)
        {
            if (String.IsNullOrWhiteSpace(configuration))
            {
                throw new ArgumentException();
            }

            var settings = new ExpandoObject();
            
            var lines = File.ReadAllLines(configuration, System.Text.Encoding.UTF8);
            foreach (var l in lines)
            {
                // skip through empty lines
                if (String.IsNullOrWhiteSpace(l))
                {
                    continue;
                }

                // split the line
                var parts = l.Split(new[] { ':' });
                if (parts.Length != 2)
                {
                    continue;
                }
                var key = parts[0]?.Trim();

                if (String.IsNullOrEmpty(key))
                {
                    throw new InvalidKeyException();
                }
                var value = parts[1]?.Trim().TrimEnd(new[] { ';' });

                if (String.IsNullOrEmpty(value))
                {
                    throw new EmptyKeyException();
                }

                SetValue(settings, key, value);
            }

            return settings;
        }

        private void SetValue<T>(IDictionary<string, object> dic, string key, T value)
        {
            if (dic.ContainsKey(key))
            {
                throw new DuplicatedKeyException();
            }
            dic.Add(key, value);
        }
    }
}
