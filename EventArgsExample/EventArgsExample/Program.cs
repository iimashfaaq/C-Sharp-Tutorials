using System;

namespace EventArgsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            EvtPublisher ep = new EvtPublisher();

            EvtSubscriber es = new EvtSubscriber();

            ep.evt += es.HandleEvent;

            ep.CheckBalance(300);
        }
    }

    public class EvtPublisher
    {
        public string Name;
        public EventHandler<EvtArgsClass> evt;

        public void CheckBalance(int x)
        {
            Name = "Ashfaaq";
            if (x > 250)
            {
                EvtArgsClass eac = new EvtArgsClass(" Balance above 250...");
                evt(this.Name, eac);
            }
        }
    }

    public class EvtSubscriber
    {
        public void HandleEvent(object sender, EvtArgsClass e)
        {
            Console.WriteLine("ATTENTION :" + sender + e.Message);
        }
    }

    public class EvtArgsClass : EventArgs 
    {
        public EvtArgsClass(string str)
        {
            msg = str;
        }

        private string msg;
        public string Message
        {
            get { return msg; }
        }
    }
}
