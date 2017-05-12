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
        T Visit<U>(IElementVisitor<T,U> ev);
    }

    interface IElementVisitor<T,U>
    {
        U OnSome(T value);
        U OnNone();
    }

    class PrintElement : IElementVisitor<int, string>
    {
        public string OnSome(int value)
        {
            return value.ToString();
        }

        public string OnNone()
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
        

        public T Visit<U>(IElementVisitor<T, U> ev)
        {
            return default(T);
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
        
        public T Visit<U>(IElementVisitor<T, U> ev)
        {
            return ev.OnSome(value);
        }
    }

}
