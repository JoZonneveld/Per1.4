using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> l = new Node<int>(1, new Node<int>(3, new Empty<int>()));

            IElementVisitor<int, int> test = ;

            while (l.IsEmpty() == false)
            {
                Console.Out.WriteLine(l.Visit<int>(test));
                l = l.Tail();
            }
            
            Console.ReadKey();
        }
    }
}
