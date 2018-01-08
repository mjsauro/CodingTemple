using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //week 1 problem 1
            //using properties to affect the state of the console
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;

            //using methods to invoke some sort of action:
            Console.Beep(440, 100);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
