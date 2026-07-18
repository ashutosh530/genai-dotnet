using System;

namespace StudentRepository
{
    class Repository<T>
    {
        private readonly List<T> _items;
        public Repository()
        {
            _items = new List<T>();
        }
        public void Add(T item)
        {
            _items.Add(item);
        }
       public List<T> GetAll()
        {
            return _items;
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }
        public int Count()
        {
            return _items.Count();
        }

    }
}