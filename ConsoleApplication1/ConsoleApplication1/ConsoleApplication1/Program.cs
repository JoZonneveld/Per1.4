using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReusablePatterns;
namespace ConsoleApplication1
{
  

  public class Program
  {
    static void Main(string[] args)
    {
      Iterator<int> collection1 = new LinkedListIterator<int>(new Node<int>(1, new Node<int>(2, new Node<int>(3, new Empty<int>()))));
      PrintCollection(collection1);

      Iterator<int> collection2 = new ArrayIterator<int>(new int[] { 9, 10, 11, -1 });
      PrintCollection(collection2);

      int[][] tmp_collection3 = new int[3][];
      tmp_collection3[0] = new int[] { 3, 2, 1 };
      tmp_collection3[1] = new int[] { 2, 1, 3 };
      tmp_collection3[2] = new int[] { 1, 3, 2 };
      Iterator<int> collection3 = new MatrixIterator<int>(tmp_collection3, 3, 3);
      PrintCollection(collection3);

      Iterator<int> collection4 = new NaturalNumbers();
      PrintCollection(collection4);



    }
    static void PrintCollection<T>(Iterator<T> collection)
    {
      collection.getNext().Visit(() => {
                                    Console.WriteLine("I am empty..");
                                  },
                                  value =>
                                  {
                                    Console.WriteLine(value);
                                    Console.ReadLine();
                                    PrintCollection(collection);
                                  });
    }

  }



}
