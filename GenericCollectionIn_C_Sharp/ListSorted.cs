using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionIn_C_Sharp
{
    class ListSorted
    {
        public ListSorted()
        {
            List<string> list = new List<string>();
            string[] data = { "pavan", "Kunal", "Om", "abhay", "Swapnali", "Arati", "Anu" };        // create string and store data.
            list.AddRange(data);    // pass string data in list using AddRange Method.
            Console.WriteLine("\nPrint data without sort : ");
            foreach (var k in list)
            {
                Console.WriteLine(k);
            }
            list.Sort();    // list sorted using sort method.
            Console.WriteLine("Print data After sort : ");
            foreach (var k in list)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("\nInsert EFGH :");

            // insert "EFGH" in the List
            //"EFGH" insert into its original
            // position when the List is sorted
            int index = list.BinarySearch("EFGH");
            if (index < 0)
            {

                list.Insert(~index, "EFGH");
            }

            Console.WriteLine();
            foreach (var k in list)
            {
                Console.WriteLine(k);
            }
        }

    }
}
