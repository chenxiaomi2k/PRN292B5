using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fall18_Q2
{
    class MyCollection<T>
    {
        private List<T> list;

        public MyCollection()
        {
            list = new List<T>();
        }

        public void Add(T obj)
        {
            list.Add(obj);
        }

        public void Add(T obj, int k)
        {
            list.Insert(k, obj);
        }

        public void DisplayItems()
        {
            Console.WriteLine("Items in my collection:");
            foreach(T t in list)
            {
                Console.WriteLine(t);
            }
        }
    }
}
