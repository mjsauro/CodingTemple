using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CharacterAndWidth
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a character: ");
            //char letter = Convert.ToChar(Console.ReadLine());
            char letter = PromptForCharacter("Enter a character: ");
            //Console.WriteLine("Enter the desired width: ");
            //int width = Convert.ToInt32(Console.ReadLine());
            int width = PromptForNumber("Enter the desired width: ");

            //new string helper method
            for (int i = 0; i < width; i += 1)
            {
                Console.WriteLine(new string(letter, width));
            }
            Console.ReadLine();

            //nested loop method
            width = PromptForNumber("Enter a number :");
            Console.WriteLine("Enter a character: ");
            ConsoleKeyInfo keypress = Console.ReadKey();
            char c = keypress.KeyChar;
            Console.WriteLine();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
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

        private static char PromptForCharacter(string promptString = "Enter a number: ")
        {
            char character;
            string input = "";
            while (!char.TryParse(input, out character))
            {
                Console.WriteLine(promptString);
                input = Console.ReadLine();
            }
            return character;
        }
    }
}
