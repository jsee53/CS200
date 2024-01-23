using System;

namespace CS200
{
    internal class Program072
    {
        public static void Solve072()
        {
            for (int year = 2001; year <= 2100; year++)
                if (IsLeapYear(year))
                    Console.Write("{0} ", year);
            Console.WriteLine();

        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}