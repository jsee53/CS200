﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CS200
{
    internal class Program121
    {
        public static void Solve121()
        {
            List<int> data = new List<int> { 123, 45, 12, 89, 456, 1, 4, 74, 46 };

            Print("data : ", data);

            var lstEven = from item in data
                          where (item > 20 && item % 2 == 0)
                          orderby item descending
                          select item;

            Print("20보다 큰 짝수 검색결과: ", lstEven);

            var lstSorted = from item in lstEven
                            orderby item ascending
                            select item * 2;

            Print("2를 곱해서 오름차순 정렬: ", lstSorted);
        }

        private static void Print(string s, IEnumerable<int> data)
        {
            Console.WriteLine(s);
            foreach (var i in data)
                Console.Write(" " + i);
            Console.WriteLine();
        }
    }
}