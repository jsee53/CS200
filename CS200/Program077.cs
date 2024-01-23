using System;

namespace CS200
{
    internal class Program077
    {
        public static void Solve077()
        {
            for (int i = 0; i <= 20; i++)
                Console.WriteLine("2 ^ {0,2} = {1, 7}", i, Power(2, i));
        }

        private static int Power(int n, int m)
        {
            int p = 1;
            for (int i = 1; i <= m; i++)
                p *= n;
            return p;
        }
    }
}