using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_A__Q1_
{
    class Car
    {
       
            public string Make;
            public string Model;
            public int Year;
            public double Speed;

             public Car(string model, string make, int year, double speed)
            {
               Make = make;
               Model = model;
               Year = year;
               Speed = speed;
            }
            //Parameterless constructor
            public Car() : this("Unknown", "Generic", DateTime.Now.Year, 0) { }

            public Car(Car source)
            {
                Model = source.Model;
                Make = source.Make;
                Year = source.Year;
                Speed = source.Speed;
            }
            public void Acceleration(int Increase)
            {
                Speed += Increase;
                Console.WriteLine($"The Car Accelerated.So, new speed: {Speed} ");
            }
            public string Car_Make
            {
                get { return Model; }
                set { Model = value; }
            }
            public string Car_Model
            {
                get { return Model; }
                set { Model = value; }
            }
            public int Car_year
            {
                get { return Year; }
                set { Year = value; }
            }
            public double Car_speed
            {
                get { return Speed; }
                set { Speed = value; }
            }

       
            public void Display()
            {
                Console.WriteLine($"Make : {Make},\t    Model : {Model}\nYear of Manufacture : {Year},   Speed : {Speed} KM \n");

            }




        }
    }
    

