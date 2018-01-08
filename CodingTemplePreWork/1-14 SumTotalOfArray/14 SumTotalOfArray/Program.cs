using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_SumTotalOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directly initializes an array with values
            // int[] numbers = { 1, 2, 3, 4, 5 };

            //Explictly size the array then set values
            // int[] moreNumbers = new int[5];
            // moreNumbers[0] = 1;
            // moreNumbers[1] = 2;
            // etc.


            // the "new" keyword is used to instruct the CLR to allocate the 
            // necessary bytes on a strcture called the "Heap"

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int total = 0;

            // for loop
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            Console.WriteLine(total);
            Console.ReadLine();

            // while loop
            total = 0;
            int j = 0;
            while (j < numbers.Length)
            {
                total += numbers[j];
                j++;
            }

            Console.WriteLine(total);
            Console.ReadLine();

            // for each loop
            total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            Console.WriteLine(total);
            Console.ReadLine();

            // LINQ
            total = 0;
            total = numbers.Sum();

            Console.WriteLine(total);
            Console.ReadLine();

            //another solution: (n * n + 1) / 2
        }
    }
}
