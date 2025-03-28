using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Default values Detail:  ");
            Person P1 = new Person();
            P1.Display_Detail();
            Console.WriteLine("\t\t\t--------------------------------------------------------");
            Console.WriteLine("Original detail of person: ");
            Person P2 = new Person("Fahad", 19, "P-96");
            P2.Display_Detail();
            Console.WriteLine("\t\t\t--------------------------------------------------------");
            Console.WriteLine("Now Change the address of the person: ");
            Person P3 = new Person(P2);
            P3.Address_Change("Umar Housing Colony");
            P3.Display_Detail();

        }
    }
}
