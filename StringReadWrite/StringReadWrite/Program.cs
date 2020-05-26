using System;
using System.IO;
using System.Text;

namespace StringReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            StringReadWrite sb = new StringReadWrite();
        }
    }

    # region "write and read data"
    public class StringReadWrite
    {
        StringBuilder sb = new StringBuilder();

        public StringReadWrite()
        {
            writeData();
            readData();
        }

        #region "write data into stringbuilder"

        public void writeData()
        {
            StringWriter sw = new StringWriter(sb);

            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();

            sw.WriteLine("Name " + name);

            sw.Flush();
            sw.Close();
        }

        #endregion

        #region "read data from  the stringBuilder"

        public void readData()
        {
            StringReader sr = new StringReader(sb.ToString());

            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }

        #endregion
    }
    #endregion

}
