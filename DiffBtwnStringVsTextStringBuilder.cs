using System;
using System.Text;

namespace DiffBtwnStringVsTextStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder userString = new StringBuilder("C# ");
            userString.Append("System.String ");
            userString.Append("vs ");
            userString.Append("System.Text.StringBuilder ");
            userString.Append("lesson. ");
            Console.WriteLine(userString.ToString());
        }
    }
}
