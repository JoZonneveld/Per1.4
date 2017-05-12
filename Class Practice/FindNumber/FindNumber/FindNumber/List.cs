using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumber
{

    interface IElement<T>
    {
        U Visit<U>(IElementVisitor<T, U> ev);
    }

    internal abstract class IElementVisitor<T, U>
    {
        public abstract U OnSome(T value);
        public abstract U OnNone();
    }

    class PrintElement : IElementVisitor<int, string>
    {
        public override string OnSome(int value)
        {
            return value.ToString();
        }

        public override string OnNone()
        {
            return "empty";
        }
    }

    interface IList<T> : IElement<T>
    {
        bool IsEmpty();
        T Value();
        IList<T> Tail();
    }

    class Empty<T> : IList<T>
    {
        public bool IsEmpty()
        {
            return true;
        }

        public IList<T> Tail()
        {
            return null;
        }

        public T Value()
        {
            return default(T);
        }
        

        public U Visit<U>(IElementVisitor<T, U> ev)
        {
            return default(U);
        }
    }

    class Node<T> : IList<T>
    {
        private T value;
        private IList<T> tail;

        public Node(T Value, IList<T> Tail)
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

        public IList<T> Tail()
        {
            return tail;
        }
        
        public U Visit<U>(IElementVisitor<T, U> ev)
        {
            return ev.OnSome(value);
        }
    }

}
