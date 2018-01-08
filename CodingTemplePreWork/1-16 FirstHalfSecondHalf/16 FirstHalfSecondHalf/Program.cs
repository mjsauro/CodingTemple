using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_FirstHalfSecondHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 2, 2, 2 };

            int totalF = 0;
            for (int i = 0; i < array.Length / 2; i++)
            {
                totalF += array[i];
            }

            int totalB = 0;
            for (int j = array.Length - 1; j >= array.Length / 2; j--)
            {
                totalB += array[j];
            }

            Console.WriteLine(totalF);
            Console.WriteLine(totalB);

            if (totalF == totalB)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            // option 2 - using LINQ
            if (array.Take(array.Length / 2).Sum() == array.Skip(array.Length / 2).Sum())
            {
                //TAKE will give me a  new object which only has the first half of the array
                //SKIP will give ma new object which only has the second half of the array
                Console.WriteLine("According to LINQ, both sides are equal");
            }
            else
            {
                Console.WriteLine("According to LINQ, they are not equal");
            }

            Console.ReadLine();
        }
    }
}
