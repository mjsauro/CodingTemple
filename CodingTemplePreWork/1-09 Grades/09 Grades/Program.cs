using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your score: ");
            //int score = Convert.ToInt32(Console.ReadLine());
            string input = "";
            int score = PromptForNumber("Enter your score: ");

            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80 & score < 90)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70 & score < 80)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60 & score < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }

            //using switch statement
            int leadingDigit = score / 10;

            switch (leadingDigit)
            {
                case 10:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
            Console.ReadLine();
        }

        private static int PromptForNumber(string promptString = "Enter a number: ")
        {
            int num;
            string input = "";
            while (!int.TryParse(input, out num))
            {
                Console.WriteLine(promptString);
                input = Console.ReadLine();
            }
            return num;
        }
    }
}
