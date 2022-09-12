using System;

namespace PracticeDotNet
{
    class Program
    {
        //create delegate method
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Example:");
            // creating object "obj" of class "DelegateDemo"
            DelegateDemo obj= new DelegateDemo();

            addnum del_obj1 = new addnum(obj.sum);
            subnum del_obj2 = new subnum(obj.subtract);

            // pass the values to the methods by delegate object
            del_obj1(100, 40);
            del_obj2(100, 60);
            // These can be written as using
            // "Invoke" method
            // del_obj1.Invoke(100, 40);
            // del_obj2.Invoke(100, 60);

            // Reference Example
            Console.WriteLine("Reference Example:");
            Reference robj = new Reference();

            // static constructer Example

            Console.WriteLine("Static Constructer Example :");
            // Here Both Static and instance
            // constructors are invoked for
            // first instance
            StaticConstructer sobj = new StaticConstructer(1);

            Console.WriteLine(sobj.Person_detail("Pavan", 1));

            // Here only instance constructor
            // will be invoked
            StaticConstructer sobj1 = new StaticConstructer(2);

            Console.WriteLine(sobj1.Person_detail("Kunal", 2));
        }
    }
}
