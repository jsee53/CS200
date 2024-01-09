using System;

namespace CS200
{
    internal class Program005
    {
        public static void Solve005()
        {
            string a = "hello";
            string b = "h";

            b = b + "ello";
            Console.WriteLine(a == b);
            Console.WriteLine("b = " + b);

            int x = 10;
            string c = b + '!' + " " + x;
            Console.WriteLine("c = " + c);
        }
    }
}
