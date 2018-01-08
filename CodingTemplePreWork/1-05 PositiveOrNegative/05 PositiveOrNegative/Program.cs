using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PositiveOrNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive!");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative!");
            }
            else
            {
                Console.WriteLine("The number is 0.");
            }

            //ternary operator
            string output = number >= 0 ? "Number is postive." : "Number is negative.";
            Console.WriteLine(output);


            Console.ReadLine();
        }
    }
}
