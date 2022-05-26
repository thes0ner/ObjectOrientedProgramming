using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generic
{
    public class MyList<T>
    {
        T[] items;
        T[] temp;

        public MyList()
        {
            items = new T[0];     
        }

        public void Add(T item)
        {
            temp = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                items[i] = temp[i];
            }

            //Last added item...
            items[items.Length - 1] = item;

        }
        //Method that counts items in MyList.
        public int Count { get { return items.Length; } }

        public void RemoveAll()
        {
            

        }

        public void Print()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

    }
}
