using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILinkedList<int> Collection1 = new Node<int>(1, new Node<int>(2, new Node<int>(3, new Empty<int>())));
            PrintCollection(Collection1);
        }

        static void PrintCollection<T>(LinkedList<T> collection)
        {
            collection.Visit(node =>
            {
                Console.WriteLine(node.Value);
                PrintCollection<T>(node.Tail);
            },
                () =>
                {
                    Console.WriteLine("Im Empty");
                }
            );
        }
    }
}
