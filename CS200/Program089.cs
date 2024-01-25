using System;

namespace CS200
{
    internal class Program089
    {
        public static void Solve089()
        {
            int a = 3;
            Sqr(3);
            Console.WriteLine("Value: {0}", a);

            int b = 3;
            Sqr(ref b);
            Console.WriteLine("ref: {0}", b);

            string name;
            int id;
            GetName(out name, out id);
            Console.WriteLine("out: {0} {1}", name, id);
        }

        static void Sqr(int x)
        {
            x = x * x;
        }

        static void Sqr(ref int x)
        {
            x = x * x;
        }

        static void GetName(out string name, out int id)
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Id: ");
            id = int.Parse(Console.ReadLine());
        }
    }
}