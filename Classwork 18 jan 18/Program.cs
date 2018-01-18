using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_18_jan_18
{
    class MyList<T> /*: IEnumerable<T>*/
    {
        T[] array;

        public int Count { get; private set; }

        public MyList()
        {
            array = new T[4];
            Count = 0;
        }
        public void Add(T item)
        {
            if (Count == array.Length)
            {
                T[] temparray = new T[array.Length * 2];
                array.CopyTo(temparray, 0);
                array = temparray;
                array[Count] = item;
                Count++;
            }
            else
            {
                array[Count] = item;
                Count++;
            }
        }

        //public IEnumerator<T> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        public T this[int index]
        {
            set
            {
                array[index] = value;
            }
            get
            {
                return array[index];
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            var myList = new MyList<int>();
            myList.Add(15);
            myList.Add(16);
            myList.Add(17);
            myList.Add(18);
            myList.Add(19);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            myList[5] = 16;
            //foreach (var item in myList)
            //{

            //}
        }
    }
}
