using System;

namespace CS200
{
    internal class Program078
    {
        public static void Solve078()
        {
            for (double r = 1; r <= 10; r++)
                Console.WriteLine("Area of circle with radius {0,2} = {1,7:F2}", r, AreaOfCircle(r));
        }

        private static double AreaOfCircle(double r)
        {
            return Math.PI * r * r;
        }
    }
}