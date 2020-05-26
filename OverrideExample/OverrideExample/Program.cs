using System;

namespace OverrideExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Override methods!");

            Patient p = new Patient();
            Adult a = new Adult();

            p.Examine();
            a.Examine();
        }
    }

    public class Patient
    {
        public virtual void Examine()
        {
            Console.WriteLine("The Patient has been examined...");
        }
    }

    public class Adult : Patient
    {
        public override void Examine()
        {
            Console.WriteLine("The adult has been examined...");
        }
    }
}
