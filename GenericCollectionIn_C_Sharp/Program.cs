using System;

namespace GenericCollectionIn_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
      
            // Inside Main 
            Console.WriteLine("Operation On Generic Collection in c#");
             Console.WriteLine("1. Operation on List\n2. Operation on LinkedList\n3. HashSet");
             choice = Convert.ToInt32(Console.ReadLine());
            // create class object
            
            switch (choice)
             {
                 case 1:
                    ListExample lobj = new ListExample();
                    break;
                case 2:
                    LinkedListEx linkedList = new LinkedListEx();
                    break;
                case 3:
                    HashSet hObj = new HashSet();
                    break;
                 default:
                     break;
             }
            

        }
    }
}
