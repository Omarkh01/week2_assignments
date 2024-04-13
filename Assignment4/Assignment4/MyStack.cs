using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class MyStack<T>
    {
        private List<T> elements = new List<T>();

        public int Count()
        {
            return elements.Count;
        }

        public T Pop()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            T value = elements[^1];
            elements.RemoveAt(elements.Count - 1);
            return value;
        }

        public void Push(T item)
        {
            elements.Add(item);
        }
    }
}
