﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter();
            Counter c2 = new Counter();
            Counter c3 = new Counter();
            Counter c4 = new Counter();
            Console.WriteLine("\t\t\t----------------------------------------------------");
            Console.WriteLine($"Total Number of instances created : {Counter.Get_Count}");

        }
    }
}
