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
        public HashSet()    // Constructer
        {
            int choice = 0;
            Console.WriteLine("Operation on HashSet : Select your Choice");
            Console.WriteLine("1. Creating HashSet\n2. Equals\n3. ExceptWith\n4.GetEnumerator\n5. IntersectWith");
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
                default:
                    break;
            }
        }
        static void IntersectWith()
        {
            // Creating a HashSet of integers
            HashSet<int> mySet1 = new HashSet<int>();

            // Creating a HashSet of integers
            HashSet<int> mySet2 = new HashSet<int>();
            // insert even no
            Console.WriteLine("Elements in Set 1 :");

            for (int i = 0; i < 5; i++)
            {
                mySet1.Add(i * 2);
                Console.WriteLine(i * 2);
            }
            // insert odd number
            Console.WriteLine("Elements in Set 2 : ");
            for (int i = 0; i < 5; i++)
            {
                mySet1.Add(i * 2 + 1);
                Console.WriteLine(i * 2 + 1);
            }
            // Creating a new HashSet that contains
            // the Intersection of both the HashSet mySet1 & mySet2
            HashSet<int> ans = new HashSet<int>(mySet1);
            ans.IntersectWith(mySet2);
            // Printing the Intersection of both the HashSets It should show no element in the output
            // as there is no element common in both the HashSets
            foreach (int i in ans)
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
