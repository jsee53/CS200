using System;

namespace CS200
{
    internal class Program074
    {
        public static void Solve074()
        {
            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);
        }

        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}