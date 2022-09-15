using System;

namespace FinalizeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Finalize Demo");
            FinalizeDemo fobj = new FinalizeDemo();
            fobj.ShowDurartion();
        }
    }
}
