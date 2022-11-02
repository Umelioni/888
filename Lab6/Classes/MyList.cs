using Lab6.Interfaces;
using System;

namespace Lab6.Classes
{
    public class MyList<T> : IMyList<T>
    {
        private T[] _items;
        public T this[int index] 
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
            }
        }

        public MyList()
        {
            _items = new T[0];
        }

        public int Count
        {
            get
            {
                return _items.Length;
            }
        }

        public int Capacity
        {
            get
            {
                return _items.Length;
            }
            set
            {
                if (value != _items.Length)
                {
                    if (value > 0)
                    {
                        T[] newItems = new T[value];
                        if (_items.Length > 0)
                            Array.Copy(_items, 0, newItems, 0, _items.Length);
                        _items = newItems;
                    }
                    else
                    {
                        _items = new T[0];
                    }
                }
            }
        }
        public void Add(T item)
        {
            Capacity++;
            _items[Capacity-1] = item;
        }
    }
}
