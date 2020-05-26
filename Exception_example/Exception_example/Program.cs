using System;

namespace Exception_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 0;

            try
            {
                Console.WriteLine("a divided by b is " + a / b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}
