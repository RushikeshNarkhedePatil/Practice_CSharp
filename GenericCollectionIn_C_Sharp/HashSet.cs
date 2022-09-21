using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionIn_C_Sharp
{
    class HashSet
    {
        // display method
        static void display(IEnumerator<string> em)
        {
            while (em.MoveNext())
            {
                string val = em.Current;
                Console.WriteLine(val);
            }
        }
        private static bool isEven(int i)
        {
            return ((i % 2) == 0);
        }
        public HashSet()    // Constructer
        {
            int choice = 0;
            Console.WriteLine("Operation on HashSet : Select your Choice");
            Console.WriteLine("1. Creating HashSet\n2. Equals\n3. ExceptWith\n4.GetEnumerator\n5. IntersectWith\n6. OverLaps\n7. Remove\n8. RemoveWhere\n9. SetEquals");
            choice = Convert.ToInt32(Console.ReadLine()); //convert string to integer

            switch (choice)
            {
                case 1:
                    HashSet.HashSetDemo();
                    break;
                case 2:
                    HashSet.Equals();
                    break;
                case 3:
                    HashSet.ExceptWith();
                    break;
                case 4:
                    HashSet.GetEnumerator();
                    break;
                case 5:
                    HashSet.IntersectWith();
                    break;
                case 6:
                    HashSet.OverLaps();
                    break;
                case 7:
                    HashSet.Remove();
                    break;
                case 8:
                    HashSet.RemoveWhere();
                    break;
                case 9:
                    HashSet.SetEquals();
                    break;
                default:
                    break;
            }
        }
        static void SetEquals()
        {
            // Creating a HashSet of integers
            HashSet<int> mySet1 = new HashSet<int>();
            HashSet<int> mySet2 = new HashSet<int>();

            // Inserting elements into HashSet
            for (int i = 0; i < 10; i++)
            {
                mySet1.Add(i);
                mySet2.Add(i);
            }
            // check set equals
            Console.WriteLine(mySet1.SetEquals(mySet2));
        }
        static void RemoveWhere()
        {
            // Creating a HashSet of integers
            HashSet<int> mySet = new HashSet<int>();

            // Inserting elements into HashSet
            for (int i = 0; i < 10; i++)
            {
                mySet.Add(i);
            }

            Console.WriteLine("The elements in HashSet are : ");

            // Displaying the elements in HashSet
            foreach (int i in mySet)
            {
                Console.WriteLine(i);
            }

            // Displaying the number of elements in HashSet
            Console.WriteLine("Number of elements are : " + mySet.Count);

            // Remove elements from a HashSet
            // with conditions defined by the predicate
            mySet.RemoveWhere(isEven);

            Console.WriteLine("The elements in HashSet are : ");

            // Displaying the elements in HashSet
            foreach (int i in mySet)
            {
                Console.WriteLine(i);
            }

            // Displaying the number of elements in HashSet
            Console.WriteLine("Number of elements are : " + mySet.Count);
        }
        static void Remove()
        {
            HashSet<int> Hset1 = new HashSet<int>();
            //insert and display element
            Console.WriteLine("Display Original Element");
            for (int i = 1; i < 5; i++)    // insert element
            {
                Hset1.Add(i);
                Console.WriteLine(i);
            }
            Console.WriteLine("Total Count" + Hset1.Count);
            Console.WriteLine("Display After Remove");
            // display after remove
            // Removing the element 10 if present
            if (Hset1.Contains(4))
            {
                Hset1.Remove(4);
            }
            foreach (var k in Hset1)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Total Count" + Hset1.Count);
        }
        static void OverLaps()
        {
            HashSet<int> Hset1 = new HashSet<int>();
            HashSet<int> Hset2 = new HashSet<int>();
            for(int i=1;i<5;i++)    // insert element
            {
                Hset1.Add(i);
            }
            // insert element
            Hset2.Add(1);
            Hset2.Add(6);
            Hset2.Add(3);
            // Check if a HashSet and a specified
            // collection share common elements
            Console.WriteLine(Hset1.Overlaps(Hset2));
        }
        static void IntersectWith()
        {
            //// Creating a HashSet of integers
            //HashSet<int> mySet1 = new HashSet<int>();

            //// Creating a HashSet of integers
            //HashSet<int> mySet2 = new HashSet<int>();
            //// insert even no
            //Console.WriteLine("Elements in Set 1 :");

            //for (int i = 0; i < 5; i++)
            //{
            //    mySet1.Add(i * 2);
            //    Console.WriteLine(i * 2);
            //}
            //// insert odd number
            //Console.WriteLine("Elements in Set 2 : ");
            //for (int i = 0; i < 5; i++)
            //{
            //    mySet1.Add(i * 2 + 1);
            //    Console.WriteLine(i * 2 + 1);
            //}
            //// Creating a new HashSet that contains
            //// the Intersection of both the HashSet mySet1 & mySet2
            //HashSet<int> ans = new HashSet<int>(mySet1);
            //ans.IntersectWith(mySet2);
            //// Printing the Intersection of both the HashSets It should show no element in the output
            //// as there is no element common in both the HashSets
            //foreach (int i in ans)
            //{
            //    Console.WriteLine(i);
            //}

            // Creating a HashSet of strings
            HashSet<string> mySet1 = new HashSet<string>();

            // Creating a HashSet of strings
            HashSet<string> mySet2 = new HashSet<string>();

            // Inserting elements in mySet1
            mySet1.Add("Hello");
            mySet1.Add("Rushi");
            mySet1.Add("Rushikesh");

            // Inserting elements in mySet2
            mySet2.Add("narkhede");
            mySet2.Add("and");
            mySet2.Add("Rushi");
            mySet2.Add("are");
            mySet2.Add("the");
            mySet2.Add("best");

            // Creating a new HashSet that contains
            // the Intersection of both the HashSet mySet1 & mySet2
            HashSet<string> ans = new HashSet<string>(mySet1);

            ans.IntersectWith(mySet2);

            // Printing the Intersection of both the HashSet
            foreach (string i in ans)
            {
                Console.WriteLine(i);
            }
        }
        static void GetEnumerator()
        {
            // Creating a HashSet<T> of strings
            HashSet<string> mySet = new HashSet<string>();

            // Inserting elements in HashSet
            mySet.Add("DS");
            mySet.Add("C++");
            mySet.Add("Java");
            mySet.Add("C#");

            // To get an Enumerator
            // for the HashSet<T>.
            HashSet<string>.Enumerator em = mySet.GetEnumerator();
            display(em);
        }
        static void ExceptWith()
        {
            HashSet<int> mySet = new HashSet<int>();
            // inserting element into HashSet
            for(int i=1;i<7;i++)
            {
                mySet.Add(i);
            }
            // Creating a HashSet of integers
            HashSet<int> mySet1 = new HashSet<int>();
            for(int i=4;i<11;i++)
            {
                mySet1.Add(i);
            }
            // Removing all elements in a collection from a HashSet
            mySet1.ExceptWith(mySet);
            // printing element of hashSet1
            foreach (var k in mySet1)
            {
                Console.WriteLine(k);
            }
           // Console.WriteLine(mySet1.GetType()); // get the type of object
        }
        static void Equals()
        {
            // Equals(Object) Method which is inherited from the Object class is used to check if a
            // specified HashSet<T> object is equal to another HashSet<T> object or not.
            // Creating a HashSet of strings
            HashSet<string> mySet = new HashSet<string>();

            // Inserting elements in HashSet
            mySet.Add("DS");
            mySet.Add("C++");
            mySet.Add("Java");
            mySet.Add("JavaScript");

            // Checking whether mySet is
            // equal to itself or not
            Console.WriteLine(mySet.Equals(mySet));
        }
        static void HashSetDemo()
        {
            // Creating a HashSet of odd numbers
            HashSet<int> odd = new HashSet<int>();
            // Inserting elements in HashSet
            for (int i = 0; i < 5; i++)
            {
                odd.Add(2 * i + 1);
            }
            // Displaying the elements in the HashSet
            Console.WriteLine("Display elements :");
            foreach (var i in odd)
            {
                Console.WriteLine(i);
            }
            // check contains
            Console.WriteLine("Check contain present or not");
            int no = Convert.ToInt32(Console.ReadLine());
            if (odd.Contains(no))
            {
                Console.WriteLine("Required Element is present");
            }
            else
            { 
                Console.WriteLine("Required Element is not present");
            }
        }
    }
}
