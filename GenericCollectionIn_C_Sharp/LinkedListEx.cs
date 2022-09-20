using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionIn_C_Sharp
{
    class LinkedListEx
    {
        // display method
        static void display(IEnumerator<int> em)
        {
            while (em.MoveNext())
            {
                int val = em.Current;
                Console.WriteLine(val);
            }
        }
        public LinkedListEx()
        {
            int choice = 0;
            Console.WriteLine("Operation on LinkedList : Select your Choice");
            Console.WriteLine("1. Check LinkedList Empty Or Not\n2. Display First And Last Element" +
                "\n3. Clear / Remove all Nodes" +
                "\n4. Contain Value present or not\n5. Copy LinkedList to Array\n6. Object Equal or not\n7. Find Element\n8. Find last node" +
                "\n9. GetEnumerator Method\n10. Remove Specific Node\n11. RemoveFirst");
            choice = Convert.ToInt32(Console.ReadLine()); //convert string to integer
            switch (choice)
            {
                case 1:
                    LinkedListEx.CheckListEmptyOrNot();
                    break;
                case 2:
                    LinkedListEx.FirstAndLast();
                    break;
                case 3:
                    LinkedListEx.Clear();
                    break;
                case 4:
                    LinkedListEx.Contains();
                    break;
                case 5:
                    LinkedListEx.CpyLinkedListToArray();
                    break;
                case 6:
                    LinkedListEx.ObjectEqualOrNot();
                    break;
                case 7:
                    LinkedListEx.FindElement();
                    break;
                case 8:
                    LinkedListEx.FindLast();
                    break;
                case 9:
                    LinkedListEx.GetEnumeratorEx();
                    break;
                case 10:
                    LinkedListEx.RemoveSpecificNode();
                    break;
                case 11:
                    LinkedListEx.RemoveFirst();
                    break;
                default:
                    break;
            }
        }
        static void RemoveFirst()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
        
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            if (linkedList.Count == 0)      // check Linked list 
            {
                Console.WriteLine("LinkedList is empty!");
                return;
            }
            Console.WriteLine("Display elements of linkedlist are :");
            foreach (var k in linkedList)
            {
                Console.WriteLine(k);
            }
            linkedList.RemoveFirst();   // Remove first nodes.
            Console.WriteLine("Display element after Remove First");
            foreach (var k in linkedList)
            {
                Console.WriteLine(k);
            }

        }
        static void RemoveSpecificNode()
        {
            int i = 0;
            Console.WriteLine("Dispaly all nodes...");
            LinkedList<int> likendList = new LinkedList<int>();
            for(i=1;i<=10;i++)
            {
                likendList.AddLast(i);      // add node
                Console.WriteLine(i);
            }
            Console.WriteLine("Total Count Of Nodes : "+likendList.Count);
            // Remove Specific node
            int pos;
            Console.WriteLine("Enter possition to Remove Nodes");
            pos = Convert.ToInt32(Console.ReadLine());   // accept user input set position to remove
            // check nodes present or not
            if(pos<likendList.Count)
            {
                likendList.Remove(pos);
                foreach (var k in likendList)   // display nodes after Remove
                {
                    Console.WriteLine(k);
                }
            }
            else
            {
                Console.WriteLine("Nodes are not Present in this LinkedList...");
            }
            Console.WriteLine("Total Count Of Nodes : " + likendList.Count);
        }
        static void GetEnumeratorEx()
        {
            // LinkedList<T>.GetEnumerator Method is used to get an enumerator that iterates through the LinkedList<T>.
            // Creating a LinkedList of Integers
            LinkedList<int> myList = new LinkedList<int>();

            // Adding nodes in LinkedList
            myList.AddLast(2);
            myList.AddLast(4);
            myList.AddLast(6);
            myList.AddLast(8);

            // To get an Enumerator
            // for the List.
            LinkedList<int>.Enumerator em = myList.GetEnumerator();
            display(em);
        }
        static void FindLast()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(11);
            linkedList.AddLast(21);
            linkedList.AddLast(31);
            linkedList.AddLast(41);
            linkedList.AddLast(51);
            linkedList.AddLast(51);

            // Finding the last node that
            // contains the specified value
            LinkedListNode<int> temp = linkedList.Find(51);
            Console.WriteLine(temp.Value);
        }
        static void FindElement()
        {
            // Create Linked List
            LinkedList<int> linkedlist1 = new LinkedList<int>();    // linkedlist1 is the object of linked list
            // Adding node.
            linkedlist1.AddLast(11);
            linkedlist1.AddLast(12);
            linkedlist1.AddLast(13);
            linkedlist1.AddLast(14);
            linkedlist1.AddLast(15);

            // Finding the first node that
            // contains the specified value
            int x;
            Console.WriteLine("Find Element :");
            x = Convert.ToInt32(Console.ReadLine()); //convert string to integer
            LinkedListNode<int> temp = linkedlist1.Find(x);
            try
            {
                Console.WriteLine(temp.Value);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Number is Not Present : "+e.Message);
            }

        }
        static void ObjectEqualOrNot()
        {
            // Create Linked List
            LinkedList<int> linkedlist1 = new LinkedList<int>();
            // Adding node.
            linkedlist1.AddLast(11);
            linkedlist1.AddLast(12);
            linkedlist1.AddLast(13);
            linkedlist1.AddLast(14);
            linkedlist1.AddLast(15);
            // create second linked list.
            LinkedList<int> linkedlist2 = new LinkedList<int>();
            linkedlist2.AddLast(1);
            linkedlist2.AddLast(2);
            linkedlist2.AddLast(3);
            linkedlist2.AddLast(4);
            linkedlist2.AddLast(5);
            // check linkedlist1 is equal to linkedlist2 or not.
            Console.WriteLine(linkedlist1.Equals(linkedlist2));
            LinkedList<int> linkedlist3 = new LinkedList<int>();
            // Assigning linkedlist3 = linkedlist1
            linkedlist3 = linkedlist1;
            // checking linkedlist3 and 1 equal or not
            Console.WriteLine(linkedlist3.Equals(linkedlist1));
            
        }
        static void CpyLinkedListToArray()
        {

            // Create Linked List.
            LinkedList<string> linkedlist = new LinkedList<string>();
            // add node
            linkedlist.AddLast("a");
            linkedlist.AddLast("b");
            linkedlist.AddLast("c");
            linkedlist.AddLast("d");
            // Creating a string array
            string[] arr = new string[10];  // create string array of 10 elements.
            // Copying LinkedList to Array,
            // starting at the specified index
            // of the target array
            linkedlist.CopyTo(arr, 0);  // copy linked list to array.

            //Display element of array
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }
        }
        static void Contains()
        {
            // Create Linked List.
            LinkedList<string> linkedlist = new LinkedList<string>();
            // add node
            linkedlist.AddLast("a");
            linkedlist.AddLast("b");
            linkedlist.AddLast("c");
            linkedlist.AddLast("d");
            // To check if a value is in LinkedList
            Console.WriteLine(linkedlist.Contains("b"));

        }
        static void Clear()
        {
            // Create Linked List
            LinkedList<int> linkedlist = new LinkedList<int>();
            // Adding node.
            linkedlist.AddLast(11);
            linkedlist.AddLast(12);
            linkedlist.AddLast(13);
            linkedlist.AddLast(14);
            linkedlist.AddLast(15);
            // Check empty or not
            if(linkedlist.Count>0)
            {
                Console.WriteLine("Total Linked List Count Before Remove : " + linkedlist.Count);   // Display Count Before Removing
                linkedlist.Clear();     // Remove all nodes.
                Console.WriteLine("Total Linked List Count After Remove : " + linkedlist.Count);   // Display Count After Removing
            }
            else
            {
                Console.WriteLine("Linked list is empty");
            }
        }
        static void FirstAndLast()
        {
            // Create Linked List
            LinkedList<string> linkedList = new LinkedList<string>();
            // Adding Nodes in LinkedList
            linkedList.AddLast("Pavan");
            linkedList.AddLast("Kunal");
            linkedList.AddLast("Ankit");
            linkedList.AddFirst("Ganesh");
            // Check LinkedList Empty or not
            if(linkedList.Count>0)
            {
                Console.WriteLine("First Element is : " + linkedList.First.Value);    // access first Element.  // output Ganesh
                Console.WriteLine("Last Element is : " +linkedList.Last.Value);   //Display Last Element      // output Ankit
            }
            else
            {
                Console.WriteLine("Linked List is Empty");
            }

        }
        static void CheckListEmptyOrNot()
        {
            // Creating LinkedList Strings.
            LinkedList<String> myList = new LinkedList<String>();
            // Adding nodes in LinkedList
            myList.AddLast("c programming");
            myList.AddLast("c++");
            myList.AddLast("java");
            if (myList.Count>0)
            {
                Console.WriteLine("LinkedList is Not Empty!");
            }
            else
            {
                Console.WriteLine("LinkedList is Empty!");
            }
        }

    }
}
