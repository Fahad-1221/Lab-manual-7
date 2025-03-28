using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Q4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let a string:\nHi! My name is fahad and I'm a student of Software Engineering.");
            Console.WriteLine("----------------------------------------");

            string a = "Hi! My name is fahad and I'm a student of Software Engineering. ";
            Console.WriteLine($"Reverse : {String.ReverseString(a)}");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine($"Upper Case : {String.UpperCase(a)}");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine($"Number of characters  : {String.CountChar(a)}");
            Console.WriteLine("----------------------------------------");

        }
    }
}
