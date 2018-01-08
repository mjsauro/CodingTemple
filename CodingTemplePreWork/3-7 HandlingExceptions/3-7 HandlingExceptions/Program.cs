using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_7_HandlingExceptions
{

    class DivNumbers
    {
        public int result;
        public DivNumbers()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            {
                d.division(25, 0);
                d.division(25, 5);
                Console.ReadLine();
            }
        }
    }
}
