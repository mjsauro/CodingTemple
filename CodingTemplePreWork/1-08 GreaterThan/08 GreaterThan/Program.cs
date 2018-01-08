using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_GreaterThan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine("Greatest number is: " + a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine("Greatest number is: " + b);
            }
            else if (c >= a && c >= b)
            {
                Console.WriteLine("Greatest number is: " + c);
            }

            // alternative method:
            int largestNumber = a;

            if (b > largestNumber)
            {
                largestNumber = b;
            }
            if (c > largestNumber)
            {
                largestNumber = c;
            }

            Console.WriteLine("The largest number is {0}", largestNumber);

            //array method
            int largest = (new int[] { a, b, c }).Max();
            Console.WriteLine("The largest number is {0}:", largest);

            Console.ReadLine();
        }   
    }
}
