using System;

namespace CS200
{
    internal class Program003
    {
        public static void Solve003()
        {
            Console.Write("Hello ");
            Console.WriteLine("World!");
            Console.Write("이름을 입력하세요: ");

            string name = Console.ReadLine();
            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");
        }
    }
}
