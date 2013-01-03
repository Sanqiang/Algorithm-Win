using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    interface IQueue<T>
    {
        public abstract void push(T val);
        public abstract T pop();
        public abstract T peekAtFirst();
        public abstract T peekAtLast();
    }

    class ObjectAdapter<T> : IQueue<T>
    {
        List<T> adaptee = new List<T>();

        public void push(T val)
        {
            adaptee.Insert(0, val);
        }

        public T pop()
        {
            T val = adaptee[adaptee.Count - 1];
            adaptee.RemoveAt(adaptee.Count - 1);
            return val;
        }

        public T peekAtFirst()
        {
            return adaptee[0];
        }

        public T peekAtLast()
        {
            return adaptee[adaptee.Count - 1];
        }
    }

    class ClassAdapter<T> : List<T>, IQueue<T>
    {
        public void push(T val)
        {
            push(val);
        }

        public T pop()
        {
            T val = this[Count - 1];
            RemoveAt(Count - 1);
            return val;
        }

        public T peekAtFirst()
        {
            return this[0];
        }

        public T peekAtLast()
        {
            return this[Count - 1];
        }
    }
}
