using System;
using System.Collections;

namespace EventInCSharp
{
    public class MyTest
    {
        public event EventHandler MyEvent
        {
            add
            {
                Console.WriteLine("add operation");
            }
            remove
            {
                Console.WriteLine("remove operation");
            }
        }
    }
    public class Test
    {
        public void TestEvent()
        {
            MyTest myTest = new MyTest();
            myTest.MyEvent += myTest_MyEvent;
            myTest.MyEvent -= myTest_MyEvent;
        }
        public void myTest_MyEvent(object sender, EventArgs e)
        {

        }
    }

    //public delegate void EventHandler(object sender, EventArgs e);
    //public class Publisher : ArrayList
    //{
    //    public event EventHandler ProdcutAddedInfo;
    //    protected virtual void OnChanged(EventArgs e)
    //    {
    //        if (ProdcutAddedInfo != null) ProdcutAddedInfo(this, e);
    //    }
    //    public override int Add(Object product)
    //    {
    //        int added = base.Add(product);
    //        OnChanged(EventArgs.Empty);
    //        return added;
    //    }
    //    public override void Clear()
    //    {
    //        base.Clear();
    //        OnChanged(EventArgs.Empty);
    //    }
    //    public override object this[int index]
    //    {
    //        set
    //        {
    //            base[index] = value;
    //            OnChanged(EventArgs.Empty);
    //        }
    //    }
    //}
    //public class Subscriber
    //{
    //    private Publisher publishers;
    //    public Subscriber(Publisher publisher)
    //    {
    //        this.publishers = publisher;
    //        publishers.ProdcutAddedInfo += publishers_ProdcutAddedInfo;
    //    }
    //    void publishers_ProdcutAddedInfo(object sender, EventArgs e)
    //    {
    //        if (sender == null)
    //        {
    //            Console.WriteLine("No New Product Added.");
    //            return;
    //        }
    //        Console.WriteLine("A New Prodct Added.");
    //    }
    //    public void UnSubscribeEvent()
    //    {
    //        publishers.ProdcutAddedInfo -= publishers_ProdcutAddedInfo;
    //    }
    //}



    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.TestEvent();
            Console.ReadKey();
            //Console.WriteLine("Hello World!");

            //Publisher publisher = new Publisher();
            //Subscriber subscriber = new Subscriber(publisher);
            //publisher.Add(new Product
            //{
            //    ProductName = "Complan",
            //    Price = 20
            //});
            //publisher.Add(new Product
            //{
            //    ProductName = "Horlics",
            //    Price = 120
            //});
            //publisher.Add(new Product
            //{
            //    ProductName = "Boost",
            //    Price = 200
            //});
            //subscriber.UnSubscribeEvent();
            //Console.ReadKey();

        }
    }
}
