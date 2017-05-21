using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusablePatterns
{

    public class ArrayIterator<T> : Iterator<T>
    {
        T[] array;
        public ArrayIterator(T[] array)
        {
            this.array = array;
        }
        int current = -1;
        public Option<T> getNext()
        {
            current = current + 1;
            if (current >= array.Length) return new None<T>();
            return new Some<T>(array[current]);
        }
    }
    public class LinkedListIterator<T> : Iterator<T>
    {
        LinkedList<T> list;
        public LinkedListIterator(LinkedList<T> list)
        {
            this.list = list;
        }
        public Option<T> getNext()
        {
            return list.Visit<Option<T>>(node =>
            {
                list = node.tail;
                return new Some<T>(node.value);
            },
                                        () => new None<T>());
        }
    }
    public class MatrixIterator<T> : Iterator<T>
    {
        T[][] matrix;
        public MatrixIterator(T[][] matrix, int width, int height)
        {
            this.matrix = matrix;
            this.width = width;
            this.height = height;
        }
        int i = -1, j = 0;
        int width, height;
        public Option<T> getNext()
        {
            i = i + 1;
            if (i >= width)
            {
                i = 0;
                j = j + 1;
            }
            if (j >= height) return new None<T>();
            return new Some<T>(matrix[j][i]);
        }
    }
    public class NaturalNumbers : Iterator<int>
    {
        int current = -1;

        public Option<int> getNext()
        {
            current = current + 1;
            return new Some<int>(current);
        }
    }
}
