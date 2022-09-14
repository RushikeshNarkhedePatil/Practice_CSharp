using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    public class AbortThreadExample
    {
        public void Fun()
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Inside Fun : " + i);
                }
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread - caught ThreadAbortException - resetting.");
                Console.WriteLine("Exception message: {0}", e.Message);
                Thread.ResetAbort();
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }
        public void Gun()
        {
            for(int i=5;i>0;i--)
            {
                Console.WriteLine("Inside Gun : " + i);
            }
        }
    }
}
