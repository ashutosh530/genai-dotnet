using System;
using System.Reflection.Metadata.Ecma335;

namespace RepositoryManagement
{

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name} & Class : {Class}";
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }
    }

    class Repository<T>
    {
        private List<T> items;

        public Repository()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);  
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public void DisplayAll()
        {
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public int Count()
        {
            return items.Count;
        }

        public List<T> GetAll()
        {
          return items;
        }

    }
}