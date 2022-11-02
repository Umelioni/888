using Lab6.Interfaces;
using System;

namespace Lab6.Classes
{
    public class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>
    {
        private struct Pair
        {
            public TKey key;
            public TValue value;
        }

        private Pair[] _pairs;

        public MyDictionary()
        {
            _pairs = new Pair[0];
        }
        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < _pairs.Length; i++)
                {
                    if (_pairs[i].key.Equals(key))
                    {
                        return _pairs[i].value;
                    }
                }
                return default(TValue);
            }
            set
            {
                for (int i = 0; i < _pairs.Length; i++)
                {
                    if (_pairs[i].Equals(key))
                    {
                        _pairs[i].value = value;
                    }
                }
            }
        }


        public int Count
        {
            get
            {
                return _pairs.Length;
            }
        }

        public int Capacity
        {
            get
            {
                return _pairs.Length;
            }
            set
            {
                if (value != _pairs.Length)
                {
                    if (value > 0)
                    {
                        Pair[] newPairs = new Pair[value];
                        if (_pairs.Length > 0)
                            Array.Copy(_pairs, 0, newPairs, 0, _pairs.Length);
                        _pairs = newPairs;
                    }
                    else
                    {
                        _pairs = new Pair[0];
                    }
                }
            }
        }

        public void Add(TKey key, TValue value)
        {
            if (key == null) throw new Exception("Key is null");


            for (int i = 0; i < _pairs.Length; i++)
            {
                if (_pairs[i].key.Equals(key))
                {
                    throw new Exception("Key already added");
                    return;
                }
            }

            Capacity++;

            _pairs[_pairs.Length - 1] = new Pair { key = key, value = value }; ;
        }
    }
}
