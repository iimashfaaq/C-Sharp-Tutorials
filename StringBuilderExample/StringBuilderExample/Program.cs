using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "First ";
            s1 = s1 + "Second";

            Console.WriteLine(s1);

            StringBuilder s = new StringBuilder("This is the first part");
            Console.WriteLine(s);
            s.Replace("is", "that");
            Console.WriteLine(s);
        }
    }
}
