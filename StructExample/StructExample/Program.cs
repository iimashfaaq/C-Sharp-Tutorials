using System;

namespace StructExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            AddNum a = new AddNum(4, 3);
            a.Add();
        }
    }

    public struct AddNum
    {
        private int x;
        private int y;

        public AddNum(int a, int b)
        {
            x = a;
            y = b;
        }

        public void Add()
        {
            Console.WriteLine(x + y);
        }
    }
}
