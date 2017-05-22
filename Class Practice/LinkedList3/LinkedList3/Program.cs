using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList3
{
    public interface Option<T>
    {
        U Visit<U>(Func<U> onNone, Func<T, U> onSome);


    }

    public class Some<T> : Option<T>
    {
        private T Value;
        public Some(T value)
        {
            this.Value = value;
        }
        public U Visit<U>(Func<U> onNone, Func<T, U> onSome)
        {
            return onSome(Value);
        }
    }

    public class None<T> : Option<T>
    {
        public U Visit<U>(Func<U> onNone, Func<T, U> onSome)
        {
            return None<T>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ILinkedList<int> Collection1 = new Node<int>(1, new Node<int>(2, new Node<int>(3, new Empty<int>())));
            //PrintCollection(Collection1);
        }

        //static void PrintCollection<T>(LinkedList<T> collection)
        //{
        //    collection.Visit(node =>
        //    {
        //        Console.WriteLine(node.Value);
        //        PrintCollection<T>(node.Tail);
        //    },
        //        () =>
        //        {
        //            Console.WriteLine("Im Empty");
        //        }
        //    );
        //}
    }
}
