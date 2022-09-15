using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace FinalizeExample
{
    public class FinalizeDemo
    {
        Stopwatch sw;
        public FinalizeDemo()   // Constructer
        {
            sw = Stopwatch.StartNew();
            Console.WriteLine("Instantiated object");
        }
        public void ShowDurartion()
        {
            Console.WriteLine("This instance of {0} has been in existence for {1}", this,sw.Elapsed);
        }
        ~FinalizeDemo()    // Destructer
        {
            Console.WriteLine("Finalizing object");
            sw.Stop();
            Console.WriteLine("This instance of {0} has been in existence for {1}",this, sw.Elapsed);
        }
    }
}
