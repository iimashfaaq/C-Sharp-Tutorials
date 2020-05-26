using System;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Instatiate an event publisher object
            EvtPublisher ep = new EvtPublisher();

            //Instantiate an event subscriber object
            EvtSubscriber es = new EvtSubscriber();

            //publisher event pointing to subscriber target handler
            ep.evt += es.HandleEvent;

            ep.CheckBalance(300);
        }
    }

    public class EvtPublisher
    {
        public delegate void del(string x);

        public event del evt;

        public void CheckBalance(int x)
        {
            if (x > 250)
                evt("Balance above 250...");
        }
    }

    public class EvtSubscriber
    {
        public void HandleEvent(string s)
        {
            Console.WriteLine(s);
        }
    }
}
