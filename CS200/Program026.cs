using System;

namespace CS200
{
    internal class Program026
    {
        public static void Solve026()
        {
            Console.Write("더하고자 하는 숫자들을 입력하세요: ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();
            foreach (var i in v)
            {
                sum += int.Parse(i);
            }
            Console.WriteLine("결과는 {0}", sum);
        }
    }
}