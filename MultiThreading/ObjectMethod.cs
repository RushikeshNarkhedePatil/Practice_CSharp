using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThreading
{
    public class StartObjectMethod
    {
        public void Job1(object value)
        {
            Console.WriteLine("Data of Thread 1 is: {0}", value);
        }
        public static void Job2(object value)
        {
            Console.WriteLine("Data of Thread 1 is: {0}", value);
        }
    }
}
