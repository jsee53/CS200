using System;

namespace CS200
{
    internal class Program006
    {
        public static void Solve006()
        {
            int i;
            double x;

            i = 5;
            x = 3.141592;
            Console.WriteLine("i = " + i + ", x = " + x);

            x = i;
            i = (int)x;
            Console.WriteLine("i = " + i + ", x = " + x);
        }
    }
}
