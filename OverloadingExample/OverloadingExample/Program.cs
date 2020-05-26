using System;

namespace OverloadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("METHOD OVERLOADING!");

            Patient p = new Patient();
            p.Bill();
            p.Bill(b: "Ashfaaq", a: 19);
            p.Bill(10, 19);

            Child c = new Child();
            c.Bill(10);
        }
    }

    public class Patient
    {
        public void Bill()
        {
            Console.WriteLine("Patient: Checked ");
        }

        public void Bill(int a)
        {
            Console.WriteLine("Patient: Checked with an integer");
        }

        public void Bill(int a, int b)
        {
            Console.WriteLine("Patient: Checked with two intgers");
        }

        public void Bill(int a, string b)
        {
            Console.WriteLine("Patient: Checked with an intger and a string");
        }
    }

    public class Child : Patient
    {
        public void Bill(string a, string b)
        {
            Console.WriteLine("Child: Checked with two strings");
        }
    }
}