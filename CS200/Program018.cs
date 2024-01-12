using System;

namespace CS200
{
    internal class Program018
    {
        public static void Solve018()
        {
            int x = 10, y = 0;

            try
            {
                Console.WriteLine(x / y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
