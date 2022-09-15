using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionIn_C_Sharp
{
    public class ListExample
    {
        public ListExample()  //Constructer
        {
            // Creating a list of integer.
            List<int> myList = new List<int>();
            // displaying the number
            // of elements of List<T>
            Console.WriteLine(myList.Count);


            // C# program to illustrate the
            // Capacity Property of List<T>
            List<int> firstlist = new List<int>();
            // adding elements in firstlist
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);
            // Printing the Capacity of firstlist
            Console.WriteLine("Capacity is : "+firstlist.Capacity);
            // Printing the Count of firstlist
            Console.WriteLine("Count Is: " + firstlist.Count);
            // Adding some more
            // elements in firstlist
            firstlist.Add(5);
            firstlist.Add(6);
            // Printing the Capacity of firstlist
            // It will give output 8 as internally
            // List is resized
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);
            // Printing the Count of firstlist
            Console.WriteLine("Count Is: " + firstlist.Count);

            // Index of List start from 0.
            // access element of index 2
            Console.WriteLine("Element at index 2: " + firstlist[2]);

            // add specific Range.
            firstlist.AddRange(firstlist);
            Console.WriteLine("The Element of list after adding specific Range :");
            foreach (var i in firstlist)
            {
                Console.WriteLine(i);
            }
        }
    }
}
