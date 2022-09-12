using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDotNet
{
    class Reference
    {
        public Reference()  //default constructer
        {
            // Initialize a and b
            int a = 10, b = 12;

            // Display initial values
            Console.WriteLine("Initial value of a is {0}", a);
            Console.WriteLine("Initial value of b is {0}", b);
            Console.WriteLine();

            // Call addValue method by value
            addValue(a);

            // Display modified value of a
            Console.WriteLine("Value of a after addition" +
                                  " operation is {0}", a);

            // Call subtractValue method by ref
            subtractValue(ref b);

            // Display modified value of b
            Console.WriteLine("Value of b after " +
                "subtraction operation is {0}\n", b);
        }
        // Define addValue
        // Parameters passed by value
        public void addValue(int a)
        {
            a += 10;    //a=a+10 means a=10+10
        }

        // Define subtractValue
        // Parameters passed by ref
        public void subtractValue(ref int b)
        {
            b -= 5; //b=b-5 means b=12-5 
        }
    }
}
