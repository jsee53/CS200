using System;

namespace CS200
{
    internal class Program040
    {
        public static void Solve040()
        {
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine("{0}는 윤년", year);
            else
                Console.WriteLine("{0}는 평년", year);

            if (DateTime.IsLeapYear(year))
                Console.WriteLine("{0}는 윤년", year);
            else
                Console.WriteLine("{0}는 평년", year);
        }
    }
}