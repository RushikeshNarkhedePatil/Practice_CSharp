using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace PracticeDotNet
{
    class FinalizeExample
    {
        Stopwatch sw;
        public FinalizeExample()   // Constructer
        {
            sw = Stopwatch.StartNew();
            Console.WriteLine("Instantiated object");
        }
        public void ShowDurartion()
        {
            Console.WriteLine("This instance of {0} has been in existence for {1}", this, sw.Elapsed);
        }
        ~FinalizeExample()    // Destructer
        {
            Console.WriteLine("Finalizing object");
            sw.Stop();
            Console.WriteLine("This instance of {0} has been in existence for {1}", this, sw.Elapsed);
        }
    }
}
