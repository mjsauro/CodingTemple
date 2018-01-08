using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_10_Point
{

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(5.0, 7.0);
            Point b = new Point(3.0, 2.0);
            double dis = distance(a, b);

            Console.WriteLine(dis);
            Console.ReadLine();
        }
        private static double distance(Point alpha, Point beta)
        {
            return Math.Sqrt(
                Math.Pow(alpha.X - beta.X, 2) +
                Math.Pow(alpha.Y - beta.Y, 2));
        }
    }
}
