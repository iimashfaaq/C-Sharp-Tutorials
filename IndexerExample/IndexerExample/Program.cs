using System;

namespace IndexerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c[1] = "Mercedes";
            c[2] = "Toyota";
            c[3] = "BMW";
            c[4] = "Honda";

            Console.WriteLine("Car 1 ..." + c[1]);
            Console.WriteLine("Car 2 ..." + c[2]);
        }
    }

    public class Car
    {
        string[] car = new string[40];

        public string this[int carNum]
        {
            get
            {
                if (carNum >= 0 && carNum < car.Length)
                {
                    return car[carNum];
                }
                return "Out of range...";
            }

            set
            {
                if (carNum >= 0 && carNum < car.Length)
                {
                    car[carNum] = value;
                }
            }
        }
    }
}
