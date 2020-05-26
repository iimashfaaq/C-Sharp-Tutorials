using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            M1 m1 = new M1();
            M2 m2 = new M2();

            m1.Start();
            m1.Stop();

            m2.Start();
            m2.Stop();
        }
    }

    public class M1 : IControls
    {
        public void Start()
        {
            //add code
        }

        public void Stop()
        {
            //add code
        }
    }

    public class M2 : IControls
    {
        public void Start()
        {
            //add code
        }

        public void Stop()
        {
            //add code
        }
    }

    interface IControls
    {
        void Start();
        void Stop();
    }
}
