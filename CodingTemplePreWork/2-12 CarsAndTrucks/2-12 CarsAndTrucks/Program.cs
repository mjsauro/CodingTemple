using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_12_CarsAndTrucks
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Miles { get; set; }
    }

    public class Car : Vehicle
    {
        public string Type
        {
            get
            {
                return "car";
            }
        }

        public class Truck : Vehicle
        {
            public string Type
            {
                get
                {
                    return "truck";
                }
            }

            class Program
            {
                static void Main(string[] args)
                {
                    Car myCar = new Car();
                    Console.WriteLine(myCar.Type);

                    Truck myTruck = new Truck();
                    Console.WriteLine(myTruck.Type);

                    //Polymorphism - can access myCar although we reference a vehicle
                    PaintTheVehicle(myCar, "red");

                    Console.ReadLine();
                }
                static void PaintTheVehicle(Vehicle vehicle, string color)
                {
                    vehicle.Color = color;
                }
            }
        }
    }
}
