using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectParser.Tests
{
    public class DuplicatedKeyException: Exception
    {
    }

    public class UnknownKeyException : Exception
    {
    }

    public class EmptyKeyException : Exception
    {
    }

    public class InvalidKeyException : Exception
    {
    }

    interface IParser
    {
        dynamic Parse(string configuration);
    }
}
