using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionIn_C_Sharp
{
    public class ReadOnlyList
    {
        public ReadOnlyList()
        {
            // Creating an List<T> of Integers
            List<int> mylist = new List<int>();

            // Adding elements to List
            mylist.Add(17);
            mylist.Add(19);
            mylist.Add(21);
            mylist.Add(9);
            mylist.Add(75);
            mylist.Add(19);
            mylist.Add(73);

            Console.WriteLine("Before Wrapping: ");

            // Displaying the elements
            // in the mylist
            foreach (int i in mylist)
            {
                Console.WriteLine(i);
            }

            // Creating a Read-Only packing
            // around the List
            IList<int> readlist = mylist.AsReadOnly();

            Console.WriteLine("After Wrapping: ");

            // Displaying the elements
            // of Read-Only Collection
            foreach (int j in readlist)
            {
                Console.WriteLine(j);
            }

            // You can add elements to
            // the original List i.e. mylist
            Console.WriteLine("Adding new element to mylist: ");
            mylist.Add(35);

            // Displaying the elements
            // in the mylist
            foreach (int k in mylist)
            {
                Console.WriteLine(k);
            }

            // But you cannot add elements
            // into the Read-Only Collection
            Console.WriteLine("Trying to add new element into readlist:");

            // it will give error
            try
            {
                readlist.Add(34);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Not Accesible to write : " + e.Message);
            }
            
        }
    }
}
