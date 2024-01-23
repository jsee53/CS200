using System;

namespace CS200
{
    internal class Program059
    {
        public static void Solve059()
        {
            Console.WriteLine("2차원 배열: arrA[2,3]");
            int[,] arrA = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0,5}", arrA[i, j]);
                Console.WriteLine();
            }
        }
    }
}