using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fall18_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<int> IntCollection = new MyCollection<int>();
            IntCollection.Add(1);
            IntCollection.Add(2);
            IntCollection.Add(3);
            IntCollection.Add(4, 1);
            Console.WriteLine("Display integer list:");
            IntCollection.DisplayItems();

            MyCollection<string> StringCollection = new MyCollection<string>();
            StringCollection.Add("aa");
            StringCollection.Add("bb");
            StringCollection.Add("cc");
            StringCollection.Add("dd", 1);
            Console.WriteLine("Display string list:");
            StringCollection.DisplayItems();
            Console.ReadLine();
        }
    }
}
