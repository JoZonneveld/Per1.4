using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ILinkedList<int> test = new Node<int>(1, new Node<int>(2, new Node<int>(3, new Empty<int>())));
            
            Console.Out.WriteLine(test);
            
            Console.ReadKey();
        }
    }
}
