using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            string s1 = "abcd";
            string s2 = "";
            string s3 = null;

            Console.WriteLine("String s1 {0}.", Test(s1));
            Console.WriteLine("String s2 {0}.", Test(s2));
            Console.WriteLine("String s3 {0}.", Test(s3));
            Console.Read();
        }

        public static String Test(string s)
        {
            if (String.IsNullOrEmpty(s))
                return "is null or empty";
            else
                return String.Format("(\"{0}\") is neither null nor empty", s);
        }
    }
}
