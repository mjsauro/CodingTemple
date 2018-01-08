using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_AmountOfPositives
{
    class Program
    {
        static void Main(string[] args)
        {
            //matt's code
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int amountOfPositives = 0;

            if (a > 0)
            {
                amountOfPositives += 1;
            }

            if (b > 0)
            {
                amountOfPositives += 1;
            }

            //complex way
            if (a >= 0 && b >= 0)
            {
                amountOfPositives = 2;
            }
            else if (a >= 0 || b >= 0)
            {
                amountOfPositives = 1;
            }
            else
            {
                amountOfPositives = 0;
            }

            Console.WriteLine("Amount of Positives: {0}", amountOfPositives);
            Console.ReadLine();
        }
    }
}
