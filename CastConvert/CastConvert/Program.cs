using System;

namespace CastConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            int num = 234789873;
            long bigNum = num;

            //eplicit conversion
            int i = 5;
            double d = 12.6;
            i = (int)d;
            Console.WriteLine("The double casted to int..." + i);

            //converts rounds up the value
            int ii = 7;
            double dd = 12.6;
            ii = Convert.ToInt32(dd);
            Console.WriteLine("Double converted to int ..." + ii);

            //casting would not work on string here, convert would get the exact value
            string str = "123";
            int r;
            r = Convert.ToInt32(str);
            Console.WriteLine("String converted to int... " + r);
        }
    }
}
