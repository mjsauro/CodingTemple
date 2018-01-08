using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_04_Array_Sum
{
    class Program
    {
        public static int array(int[] arr)
        {
            int sum = 0;
            foreach (int x in arr)
            {
                sum += x;
            }
            return sum;

        }
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4 };
            int sum = array(numbers);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
