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
            ILinkedList test = new Node<String>("test1", new Node<int>(1, new Empty()));

            Console.WriteLine(((Node<string>)test).Value);
            Console.ReadKey();
        }
    }
}
