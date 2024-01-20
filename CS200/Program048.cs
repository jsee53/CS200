using System;

namespace CS200
{
    internal class Program048
    {
        public static void Solve048()
        {
            Console.WriteLine("n!을 계산합니다.");
            Console.WriteLine("정수 n을 입력하세요: ");
            int n = int.Parse(Console.ReadLine());

            int fact = 1;

            for (int i = 2; i <= n; i++)
                fact *= i;
            Console.WriteLine("{0}! = {1}", n, fact);
        }
    }
}