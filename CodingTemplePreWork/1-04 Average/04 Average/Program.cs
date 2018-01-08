using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //matt's code
            //Console.WriteLine("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter a number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter a number: ");
            //double num3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter a number: ");
            //double num4 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Average is: " + ((num1 + num2 + num3 + num4) / 4));
            //Console.ReadLine();

            //better code using multiple while loops
            //string input1 = "";
            //int num1;

            //while (!int.TryParse(input1, out num1))
            //{
            //    Console.WriteLine("Enter the first number: ");
            //    input1 = Console.ReadLine();
            //}

            //string input2 = "";
            //int num2;

            //while (!int.TryParse(input2, out num2))
            //{
            //    Console.WriteLine("Enter the second number: ");
            //    input2 = Console.ReadLine();
            //}

            //string input3 = "";
            //int num3;

            //while (!int.TryParse(input3, out num3))
            //{
            //    Console.WriteLine("Enter the third number: ");
            //    input3 = Console.ReadLine();
            //}

            //string input4 = "";
            //int num4;

            //while (!int.TryParse(input4, out num4))
            //{
            //    Console.WriteLine("Enter the fourth number: ");
            //    input4 = Console.ReadLine();
            //}

            //even better code using a helper method
            int num1 = PromptForNumber();
            int num2 = PromptForNumber("Enter a second number: ");
            int num3 = PromptForNumber("Enter a third number: ");
            int num4 = PromptForNumber("Enter a fourth number: ");

            Console.WriteLine("Average is {0}", ((double)num1 + num2 + num3 + num4) / 4);

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
