using System;
using System.Globalization;

namespace CS200
{
    internal class Program088
    {
        public static void Solve088()
        {
            DateTime today = DateTime.Now;

            Console.WriteLine(today.ToString("yyyy년 MM dd일"));
            Console.WriteLine(string.Format("{0:yyyy년 MM월 dd일}", today));
            Console.WriteLine(today.ToString("MMMM dd, yyyy ddd",
                CultureInfo.CreateSpecificCulture("en-US")));

            Console.WriteLine("d : " + today.ToString("d"));
            Console.WriteLine("D : " + string.Format("{0:D}", today));
            Console.WriteLine("t : " + string.Format("{0:t}", today));
            Console.WriteLine("T : " + string.Format("{0:T}", today));
            Console.WriteLine("g : " + string.Format("{0:g}", today));
            Console.WriteLine("G : " + string.Format("{0:G}", today));
            Console.WriteLine("f : " + string.Format("{0:f}", today));
            Console.WriteLine("F : " + string.Format("{0:F}", today));
            Console.WriteLine("s : " + string.Format("{0:s}", today));
            Console.WriteLine("o : " + string.Format("{0:o}", today));
            Console.WriteLine("r : " + string.Format("{0:r}", today));
            Console.WriteLine("u : " + string.Format("{0:u}", today));
        }
    }
}