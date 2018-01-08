using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_05_String_Replace
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Replace("Hello", 4, 'x'));
            Console.ReadLine();

            string s1 = "hello";
            string result = ChangeChar(s1, 2, 'a');
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //1st method
        public static string Replace(string theString, int number, char character)
        {

            theString = theString.Remove(number, 1);
            theString = theString.Insert(number, character.ToString());

            return theString;
        }

        //2nd method
        private static string ChangeChar(string s1, int position, char character)
        {
            char[] s1AsCharArray = s1.ToCharArray();
            s1AsCharArray[position - 1] = character;
            return new string(s1AsCharArray);
        }
    }
}
