using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(24 / 5);

            //using variables
            int a = 24;
            int b = 5;
            Console.WriteLine(a / b);

            // to cast as double:
            Console.WriteLine((double)a / b);

            //Forced Truncation
            int e = (int)((double)a / b);
            Console.WriteLine(e);

            Console.ReadLine();
        }
    }
}
