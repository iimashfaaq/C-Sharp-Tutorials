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
        //public delegate void del(string x);

        //public event del evt;

        public EventHandler evt;
        //pre-wired delegate
        //public delegate void EventHandler(object sender, EventArgs e);

        public void CheckBalance(int x)
        {
            if (x > 250)
                evt(this, EventArgs.Empty);
        }
    }

    public class EvtSubscriber
    {
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Sender " + sender + " above 250...");
        }
    }
}
