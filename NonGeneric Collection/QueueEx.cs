using System;
using System.Collections;

namespace NonGeneric_Collection
{
    class QueueEx
    {
        public QueueEx()
        {
            // non-generic collection using Queue
            // Creating Queue
            Queue myQueue = new Queue();
            // Inserting the elements into the Queue
            myQueue.Enqueue("C#");      // Enqueue: add the element end of the queue.
            myQueue.Enqueue("Java");
            myQueue.Enqueue("C++");
            myQueue.Enqueue("C");
            myQueue.Enqueue("Perl");
            myQueue.Enqueue("php");
            // Displaying the count of elements
            // contained in the Queue
            Console.Write("Total number of elements present in the Queue are: ");

            Console.WriteLine(myQueue.Count);
            // Displaying the beginning element of Queue
            Console.WriteLine("Beginning Item is: " + myQueue.Peek());      
            Console.WriteLine("Remove Beginning element is: " + myQueue.Dequeue()); // Dequeue : Remove olded element from start queue.
            Console.WriteLine("Beginning Item is: " + myQueue.Peek());
            Console.WriteLine("Item Count is: " + myQueue.Count);


        }
    }
}
