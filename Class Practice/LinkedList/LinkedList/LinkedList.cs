using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public interface ILinkedList
    {
        bool IsEmpty { get; }
    }

    public class Empty : ILinkedList
    {
        public bool IsEmpty { get; }
    }

    public class Node<T> : ILinkedList
    {
        public bool IsEmpty { get; }
        public T Value;
        public ILinkedList Tail;

        public Node(T value, ILinkedList tail)
        {
            IsEmpty = false;
            this.Value = value;
            this.Tail = tail;
        }
    }
}
