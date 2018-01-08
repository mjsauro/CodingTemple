using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_03_Hello_Append
{
    class Program
    {
        public static string Hello(string name)
        {
            return "Hello " + name;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Hello("Matt"));
            Console.ReadLine();
        }
    }
}
