using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INHERITANCE");

            Patient p = new Patient();
            p.Examine("Ashfaaq");

            Children c = new Children();
            c.Examine("Ashfaaq Jr");
        }
    }

    #region "Parent/Base class"
    public class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public long SSN { get; set; }

        public void Examine(string pname)
        {
            Console.WriteLine("Examination of " + pname + " is completed");
        }

        public void Billing(long ssn)
        {
            Console.WriteLine("Billing is completed");
        }
    }
    #endregion

    public class Adult : Patient
    {
        
    }

    public class Children : Patient
    {
        public void Inoculate()
        {
            Console.WriteLine("Child has been inculated...");
        }
    }
}