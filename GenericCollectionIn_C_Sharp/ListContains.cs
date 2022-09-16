using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionIn_C_Sharp
{
    class ListContains
    {
        public ListContains()
        {
            int No = 0;
            // Creating an List<T> of Integers
            List<int> list= new List<int>();
            int[] arr = { 10, 20, 30, 40, 50 }; // craete intager array and add 5 elements.
            list.AddRange(arr); // passed array element to list.
            Console.WriteLine("List of Element");
            foreach (var k in list)
            {
                Console.WriteLine(k);
            }
            // Checking whether 4 is present
            // in List or not
            Console.WriteLine("Enter value to check present or not.");
            No = Convert.ToInt32(Console.ReadLine());   // accept user input to check number present or not means true or false.
            Console.WriteLine(list.Contains(No));

        }
    }
}
