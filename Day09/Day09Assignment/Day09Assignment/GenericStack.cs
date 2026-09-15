using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09Assignment
{
    public class GenericStack<T>
    {
        private readonly List<T> items = new List<T>();

        public int Count
        {
            get { return items.Count; }
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("The stack is empty.");

            int lastIndex = items.Count - 1;
            T item = items[lastIndex];

            items.RemoveAt(lastIndex);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("The stack is empty.");

            return items[items.Count - 1];
        }
    }
}
