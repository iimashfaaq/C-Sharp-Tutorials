using System;

namespace MulticastDelegate
{
    class Program
    {
        delegate void del(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Ashfaaq a = new Ashfaaq();
            del d = a.AddNumbers;
            Console.WriteLine("Invoking delegate with one target method...");
            d(3, 3);

            d += a.MulNumbers;
            Console.WriteLine("Invoking delegate with two target methods...");
            d(3, 3);

            d += a.SubNumbers;
            Console.WriteLine("Invoking delegate with one target method...");
            d(3, 3);

            Console.WriteLine("Invoking delegate without AddNumbers...");
            d -= a.AddNumbers;

            d(3, 3);
        }
    }

    public class Ashfaaq
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("Add numbers: " + (a + b));
        }

        public void MulNumbers(int a, int b)
        {
            Console.WriteLine("Mul numbers: " + (a * b));
        }

        public void SubNumbers(int a, int b)
        {
            Console.WriteLine("Sub numbers: " + (a - b));
        }
    } 
}
