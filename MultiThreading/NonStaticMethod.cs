using System;
using System.Collections.Generic;
using System.Text;

// C# program to illustrate the
// creation of thread using
// non-static method

namespace MultiThreading
{
    public class NonStaticMethod
    {
       public void myThread1()
       {
            Console.WriteLine("Non Static Thread Example:");
            for (int i=1;i<=3;i++)
            {
                Console.WriteLine("First Thread");
            }
       } 
    }
}
