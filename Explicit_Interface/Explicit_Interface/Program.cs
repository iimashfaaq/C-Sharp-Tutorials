using System;

namespace Explicit_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            CFirst cf = new CFirst();
            cf.DoThis();

            ((ISecond)cf).DoThis();

            ISecond mm = new CFirst();
            mm.DoThis();
        }
    }

    interface IFirst
    {
        void DoThis();
    }

    interface ISecond
    {
        int DoThis();
    }

    public class CFirst : IFirst, ISecond
    {
        public void DoThis()
        {
            Console.WriteLine("IFirst...");
        }

        int ISecond.DoThis()
        {
            Console.WriteLine("ISecond...");
            return 6;
        }
    }
}
