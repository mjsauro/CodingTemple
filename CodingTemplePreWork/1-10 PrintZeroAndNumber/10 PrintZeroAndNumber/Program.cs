using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PrintZeroAndNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = Convert.ToInt32(Console.ReadLine());
            
            int number = PromptForNumber("Enter the maximum number: ");

            //while
            int i = 0;
            while (i <= number)
            {
                Console.WriteLine(i);
                i++;
            }

            //for loop
            for (int j = 0; j <= number; j++)
            {
                Console.WriteLine(j);
            }

            //do while

            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;  
            } while (i <= number);

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
