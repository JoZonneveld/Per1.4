using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public interface ILinkedList<T>  // blueprint 
    {
        bool IsEmpty();
        T Value();
        ILinkedList<T> Tail();
    }

    public class Empty<T> : ILinkedList<T>
    {
        public bool IsEmpty()
        {
            return true;
        }

        public T Value()
        {
            return default(T);
        }

        public ILinkedList<T> Tail()
        {
            return null;
        }
    }

    public class Node<T> : ILinkedList<T>
    {
        private T value;
        private ILinkedList<T> tail;

        public Node(T Value, ILinkedList<T> Tail)
        {
            this.value = Value;
            this.tail = Tail;
        }

        public bool IsEmpty()
        {
            return false;
        }

        public T Value()
        {
            return value;
        }

        public ILinkedList<T> Tail()
        {
            return tail;
        }

    }
}
