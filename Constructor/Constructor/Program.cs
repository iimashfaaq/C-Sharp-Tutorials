using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            DefConstructor dc = new DefConstructor();
            dc.DoThis();

            AddConstructor ac = new AddConstructor();
            AddConstructor ac1 = new AddConstructor(b:6, a:10);

            StaticMethod.Acc();
            StaticMethod sm = new StaticMethod();
            sm.Slow();
        }
    }

    public class DefConstructor
    {
        public void DoThis()
        {
            Console.WriteLine("DoThis has run...");
        }
    }

    public class AddConstructor
    {
        public AddConstructor()
        {
            Console.WriteLine("The constructor has been called");
            DoThat();
        }

        public AddConstructor(int a, int b = 10)
        {
            Console.WriteLine("Add : " + (a + b));
        }

        public void DoThat()
        {
            Console.WriteLine("DoThat had run...");
        }
    }


    public class StaticMethod
    {
        #region "Static method"
        public static void Acc()
        {
            Console.WriteLine("Acc...");
        }
        #endregion

        public void Slow()
        {
            Console.WriteLine("Slow...");
        }
    }
}
