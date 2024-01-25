﻿using System;

namespace CS200
{
    internal class Program093
    {
        public static void Solve093()
        {
            int[] a = { 1, 2, 3 };
            double[] d = { 0.1, 0.2, 0.3 };
            string[] s = { "tiger", "lion", "zebra" };

            PrintArray<int>(a);
            PrintArray<double>(d);
            PrintArray<string>(s);
        }

        private static void PrintArray<T>(T[] a)
        {
            foreach (var item in a)
                Console.Write("{0,8}", item);
            Console.WriteLine();
        }
    }
}