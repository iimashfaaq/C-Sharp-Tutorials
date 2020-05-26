using System;

namespace ExtensionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string x = "Hello";
            string y = "hello";

            Console.WriteLine(x + " is capitalized ? " + x.IsCap());
            Console.WriteLine(y + " is capitalized ? " + y.IsCap());
        }
    }

    //static class and static method used for extension method
    public static class StringCap
    {
        public static bool IsCap(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }
    }
}
