using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "non-generic method"
            ArrayList List1 = new ArrayList();

            List1.Add(3);
            List1.Add(5);
            List1.Add(11);
            //Gives an exception while runtime
            //List1.Add("Hello");

            Console.WriteLine("Non-generic list results...");
            foreach (int x in List1)
            {
                Console.WriteLine(x);
            }
            #endregion

            #region "generic method"
            List<int> list2 = new List<int>();
            list2.Add(5);
            list2.Add(7);
            //Gives an error while compile time 
            //list2.Add("Hello");

            Console.WriteLine("Generice list results...");
            foreach (int y in list2)
            {
                Console.WriteLine(y);
            }
            #endregion
        }
    }
}
