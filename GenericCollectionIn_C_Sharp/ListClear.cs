using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionIn_C_Sharp
{
    class ListClear
    {
        public ListClear()
        {
            Console.WriteLine("Clear Method in list");
            List<int> list = new List<int>();   // create instance of list class.
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine("Print List of Item");
            foreach (var k in list)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Item Count Before Remove : " + list.Count);
            list.Clear();
            Console.WriteLine("Item Count After Remove : " + list.Count);
        }
    }
}
