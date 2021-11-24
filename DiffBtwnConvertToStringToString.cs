using System;

namespace DiffBtwnConvertToStringToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            //string str = ToString.C1;
            string str = Convert.ToString(C1);
            Console.WriteLine(str);
        }
    }

    public class Customer
    {
        public string Name { get; set; }
    }
}
