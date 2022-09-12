using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDotNet
{
    class StaticConstructer
    {
        // It is invoked before the first
        // instance constructor is run.
        static StaticConstructer()      //static constructer.
        {

            // The following statement produces
            // the first line of output,
            // and the line occurs only once.
            Console.WriteLine("Static Constructor");
        }

        // Instance constructor.
        public StaticConstructer(int i) 
        {
            Console.WriteLine("Instance Constructor " + i);
        }

        // Instance method.
        public string Person_detail(string name, int id)
        {
            return "Name:" + name + " id:" + id;
        }
    }
}
