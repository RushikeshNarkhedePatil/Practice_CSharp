using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionIn_C_Sharp
{
    public class ListExample
    {
        public ListExample()
        {
            //ListExample.ListExampleDemo();
            int choice = 0;
            Console.WriteLine("Operation on List : Select your Choice");
            Console.WriteLine("1. Example Of List\n2. Read only List Example\n3. List sort and binary Search" +
              "\n4. Clear\n5. List Contains\n6. ListCopy");
            choice = Convert.ToInt32(Console.ReadLine()); //convert string to integer

            switch (choice)
            {
                case 1:
                    ListExample.ListExampleDemo();
                    break;
                case 2:
                    ListExample.ReadOnlyList();
                    break;
                case 3:
                    ListExample.ListSorted();
                    break;
                case 4:
                    ListExample.ListClear();
                    break;
                case 5:
                    ListExample.ListContains();
                    break;
                case 6:
                    ListExample.ListCopy();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        static void ListExampleDemo()
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
            Console.WriteLine("Capacity is : " + firstlist.Capacity);
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
        static void ReadOnlyList()
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
        static void ListSorted()
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
        static void ListClear()
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
        static void ListContains()
        {
            int No = 0;
            // Creating an List<T> of Integers
            List<int> list = new List<int>();
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
        static void ListCopy()
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
