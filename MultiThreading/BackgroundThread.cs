using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace MultiThreading
{
    public static class BackgroundThread
    {
        public static void myThread()
        {
            // Display the name of the
            // current working thread
            Console.WriteLine("Background Thread Example:");
            Console.WriteLine("In Progress Thread is : {0}",Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Completed Thread is : {0}",Thread.CurrentThread.Name);
        }
    }
}
