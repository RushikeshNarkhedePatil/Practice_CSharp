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
            // Background Thread.
            //creating and initilizing Thread.
            Thread thr = new Thread(BackgroundThread.myThread);
            // Name of the thread is Mythread
            thr.Name = "MyThread";
            thr.Start();
            // IsBackground is the property of Thread
            // which allows thread to run in the background
            thr.IsBackground = true;
            Console.WriteLine("Main Thread Ends!!");

            // Creating a object of NonStaticMethod.
            NonStaticMethod nobj = new NonStaticMethod();
            // Creating thread
            // Using thread class
            Thread thr1 = new Thread(new ThreadStart(nobj.myThread1));
            thr1.Start();

            //Abort Thread
            AbortThreadExample aboj = new AbortThreadExample();
            Thread athr = new Thread(new ThreadStart(aboj.Fun));
            Thread athr1 = new Thread(new ThreadStart(aboj.Gun));
            athr.Start();
            thr.Abort();
            //thr.Join();
            //athr1.Start();


        }
    }
}
