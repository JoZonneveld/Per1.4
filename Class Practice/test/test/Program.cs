using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public interface LinkedList<T>
    {
        bool IsEmpty();
        T Value();
        LinkedList<T> Tail();
    }

    public class Empty<T> : LinkedList<T>
    {
        public bool IsEmpty()
        {
            return true;
        }

        public T Value()
        {
            return default(T);
        }

        public LinkedList<T> Tail()
        {
            return null;
        }
    }

    public class Node<T> : LinkedList<T>
    {
        private T value;
        private LinkedList<T> tail;

        public Node(T value, LinkedList<T> tail)
        {
            this.value = value;
            this.tail = tail;
        }

        public bool IsEmpty()
        {
            return false;
        }

        public T Value()
        {
            return value;
        }

        public LinkedList<T> Tail()
        {
            return tail;
        }
    }

    public class List<T>
    {
        //private Option<T> option;
        public LinkedList<T> linkedlist;

        public List()
        {
            linkedlist = new Empty<T>();
        }

        public void Add(T NewClass)
        {
            linkedlist = new Node<T>(NewClass, linkedlist);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int>();
           

            test.Add(3);
            test.Add(4);

            LinkedList<int> l = test.linkedlist;

            while (!l.IsEmpty())
            {
                Console.Out.WriteLine(l.Value());
                l = l.Tail();
            }
            
            Console.ReadKey();
        }
    }
}
