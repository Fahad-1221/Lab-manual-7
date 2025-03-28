using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Q3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let\nFirst number = 25\nSecond number = 5");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ");
            double n1 = 25;
            double n2 = 5;

            Console.WriteLine($"Addition : {Math.add(n1, n2)}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine($"Multiplication : {Math.multiply(n1, n2)}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ");

            Console.WriteLine($"Division : {Math.divide(n1, n2)}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine($"Subtraction : {Math.Subtract(n1, n2)}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine($"Division : {Math.divide(5, 0)}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ");
        }
    }
}
