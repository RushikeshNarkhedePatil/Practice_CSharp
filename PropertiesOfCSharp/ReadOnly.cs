using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesOfCSharp
{
    // read only property
    class ReadOnly
    {
        // Declare counter field as count
        private static int count;
        // to define constructor
        public ReadOnly()
        {
            // increment the counter
            // using constructor
            count++;
        }
        // Declare counter property
        public static int Counter()
        {
            // read-only property
            get
            {
                return count;
            }
        }

    }
}
