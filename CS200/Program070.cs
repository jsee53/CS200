using System;

namespace CS200
{
    internal class Program070
    {
        public static void Solve070()
        {
            int a = 10, b = 30, c = 20;
            Console.WriteLine("가장 큰 수는{0}", Larger(Larger(a, b), c));
        }

        private static int Larger(int a, int b)
        {
            return (a >= b) ? a : b;
        }
    }
}