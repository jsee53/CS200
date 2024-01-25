using System;

namespace CS200
{
    internal class Program118
    {
        public static void Solve118()
        {
            Predicate<int> isEven = n => n % 2 == 0;
            Console.WriteLine(isEven(6));

            Predicate<string> isLowerCase = s => s.Equals(s.ToLower());
            Console.WriteLine(isLowerCase("This is test"));
        }
    }
}