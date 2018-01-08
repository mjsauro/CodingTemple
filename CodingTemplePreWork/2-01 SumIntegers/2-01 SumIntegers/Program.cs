using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_01_SumIntegers
{
    class Program
    {
        //format of a method:
        // access modifier: public, private, proctected - if not specificed, it's private
        // additional keywords like: static, new, virtual, override - these control method behaviors - none of these are required
        // return type: What is the data type that the method returns (if nothing, specified, void)
        // name of the method:  Alpha-Numeric string, no spaces, avoid underscores.  use camelCase
        //  for convention sake, method names should properly describe what the method does.
        // Optional parameters: in parentheses, a comma-separated set of "datatype parameterName"
        //  datatype: any sort of common struct (int, char, bool, etc), or complex classes, or arrays / lists
        //  paremterName: must be unique for the method, follows camelCase
        //Method body: inside of curly braces, immediately after the closing argument parentheses.
        //  The return type, name, and arguments form the "Method Signature"
        //  This combination of name + parameters has to be unique per each class.

        /// <summary>
        /// This method adds two numbers together
        /// </summary>
        /// <param name="number1">The first number</param>
        /// <param name="number2">The second number</param>
        /// <returns></returns>
        public static int Sum(int number1, int number2)
        {
            //Within the Sum method, there are two variables in scope, number1 and number2
            //Even though Sum is called by Main, I can't see up into the scope of Main
            return number1 + number2;
        }

        static void Main(string[] args)
        {
            //Within the Main method, I have three variables in scope, v1, v2, v3
            int v1 = 20;
            int v2 = 5;
            int v3 = Sum(v1, v2);
            Console.WriteLine("The sum of {0} + {1} is: {2}", v1, v2, v3);
            Console.ReadLine();
        }
    }
}
