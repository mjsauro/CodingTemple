using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_02_Bool_String_Equal
{

    class Program
    {

        static void Main(string[] args)
        {
            string string1 = "Matt";
            string string2 = "Matt";
            bool areEqual = AreStringsEqual(string1, string2);
            Console.WriteLine("Are {0} and {1} Equal?: {2}", string1, string2, areEqual);
            Console.ReadLine();

            string1 = "Matt";
            string2 = "Bob";
            areEqual = AreStringsEqual(string1, string2);
            Console.WriteLine("Are {0} and {1} Equal?: {2}", string1, string2, areEqual);
            Console.ReadLine();
        }

        private static bool AreStringsEqual(string aString, string anotherString)
        {
            //So common, it's actually built into strings!
            //if(aString.Length != anotherString.Length)
            //{
            //    return false;
            //}
            //for(int i = 0; i < aString.Length; i++)
            //{
            //    if(aString[i] != anotherString[i])
            //    {
            //        return false;
            //    }
            //}
            //return true;

            //return aString == anotherString;

            //Ignoring capitalization
            //return aString.ToLowerInvariant() == anotherString.ToLowerInvariant();

            //using the built-in Compare function is also common:
            //this function works because strings implement the IComparable interface,
            //  allowing .Net to efficiently sort many strings


            return (string.Compare(aString, anotherString, true) == 0);

        }
    }
}
