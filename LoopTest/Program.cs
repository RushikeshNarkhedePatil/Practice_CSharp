using System;

namespace LoopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            long Count = 0;
            Console.WriteLine("Start Time : "+start.ToString("F"));
            for (long i=long.MaxValue;i>0;i--)
            {
                Count++;
            }
            DateTime end = DateTime.Now;

            Console.WriteLine("Complition Time : "+end.ToString("F"));
            Console.WriteLine(Count);
        }
    }
}
