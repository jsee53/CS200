﻿using System;
using System.Collections.Generic;

namespace CS200
{
    internal class Program104
    {
        public static void Solve104()
        {
            List<string> lstNames = new List<string>();
            lstNames.Add("dog");
            lstNames.Add("cow");
            lstNames.Add("rabbit");
            lstNames.Add("goat");
            lstNames.Add("sheep");
            lstNames.Sort();
            foreach (string s in lstNames)
                Console.Write(s + " ");
            Console.WriteLine();

            string[] arrNames = new string[5];
            arrNames[0] = "dog";
            arrNames[1] = "cow";
            arrNames[2] = "rabbit";
            arrNames[3] = "goat";
            arrNames[4] = "sheep";
            Array.Sort(arrNames);
            foreach (string s in arrNames)
                Console.Write(s + " ");
            Console.WriteLine();
        }
    }
}