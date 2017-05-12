using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist2
{
    public interface IElement<T>
    {
        void Visit<U>(IElementVisitor<T, U> ev);
    }

    public abstract class IElementVisitor<T, U>
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

    public interface IList<T> : IElement<T>
    {
        bool IsEmpty();
        T Value();
        IList<T> Tail();
    }

    public class Empty<T> : IList<T>
    {
        public bool IsEmpty()
        {
            return true;
        }

        public T Value()
        {
            return default(T);
        }

        public IList<T> Tail()
        {
            return null;
        }

        public void Visit<U>(IElementVisitor<T, U> ev)
        {
            Console.WriteLine(ev.OnSome(Value()));
        }
    }

    public class Node<T> : IList<T>
    {
        public T value;
        public IList<T> tail;

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

        public void Visit<U>(IElementVisitor<T, U> ev)
        {
            Console.WriteLine(ev.OnSome(value)); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new Node<int>(1, new Node<int>(2, new Node<int>(3, new Empty<int>())));

            IElementVisitor<int, string> test = new PrintElement();

            IList<int> l = list;
            while (l.IsEmpty() == false)
            {
                l.Visit(test);
                Console.Out.WriteLine(l.Value());
                l = l.Tail();
            }

            Console.ReadKey();
        }
    }
}
