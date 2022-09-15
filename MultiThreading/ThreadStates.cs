using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThreading
{
    public class ThreadStatesExample
    {
        public void Thread()
        {
            for(int i=1;i<=2;i++)
            {
                Console.WriteLine("My demo Thread");
            }
        }
    }
}
