using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList3
{
    public interface ILinkedList<T>
    {
        void Visit(Action<LinkedListNode<T>> onNode, Action onEmpty);
        U Visit<U>(Func<LinkedListNode<T>> onNode, Func<T> onEmpty);
    }

    public class Empty<T> : ILinkedList<T>
    {
        public void Visit(Action<LinkedListNode<T>> onNode, Action onEmpty)
        {
            throw new NotImplementedException();
        }

        public U Visit<U>(Func<LinkedListNode<T>> onNode, Func<T> onEmpty)
        {
            throw new NotImplementedException();
        }
    }

    public class Node<T> : ILinkedList<T>
    {
        private T Value;
        private ILinkedList<T> Tail;
        public Node(T value, ILinkedList<T> tail)
        {
            this.Value = value;
            this.Tail = tail;
        }

        public void Visit(Action<LinkedListNode<T>> onNode, Action onEmpty)
        {
            throw new NotImplementedException();
        }

        public U Visit<U>(Func<LinkedListNode<T>> onNode, Func<T> onEmpty)
        {
            return onNode
        }
    }
}
