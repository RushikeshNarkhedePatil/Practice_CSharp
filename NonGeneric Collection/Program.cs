using System;
using System.Collections;

namespace NonGeneric_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            int choise = 0;
            Console.WriteLine("1. Queue Demo\n2. HashTable");
            choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    QueueEx Que1 = new QueueEx();
                    break;
                case 2:
                    HashTableEx HashT = new HashTableEx();
                    break;
                default:
                    break;
            }
           
          
        }
    }
}
