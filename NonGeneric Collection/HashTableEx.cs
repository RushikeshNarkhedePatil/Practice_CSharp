using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NonGeneric_Collection
{
    class HashTableEx
    {
        public HashTableEx()
        {
            // create and initialize Hash table
            // using Add() method
            Hashtable g = new Hashtable();
            g.Add(1, "welcome");
            g.Add(2, "to");
            g.Add(3, "tutorial");
            g.Add(4, "of");
            g.Add(5, "c#");
            ICollection key = g.Keys;
            // Print Hash table
            Console.WriteLine("Hashtable:");
            Console.WriteLine();
            foreach (var val in key)
            {
                Console.WriteLine(val + "-"+g[val]);
            }
        }
    }
}
