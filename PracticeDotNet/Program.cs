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
            Console.WriteLine("Hello World!");
            // creating object "obj" of class "DelegateDemo"
            DelegateDemo obj= new DelegateDemo();

            // creating object of delegate, name as "del_obj1"
            // for method "sum" and "del_obj2" for method "subtract" &
            // pass the parameter as the two methods by class object "obj"
            // instantiating the delegates
            addnum del_obj1 = new addnum(obj.sum);
            subnum del_obj2 = new subnum(obj.subtract);

            // pass the values to the methods by delegate object
            del_obj1(100, 40);
            del_obj2(100, 60);
            obj.sum(10, 22);
            obj.subtract(10, 5);

            // These can be written as using
            // "Invoke" method
            // del_obj1.Invoke(100, 40);
            // del_obj2.Invoke(100, 60);
        }
    }
}
