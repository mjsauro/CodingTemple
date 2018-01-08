using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_07_MaxArray
{
    class Program
    {
        public static int GreaterThan(int[] arr)

        {

            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(0, 100);
            }
            Console.WriteLine(GreaterThan(numbers));
            Console.ReadLine();

            //Using LINQ
            Console.WriteLine(numbers.Max());
            Console.ReadLine();
        }
    }
}
