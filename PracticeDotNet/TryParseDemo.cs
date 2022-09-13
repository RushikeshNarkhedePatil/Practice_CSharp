using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDotNet
{
    class TryParseDemo
    {
        public TryParseDemo()  //Default Constructer.
        {
            string[] Values = { null, "3746", "78673", "765.99", "16,645", "-322", "+865", "01FA" };

            foreach (var value in Values)
            {
                int number;
                bool success = int.TryParse(value,out number);
                if(success)
                {
                    Console.WriteLine($"Converted '{value}' to {number}.");
                }
                else
                {
                    Console.WriteLine($"Attempted conversion of '{value ??"<null>"}'failed.");
                }
            }
        }
    }
}
