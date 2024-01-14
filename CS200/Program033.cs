using System;

namespace CS200
{
    internal class Program033
    {
        class ConstEx
        {
            public const int number = 3;
        }

        class ReadonlyEx
        {
            public readonly int number = 10;
            public ReadonlyEx()
            {
                number = 20;
            }
            public ReadonlyEx(int n)
            {
                number = n;
            }
        }

        public static void Solve033()
        {
            Console.WriteLine(ConstEx.number);

            ReadonlyEx inst1 = new ReadonlyEx();
            Console.WriteLine(inst1.number);

            ReadonlyEx inst2 = new ReadonlyEx(100);
            Console.WriteLine(inst2.number);
        }
    }
}