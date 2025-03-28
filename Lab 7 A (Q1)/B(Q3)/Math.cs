using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Q3_
{
    class Math
    {
        public static double add(double a, double b)
        {
            return a + b;
        }

        public static double multiply(double a, double b)
        {
            return a * b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine($"\nError !!");
                return 0;
            }
            else
            {
                return a / b;
            }
        }
    }
}
