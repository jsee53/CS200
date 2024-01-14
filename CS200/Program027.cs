using System;

namespace CS200
{
    internal class Program027
    {
        public static void Solve027()
        {
            string userName = "bikang";
            string date = DateTime.Today.ToShortDateString();

            string strPlus = "Hello " + userName + ". Today is " + date + ".";
            Console.WriteLine(strPlus);

            string strFormat = String.Format("Hello {0}. Today is {1}.", userName, date);
            Console.WriteLine(strFormat);

            string strInterpolation = $"Hello {userName}. Today is {date}.";
            Console.WriteLine(strInterpolation);

            string strConcat = string.Concat("Hello ", userName, ". Today is ", date, ".");
            Console.WriteLine(strConcat);

            string[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon" };
            string s = String.Concat(animals);
            Console.WriteLine(s);
            s = String.Join(", ", animals);
            Console.WriteLine(s);
        }
    }
}