using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_A__Q1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Default Detail of car:");
            Car car1 = new Car();
            car1.Display();
            Console.WriteLine("Original Detail of car:");
            Car car2 = new Car("Honda", "City", 2016, 200);
            car2.Display();

            //Deep copy
            Car car3 = new Car(car2);
            Console.WriteLine("Now we increase its speed by 11 km/h.");
            car3.Acceleration(11);
            car3.Display();

        }
    }
}
