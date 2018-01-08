using System;
using System.Linq;
namespace Fall2017.PreWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[7];

            vehicles[0] = new Vehicle();
            vehicles[0].Color = "Black";
            vehicles[0].Number = 1;
            vehicles[0].Driver = "Robert";

            //Another way to initialize the object:
            vehicles[1] = new Vehicle
            {
                Color = "Blue",
                Number = 23,
                Driver = "Matt"
            };

            vehicles[2] = new Vehicle
            {
                Color = "Lime",
                Number = 5,
                Driver = "J"
            };

            vehicles[3] = new Vehicle
            {
                Color = "Dark Magenta",
                Number = 42,
                Driver = "Declan"
            };

            vehicles[4] = new Vehicle
            {
                Color = "Green",
                Number = 17,
                Driver = "Kory"
            };

            vehicles[5] = new Vehicle
            {
                Color = "White",
                Number = 8,
                Driver = "Jake"
            };

            vehicles[6] = new Vehicle
            {
                Color = "Orange",
                Number = 24,
                Driver = "Adrian"
            };

            int lapNumber = 0;
            while (lapNumber < 20 && vehicles.Any(x => !x.Broken))
            {
                foreach (var vehicle in vehicles)
                {
                    int choice = PromptUserForNumber(string.Format("{0}, would you like to 1.take a lap, or 2.pit ?", vehicle.Driver));
                    if (choice == 2)
                    {
                        vehicle.Pit();
                    }
                    else
                    {
                        vehicle.TakeALap();
                    }
                }
                vehicles = vehicles.OrderBy(x => x.TotalTime).ToArray();
                Console.WriteLine("Current Standings:");
                for (int i = 0; i < vehicles.Length; i++)
                {
                    if (!vehicles[i].Broken)
                    {
                        Console.WriteLine("{0}:\t{1} in the {2} car\t\t{3}\t\t{4}\t{5}", i + 1, vehicles[i].Driver, vehicles[i].Color, vehicles[i].TotalTime, vehicles[i].FuelPercentage, vehicles[i].TirePercentage);
                    }
                    else
                    {
                        Console.WriteLine("{0} broke down on lap {1}", vehicles[i].Driver, vehicles[i].LapsTaken);
                    }
                }
                lapNumber++;

            }

            Console.ReadLine();


        }


        private static int PromptUserForNumber(string promptString = "Enter a number")
        {
            int num;
            string input = "";
            while (!int.TryParse(input, out num))
            {
                Console.WriteLine(promptString);
                input = Console.ReadLine();
            }

            return num;
        }
    }

    public class Vehicle
    {
        public Vehicle()
        {
            TotalTime = new TimeSpan();
            FuelPercentage = 100;
            TirePercentage = 100;
        }

        private static Random _r = new Random();

        public string Color { get; set; }
        public int Number { get; set; }
        public string Driver { get; set; }

        public bool Broken { get; private set; }

        public TimeSpan TotalTime { get; private set; }

        public decimal FuelPercentage { get; private set; }

        public decimal TirePercentage { get; private set; }

        public int LapsTaken { get; private set; }

        public void TakeALap()
        {
            if (!Broken)
            {
                FuelPercentage -= _r.Next(10, 20);
                TirePercentage -= _r.Next(5, 10);
                LapsTaken += 1;
                TotalTime += new TimeSpan(0, 0, _r.Next(45, 70));


                if (_r.Next(0, 50) == 1)
                {
                    Broken = true;
                }

                if (FuelPercentage <= 0)
                {
                    Broken = true;
                }
                if (TirePercentage <= 0)
                {
                    Broken = true;
                }
            }
        }

        public void Pit()
        {
            TotalTime += new TimeSpan(0, 0, _r.Next(15, 20));
            FuelPercentage = 100;
            TirePercentage = 100;
            TakeALap();
        }


    }


}
