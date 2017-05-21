using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusablePatterns
{
    public interface LinkedList<T>
    {
        void Visit(Action<Node<T>> onNode, Action onEmpty);
        U Visit<U>(Func<Node<T>, U> onNode, Func<U> onEmpty);
    }
    public class Empty<T> : LinkedList<T>
    {
        public void Visit(Action<Node<T>> onNode, Action onEmpty) { onEmpty(); }
        public U Visit<U>(Func<Node<T>, U> onNode, Func<U> onEmpty) { return onEmpty(); }
    }
    public class Node<T> : LinkedList<T>
    {
        public T value { get; }
        public LinkedList<T> tail { get; }
        public Node(T value, LinkedList<T> tail)
        {
            this.value = value;
            this.tail = tail;
        }

        public void Visit(Action<Node<T>> onNode, Action onEmpty) { onNode(this); }
        public U Visit<U>(Func<Node<T>, U> onNode, Func<U> onEmpty) { return onNode(this); }
    }
}
