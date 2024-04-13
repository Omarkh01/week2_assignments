using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class MyList<T>
    {
        private List<T> elements = new List<T>();

        public void Add(T element)
        {
            elements.Add(element);
        }

        public T Remove(int index)
        {
            T item = elements[index];
            elements.RemoveAt(index);
            return item;
        }

        public bool Contains(T element)
        {
            return elements.Contains(element);
        }

        public void Clear()
        {
            elements.Clear();
        }

        public void InsertAt(T element, int index)
        {
            elements.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            elements.RemoveAt(index);
        }

        public T Find(int index)
        {
            return elements[index];
        }
    }
}
