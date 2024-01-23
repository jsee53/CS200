using System;

namespace CS200
{
    internal class Program079
    {
        public static void Solve079()
        {
            Console.WriteLine("Power(x,y)를 계산합니다.");
            Console.Write(" x를 입력하세요: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write(" y를 입력하세요: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(" {0}^{1} = {2}", x, y, Power(x, y));
        }

        private static double Power(double x, double y)
        {
            if (y == 0)
                return 1;
            else return x * Power(x, y - 1);
        }
    }
}