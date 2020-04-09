using System.Collections.Generic;
using System.Linq;

namespace Algorithms.PriorityQueue
{
    public class PriorityQueue<TKey, TValue>
    {
        SortedDictionary<TKey, TValue> _data;

        public PriorityQueue()
        {
            _data = new SortedDictionary<TKey, TValue>();
        }

        public PriorityQueue(IComparer<TKey> comparer)
        {
            _data = new SortedDictionary<TKey,TValue>(comparer);
        }

        public void Add(TKey key, TValue value)
        {
            _data.Add(key, value);
        }

        public KeyValuePair<TKey, TValue> Peek()
        {
            return _data.First();
        }

        public bool Remove(TKey key)
        {
            return _data.Remove(key);
        }

        public TValue this[TKey key]
        {
            get { return _data[key]; }
        }
    }
}
