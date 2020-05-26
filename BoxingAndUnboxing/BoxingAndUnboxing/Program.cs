using System;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            object o;
            int x = 25;

            o = x;
            Console.WriteLine(x);
            Console.WriteLine(o);

            o = 123;
            x = Convert.ToInt32(o);
            Console.WriteLine(x);
            Console.WriteLine(o);
        }
    }
}
