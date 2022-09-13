using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single Threaded Application.
            Console.WriteLine("Single Threaded Application.");
            SingleThreaded.Method1();
            SingleThreaded.Method2();

            // Multi Threaded Application.
            Console.WriteLine("Multi Threaded Application.");
            Thread t1 = new Thread(MultiThreaded.Method1);
            Thread t2 = new Thread(MultiThreaded.Method2);
            t1.Start();
            t2.Start();

        }
    }
}
