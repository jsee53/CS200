using System;

namespace CS200
{
    internal class Program071
    {
        public static void Solve071()
        {
            int count = 0;
            for (int i = 2; i <= 100; i++)

                if (IsPrime(i))
                {
                    Console.Write("{0} ", i);
                    count++;
                }
            Console.WriteLine("\n2~100까지 소수는 모두 {0}개 있습니다.", count);
        }

        private static bool IsPrime(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
    }
}