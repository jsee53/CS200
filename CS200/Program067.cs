using System;

namespace cs200
{
    class Date067
    {
        public int year, month, day;

        public static bool isleapyear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        static int[] days = { 0, 31, 69, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        public int dayofyear()
        {
            return days[month - 1] + day + (month > 2 && isleapyear(year) ? 1 : 0);
        }
    }

    internal class program067
    {
        public static void solve067()
        {
            Date067 xmas = new Date067();

            xmas.year = 2018;
            xmas.month = 12;
            xmas.day = 25;

            Console.WriteLine("xmas : {0}/{1}/{2}는 {3}일째 되는 날입니다", xmas.year, xmas.month, xmas.day, xmas.dayofyear());

            if (Date067.isleapyear(2018) == true)
                Console.WriteLine("2018년은 윤년입니다");
            else
                Console.WriteLine("2018년은 평년입니다");
        }
    }
}