using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_09_Vehicle
{
    public enum VehicleMake
    {
        GM, 
        Ford, 
        Lincoln, 
        Chrysler, 
        Cadillac,
        Jeep,
        Tesla,
        Nissan,
        Mitsubishi,
        Infiniti,
        Honda,
        Toyota,
        Mercedes,
        Audi,
        BMW,
        Volkswagen
    }
    public class Vehicle
    {
        //public static string[] Makes = {"GM", "Ford", "Lincoln", "Chrysler", "Cadillac", "Jeep", "Tesla,", "Nissan", "Mitsubishi",
        //"Infiniti", "Honda", "Toyota", "Mercedes Benz", "Audi", "BMW", "Volkswagen"
        //};

        public VehicleMake Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Miles { get; set; }

        public bool IsNew()
        {
            if (this.Miles > 25)
            {
                return false;
            }
            else
            {
                return true;
            }
            //another method
            //return Miles <=25;
        }
        public bool IsDomestic()
        {

            //for (int i = 0; i < 7; i++)
            //{
            //    if(this.Make == Makes[i])
            //    {
            //        return true;
            //    }
            //}
            //return false;

            //another method
            return ((int)this.Make < 7);
        }

        public string WhatColor()
        {
            return Color;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[2];

            vehicles[0] = new Vehicle
            {
            Make = VehicleMake.Toyota,
            Model = "Camry",
            Year = 2017,
            Color = "blue",
            Miles = 10,
            };

            vehicles[1] = new Vehicle
            {
            Make = VehicleMake.Honda,
            Model = "Accord",
            Year = 2010,
            Color = "red",
            Miles = 75682,
            };

            for (int i = 0; i < vehicles.Length; i++)
            {
                Console.WriteLine("{0} {1} {2} {3} with {4} miles - Is New? {5}  Is Domestic? {6}",
                    vehicles[i].Color,
                    vehicles[i].Year,
                    vehicles[i].Make,
                    vehicles[i].Model,
                    vehicles[i].Miles,
                    vehicles[i].IsNew(),
                    vehicles[i].IsDomestic()
                    );
            }
            //Console.WriteLine("Is the car new? {0}", vehicles[0].IsNew());
            //Console.WriteLine("Is the car domestic? {0}", vehicles[0].IsDomestic());
            //Console.WriteLine("What color is the car? {0}", vehicles[0].WhatColor());
            Console.ReadLine();
        }
    }
}
