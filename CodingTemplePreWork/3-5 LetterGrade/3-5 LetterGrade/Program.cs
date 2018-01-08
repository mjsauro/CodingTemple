using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_LetterGrade
{

}


class Program
{
    static void Main(string[] args)
    {
        string letterGrade = Console.ReadLine().ToUpperInvariant();
        Console.WriteLine(letterGrade);
    }

    public string getGrade;
    public void Grade(string getGrade)
    {
        switch (getGrade)
        {
            case "A":
                Console.WriteLine("Excellent");
                break;
            case "B":
                Console.WriteLine("Well done!");
                break;
            case "C":
                Console.WriteLine("Average, not bad.");
                break;
            case "D":
                Console.WriteLine("You barely passed.");
                break;
            case "F":
                Console.WriteLine("Try again.");
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}

