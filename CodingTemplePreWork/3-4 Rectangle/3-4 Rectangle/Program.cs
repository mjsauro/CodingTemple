using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle(4, 5);
            Console.WriteLine(a.Area());
            a.getDetails();
            Console.ReadLine();
        }
    }

    public class Rectangle
    {
        private int Length { get; set; }
        private int Width { get; set; }


        public Rectangle(int length, int width)
        {
            Width = width;
            Length = length;
        }

        internal int Area()
        {
            return Length * Width;
        }

        internal void getDetails()
        {
            Console.WriteLine("Length: {0} Width {1}", Length, Width);
        }

    }
}
