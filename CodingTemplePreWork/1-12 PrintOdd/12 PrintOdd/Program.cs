using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_PrintOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number: ");
            int number = PromptForNumber();

            //Option 1 - using a conditional
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Option 2 - adjust the for loop mechanics
            for (int i = 1; i <= number; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        private static int PromptForNumber(string promptString = "Enter a number: ")
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
}
