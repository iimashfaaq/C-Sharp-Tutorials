using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Thread t1 = new Thread(Count);
            t1.Start();

            //Background thread will stip executing after
            //foreground theead is completed
            //will only run if the foreground runs for more 
            //time than the background time 
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 8; i++)
                {
                    Thread.Sleep(500);
                    Console.Write("T ");
                }
            });
        }

        static void Count()
        {
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(500);
                Console.Write("FG ");
            }

        }
    }
}
