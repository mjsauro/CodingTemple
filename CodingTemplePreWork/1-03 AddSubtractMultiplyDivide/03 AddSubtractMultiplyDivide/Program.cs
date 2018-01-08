using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AddSubtractMultiplyDivide
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the first number:");
            //string input1 = Console.ReadLine();
            // Convert.ToInt32 is ok, but what if you can't convert the code?
            //int int1 = Convert.ToInt32(Console.ReadLine());
            string input1 = "";
            int num1;

            //the while statement will keep repeating until a valid integer is used as an input
            //this is an example of defensive coding to prevent your program from breaking
            while (!int.TryParse(input1, out num1))
            {
                Console.WriteLine("Enter the first number: ");
                input1 = Console.ReadLine();
            }

            //Console.WriteLine("Enter the second number:");
            //string input2 = Console.ReadLine();
            //int int1 = Convert.ToInt32(Console.ReadLine());ghj=
            string input2 = "";
            int num2;

            while (!int.TryParse(input2, out num2))
            {
                Console.WriteLine("Enter the second number: ");
                input2 = Console.ReadLine();
            }

            Console.WriteLine("Addition: {0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("Subtraction: {0} - {1} =  {2}", num1, num2, num1 - num2);
            Console.WriteLine("Mutiplication: {0} * {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("Division: {0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("Mod: {0} % {1} = {2}", num1, num2, num1 % num2);
            Console.ReadLine();
        }
    }
}
