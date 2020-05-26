using System;

namespace PropertiesAndFields
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Person p = new Person();
            p.Age = 10;
        }
    }

    public class Person
    {
        public int Weight { get; set; }
           
        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if(value>0)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Age cannot be less than 0");
                }
            }
        }
    }
}