using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_06_Power
{
    class Program
    {


        static void Main(string[] args)
        {
            int baseNumber = 2;
            int exponent = 3;
            Console.WriteLine(Power(baseNumber, exponent));
            Console.ReadLine();

            Console.WriteLine(PowerAgain(baseNumber, exponent));
            Console.ReadLine();
        }

        //method 1
        public static double Power(int num1, int num2)
        {
            return Math.Pow(num1, num2);
        }

        //method 2
        private static int PowerAgain(int baseNumber, int exponent)
        {
            int result = baseNumber;
            for (int i = 1; i < exponent; i++)
            {
                result *= baseNumber;
            }
            return result;
        }
    }
}
