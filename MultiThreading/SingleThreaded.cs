using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    public static class SingleThreaded
    {
        public static void Method1()
        {
            // It prints numbers from 0 to 10
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method1 is : {0}", i);
                if (i == 5)
                {
                    Thread.Sleep(10000); //10000 mili second means 10 second 
                }
            }
        }
        public static void Method2()
        {
            for(int j=0;j<=10;j++)
            {
                Console.WriteLine("Method2 is : {0}", j);
            }
        }
    }
}
