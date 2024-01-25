using System;
using System.Collections;

namespace CS200
{
    public class ReverseComparer106 : IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            return string.Compare(s2, s1);
        }
    }

    internal class Program106
    {
        public static void Solve106()
        {
            string[] animalsEn = { "dog", "cow", "rabbit", "goat", "sheep", "mouse" };
            string[] animalsKo = { "개", "소", "토끼", "염소", "양", "쥐" };
            Display("Before Sort", animalsEn, animalsKo);

            Array.Sort(animalsEn, animalsKo);
            Display("After Sort by Korean", animalsEn, animalsKo);

            IComparer revCom = new ReverseComparer106();
            Array.Sort(animalsEn, animalsKo, revCom);
            Display("After Descending Sort", animalsEn, animalsKo);
        }

        private static void Display(string cmt, string[] a1, string[] a2)
        {
            Console.WriteLine(cmt);
            for (int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine(" [{0}]: {1,-8} {2,-8}", i, a1[i], a2[i]);
            }
            Console.WriteLine();
        }
    }
}