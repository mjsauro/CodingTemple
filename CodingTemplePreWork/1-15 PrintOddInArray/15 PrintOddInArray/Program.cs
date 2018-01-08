using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_PrintOddInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 3, 3, 4, 8, 7, 5, 4, 3, 1 };

            //for loop
            for (int i = 0; i < array.Length; i += 2)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
