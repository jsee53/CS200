﻿using System;

namespace CS200
{
    internal class Program050
    {
        public static void Solve050()
        {
            bool sign = false;
            double pi = 0;

            for (int i = 1; i <= 10000; i += 2)
            {
                if (sign == false)
                {
                    pi += 1.0 / i;
                    sign = true;
                }
                else
                {
                    pi -= 1.0 / i;
                    sign = false;
                }
                Console.WriteLine("i = {0}, PI = {1}", i, 4 * pi);
            }
        }
    }
}