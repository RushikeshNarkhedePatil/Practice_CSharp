using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionIn_C_Sharp
{
    public class ListExample
    {
        //check Even or not
        private static bool isEven(int i)
        {
            return ((i % 2) == 0);
        }

        // display method
        static void display(string str)
        {
            Console.WriteLine(str);
        }
        public ListExample()
        {
            //ListExample.ListExampleDemo();
            int choice = 0;
            Console.WriteLine("Operation on List : Select your Choice");
            Console.WriteLine("1. Example Of List\n2. Read only List Example\n3. List sort and binary Search" +
              "\n4. Clear\n5. List Contains\n6. ListCopy\n7. ListEquals\n8. ListExits\n9. ListFind\n10. ListFindLastIndex\n11. ListForeach\n");
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
                case 7:
                    ListExample.ListObjectEquals();
                    break;
                case 8:
                    ListExample.ListExists();
                    break;
                case 9:
                    ListExample.ListFindPredicate();
                    break;
                case 10:
                    ListExample.ListFindLastIndex();
                    break;
                case 11:
                    ListExample.ListForeach();
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
        static void ListObjectEquals()
        {
            // Creating a List of strings
            List<string> list1 = new List<string>();

            // Inserting elements in List
            list1.Add("DS");
            list1.Add("C++");
            list1.Add("Java");
            list1.Add("JavaScript");
            //print list1 data
            Console.WriteLine("Print List1 Data : ");
            foreach (var k in list1)
            {
                Console.WriteLine(k);
            }

            // Creating an List<T> of Integers
            List<int> list2 = new List<int>();

            // Adding elements to List
            list2.Add(78);
            list2.Add(44);
            list2.Add(27);
            list2.Add(98);
            list2.Add(74);

            //print list2 data
            Console.WriteLine("Print List2 Data : ");
            foreach (var k in list2)
            {
                Console.WriteLine(k);
            }
            // Checking whether list1 is equal to list2 or not
            Console.WriteLine("List1 is equal to list2 or not : "+list1.Equals(list2));

            // Creating a List of integers
            List<int> list3 = new List<int>();

            // Assigning list2 to list3
            Console.WriteLine("Assigning list2 to list3");
            list3 = list2;

            // Checking whether list3 is
            // equal to list2 or not
            Console.WriteLine("List3 is equal to list2 or not : " + list3.Equals(list2));
        }
        static void ListExists()    // check specific condision match or not. return true or false.
        {
            List<int> list = new List<int>();
            // Adding elements to List
            for(int i=1;i<=10;i++)
            {
                list.Add(i);
            }
            //present element in list
            Console.WriteLine("Present Element in List : ");
            foreach (var k in list)
            {
                Console.WriteLine(k);
            }
            Console.Write("Result: ");
            // Check the elements of firstlist that
            // match the conditions defined by predicate
            Console.WriteLine(list.Exists(isEven));
        }
        static void ListFindPredicate()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Use Find Method");
            // Adding elements to List
            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }
            //present element in list
            Console.WriteLine("Present Element in List : ");
            foreach (var k in list)
            {
                Console.WriteLine(k);
            }
            Console.Write("Result: ");
            // Check the elements of firstlist that
            // match the conditions defined by predicate
            Console.WriteLine(list.Find(isEven));   // check condision and return first match occurence.
        }
        static void ListFindLastIndex()
        {
            // Creating an List<T> of Integers
            List<int> list = new List<int>();
            // Adding elements to List
            list.Add(4);
            list.Add(2);
            list.Add(7);
            list.Add(2);
            list.Add(6);
            list.Add(4);
            list.Add(3);
            Console.WriteLine("Elements Present in List:\n");
            int p = 0;

            // Displaying the elements of List
            foreach (int k in list)
            {
                Console.Write("At Position {0}: ", p);
                Console.WriteLine(k);
                p++;
            }
            // Will give the last occurrence of the
            // element of list that match the
            // conditions defined by predicate
            Console.Write("Index of Last element that fulfill the conditions: ");
            Console.WriteLine(list.LastIndexOf(list.FindLast(isEven)));
            Console.Write("Element is: ");
            Console.Write((list.FindLast(isEven)));
        }
        static void ListForeach()
        {
            List<string> list = new List<string>();
            list.Add("C");
            list.Add("C++");
            list.Add("Java");
            list.Add("Python");
            list.Add("C#");
            list.Add("Objective C");
            list.Add("Swift");
            list.Add("go Lang");
            list.ForEach(display);

        }
    }
}
