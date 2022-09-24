using System;

namespace PropertiesOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // create three instances of
            // Student class it call constructor
            // three times which increase the counter
            ReadOnly R1 = new ReadOnly();
            ReadOnly R2 = new ReadOnly();
            ReadOnly R3 = new ReadOnly();

            // s1.Counter = 10;
            // Compile Time Error: Can't set value of
            // Counter because it is read only.

            Console.WriteLine("Total No of Student: " + ReadOnly.Counter);

            // Program Give Warning
            // The variable `s1' is assigned but its value is never used
        }
    }
}
