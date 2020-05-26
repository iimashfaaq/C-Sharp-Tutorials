using System;
using System.Threading;

namespace MultiThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Thread t = new Thread(WriteX);
            Thread t1 = new Thread(Write_w);
            t.Start();
            t1.Start();
            Console.WriteLine(t.Name);

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("O");
            }
        }

        static void WriteX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }
        }

        static void Write_w()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("_");
            }
        }
    }
}
