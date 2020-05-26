using System;
using System.Collections;

namespace IEnumerableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Car c = new Car();
            c[0] = "Ford";
            c[1] = "Mercedes";
            c[2] = "BMW";

            foreach (string x in c)
            {
                Console.WriteLine(x);
            }
        }
    }

    public class Car : IEnumerable
    {
        string[] car = new string[3];

        public string this[int CarNum]
        {
            get { return car[CarNum]; }
            set { car[CarNum] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (string c in car)
            {
                yield return c;
            }
        }
    }
}
