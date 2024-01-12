using System;

namespace CS200
{
    internal class Program022
    {
        public static void Solve022()
        {
            int x = 14, y = 11, result;

            result = x | y;
            Console.WriteLine("{0} | {1} = {2}", x, y, result);
            result = x & y;
            Console.WriteLine("{0} & {1} = {2}", x, y, result);
            result = x ^ y;
            Console.WriteLine("{0} ^ {1} = {2}", x, y, result);
            result = ~x;
            Console.WriteLine("~{0} = {1}", x, result);
            result = x << 2;
            Console.WriteLine("{0} << 2 = {1}", x, result);
            result = y >> 1;
            Console.WriteLine("{0} >> 1 = {1}", y, result);
        }
    }
}
