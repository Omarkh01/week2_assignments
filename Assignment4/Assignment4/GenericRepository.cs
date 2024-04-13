using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class GenericRepository<T> : IRepository<T> where T : class, new()
    {
        private List<T> elements = new List<T>();

        public void Add(T item)
        {
            elements.Add(item);
        }

        public void Remove(T item)
        {
            elements.Remove(item);
        }

        public void Save()
        {
            //
        }

        public IEnumerable<T> GetAll()
        {
            return elements;
        }

        public T GetById(int id)
        {
            foreach (var item in elements)
            {
                var propertyInfo = item.GetType().GetProperty("Id");
                if (propertyInfo != null && (int)propertyInfo.GetValue(item) == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
