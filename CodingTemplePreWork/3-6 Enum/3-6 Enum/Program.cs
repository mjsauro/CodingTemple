using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_Enum
{
    enum Temperature
    {
        Low,
        Medium,
        High,
    }
    class Program
    {
        static void Main(string[] args)
        {
            GetTemp((Temperature)0);
            GetTemp((Temperature)1);
            GetTemp((Temperature)2);
            GetTemp((Temperature)3);
            Console.ReadLine();
        }
        static void GetTemp(Temperature num)
        {
            switch (num)
            {
                case Temperature.Low:
                    Console.WriteLine("Temp is low");
                    break;
                case Temperature.Medium:
                    Console.WriteLine("Temp is medium");
                    break;
                case Temperature.High:
                    Console.WriteLine("Temp is high");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

    }
}


