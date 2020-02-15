using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public interface IHashTable<T, U>
    {
        bool ContainsKey(T key);
        void Add(T key, U value);
        U Get(T key);
    }

    public class HashTable<T, U> : IHashTable<T, U>
    {
        private readonly LinkedList<KeyValuePair<T, U>>[] _array;
        private int _arraySize;

        public HashTable()
        {
            _arraySize = 1000;
            _array = new LinkedList<KeyValuePair<T, U>>[_arraySize];
        }

        private LinkedList<KeyValuePair<T, U>> Get(int index)
        {
            var list = _array[index];
            if (list == null)
            {
                list = new LinkedList<KeyValuePair<T, U>>();
                _array[index] = list;
            }
            return list;
        }

        public void Add(T key, U value)
        {
            // compute hash of key
            var hashcode = ((object)key).GetHashCode();

            // compute index
            var index = hashcode % _arraySize;

            // add key value pair
            var list = Get(index);

            list.AddLast(new KeyValuePair<T, U>(key, value));
        }

        public bool ContainsKey(T key)
        {
            // compute hash of key
            var hashcode = ((object)key).GetHashCode();

            // compute index
            var index = hashcode % _arraySize;

            // add key value pair
            var list = Get(index);

            var current = list.First;
            while (current != null)
            {
                if (current.Value.Key.Equals(key))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public U Get(T key)
        {
            // compute hash of key
            var hashcode = ((object)key).GetHashCode();

            // compute index
            var index = hashcode % _arraySize;

            // add key value pair
            var list = Get(index);

            var current = list.First;
            while (current != null)
            {
                if (current.Value.Key.Equals(key))
                {
                    return current.Value.Value;
                }
                current = current.Next;
            }
            throw new KeyNotFoundException(key.ToString());
        }
    }
}
