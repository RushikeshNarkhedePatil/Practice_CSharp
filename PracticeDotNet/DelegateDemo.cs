﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDotNet
{
    class DelegateDemo
    {
        // Declaring the delegates
        // Here return type and parameter type should
        // be same as the return type and parameter type
        // of the two methods
        // "addnum" and "subnum" are two delegate names
        //public delegate void addnum(int a, int b);
        //public delegate void subnum(int a, int b);

        // method "sum"
        public void sum(int a, int b)
        {
            Console.WriteLine("("+a+" + "+b+")"+"= {0}", a + b);
        }

        // method "subtract"
        public void subtract(int a, int b)
        {
            //Console.WriteLine("(100 - 60) = {0}", a - b);
            Console.WriteLine("(" + a + " - " + b + ")" + "= {0}", a - b);
        }
    }
}
