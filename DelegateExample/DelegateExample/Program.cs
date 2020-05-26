using System;

namespace DelegateExample
{
    class Program
    {
        delegate int del1(int x, int y);
        delegate string del2(string x);

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Ashfaaq a = new Ashfaaq();

            del1 d = a.AddNum;
            Console.WriteLine(d(3,4));

            d = a.MulNum;
            Console.WriteLine(d(3,4));

            Ashfaaq2 a2 = new Ashfaaq2();
            del2 d2 = a2.Check;
            Console.WriteLine(d2("True"));
        }
    }

    public class Ashfaaq
    {
        public int AddNum(int a, int b)
        {
            return a + b;
        }

        public int MulNum(int a, int b)
        {
            return a * b;
        }

        public int Check()
        { return 6; }
    }

    public class Ashfaaq2
    {
        public string Check(string x)
        {
            return x;
        }
    }
}
