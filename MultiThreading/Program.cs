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
            //thr.Abort();
            //thr.Join();
            athr1.Start();

            //Thread State.
            ThreadStatesExample tobj = new ThreadStatesExample();

            // Creating and initializing
            // threads Unstarted state
            Thread Thr = new Thread(new ThreadStart(tobj.Thread));
            Console.WriteLine("Thread State : {0} ", Thr.ThreadState);
            // Running state
            Thr.Start();
            Console.WriteLine("Thread State : {0} ", Thr.ThreadState);
            try
            {
                // Thr is in suspended state
                Thr.Suspend();
                Console.WriteLine("Thread State : {0} ", Thr.ThreadState);
                // Thr is resume to running state
                Thr.Resume();
                Console.WriteLine("Thread State : {0} ", Thr.ThreadState);
            }
            catch (PlatformNotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // C# program to illustrate the
            // use of Start(Object) method
            StartObjectMethod Oobj = new StartObjectMethod();
            // Creating and initializing threads
            Thread Othr = new Thread(Oobj.Job1);
            Thread Othr1 = new Thread(StartObjectMethod.Job2);
            Othr.Start(01);
            Othr1.Start("Hello");

            // Timer and callback method demo

            // Create an AutoResetEvent to signal the timeout threshold in the
            // timer callback has been reached.
            var autoEvent = new AutoResetEvent(false);

            var statusChecker = new StatusChecker(10);

            // Create a timer that invokes CheckStatus after one second, 
            // and every 1/4 second thereafter.
            Console.WriteLine("{0:h:mm:ss.fff} Creating timer.\n",
                              DateTime.Now);
            var stateTimer = new Timer(statusChecker.CheckStatus,
                                       autoEvent, 1000, 250);

            // When autoEvent signals, change the period to every half second.
            autoEvent.WaitOne();
            stateTimer.Change(0, 500);
            Console.WriteLine("\nChanging period to .5 seconds.\n");

            // When autoEvent signals the second time, dispose of the timer.
            autoEvent.WaitOne();
            stateTimer.Dispose();
            Console.WriteLine("\nDestroying timer.");

        }
    }
}
