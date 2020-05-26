using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<string>();

            cars.Add("Toyota");
            cars.Add("Nissan");
            cars.Add("Lexus");

            foreach (var car in cars)
            {
                Console.WriteLine(car + " ");
            }
            //Console.WriteLine("Hello World!");

            int[] a1 = new int[] { 1, 3, 5, 7, 9 };

            foreach (int i in a1)
            {
                Console.WriteLine(i);
            }
        }   
    }
}
