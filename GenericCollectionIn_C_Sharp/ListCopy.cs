using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionIn_C_Sharp
{
    class ListCopy
    {
        public ListCopy()
        {
            List<string> list = new List<string>(); // create list and add some element
            list.Add("pavan");
            list.Add("Kunal");
            list.Add("anu");
            list.Add("dhanu");
            list.Add("om");
            // Display Element of list
            Console.WriteLine("Element of list Original is :");
            foreach (var k in list)
            {
                Console.WriteLine(k);
            }
            // create array.
            string[] arr = new string[15];  // create array of 15 element.
            // Copy list element to array using CopyTo() method.
            list.CopyTo(arr);
            //Display Element of array.
            Console.WriteLine("Element of array after Copy is :");
            foreach (var k in arr)
            {
                Console.WriteLine(k);
            }
        }
    }
}
